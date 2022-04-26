using FacturacionApi.Common.Helper;
using FacturacionApi.Common.Setting;
using FacturacionApi.Common.Utility;
using FacturacionApi.Infrastructure.Repository;
using FacturacionApi.Interface.Application;
using FacturacionApi.Model.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FacturacionApi.Application.Application
{
    public class ProductoApplication: IProductoApplication
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private IRepository<Producto, int> repository;
        private string connectionString;

        public ProductoApplication(FacturacionContext context, IOptions<ConnectionString> connectionString)
        {
            this.repository = new Repository<Producto, int>(context);
            this.connectionString = connectionString.Value.CustomerService;
        }


        public List<Producto> GetProductoByName(string name)
        {
            List<Producto> productoResult = null;
            try
            {
                productoResult = repository.List(w => w.Descripcion.Contains(name)).OrderBy(o => o.Descripcion).ToList();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

            return productoResult;
        }
    }
}
