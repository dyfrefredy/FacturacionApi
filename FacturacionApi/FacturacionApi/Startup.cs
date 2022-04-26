using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FacturacionApi.Application.Application;
using FacturacionApi.Common.Setting;
using FacturacionApi.CrossCutting.EntityMapper;
using FacturacionApi.Interface.Application;
using FacturacionApi.Interface.Business;
using FacturacionApi.Model.Models;
using FacturacionApi.Service.Business;
using Azure.Core;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.AspNetCore.Authorization;

namespace FacturacionApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();

            services.AddControllers();
            services.AddControllersWithViews();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MapperDtoToModel());
                mc.AddProfile(new MapperModelToDto());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            var webSettingSecction = Configuration.GetSection("WebString");
            services.Configure<WebString>(webSettingSecction);


            var connectionString = string.Empty;

            var azureKeyVault = Configuration.GetSection("AzureKeyVault");
            string keyVaultEndpoint = azureKeyVault["KeyVaultEndpoint"];
            if (!string.IsNullOrEmpty(keyVaultEndpoint))
            {
                SecretClientOptions options = new SecretClientOptions()
                {
                    Retry =
                {
                    Delay= TimeSpan.FromSeconds(2),
                    MaxDelay = TimeSpan.FromSeconds(16),
                    MaxRetries = 5,
                    Mode = RetryMode.Exponential
                 }
                };

                var client = new SecretClient(new Uri(keyVaultEndpoint), new DefaultAzureCredential(), options);

                KeyVaultSecret secret = client.GetSecret(azureKeyVault["KeyVaultConnection"]);

                connectionString = secret.Value;
                services.Configure<ConnectionString>(d => d.CustomerService = connectionString);
            }
            else
            {
                connectionString = Configuration.GetConnectionString("CustomerService");
                services.Configure<ConnectionString>(d => d.CustomerService = connectionString);
            }

            services.AddEntityFrameworkSqlServer().AddDbContext<FacturacionContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<IVentaBusiness, VentaServiceBusiness>();
            services.AddScoped<IVentaApplication, VentaApplication>();

            services.AddScoped<IClienteBusiness, ClienteServiceBusiness>();
            services.AddScoped<IClienteApplication, ClienteApplication>();

            services.AddScoped<IProductoBusiness, ProductoServiceBusiness>();
            services.AddScoped<IProductoApplication, ProductoApplication>();

            AddSwagger(services);
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"CargoApps {groupName}",
                    Version = groupName,
                    Description = "CargoApps API",
                    Contact = new OpenApiContact
                    {
                        Name = "CargoApps",
                        Email = string.Empty,
                        Url = new Uri("https://foo.com/"),
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "CargoApps API V1");
            });
            app.UseRouting();

            ////TODO Validar configuracion en codigo para depliegue
            // global cors policy
            app.UseCors(x => x
               .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });
        }

        private Task AuthenticationFailed(AuthenticationFailedContext context)
        {
            return Task.FromResult(0);
        }
    }
}