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
    public class ClienteApplication: IClienteApplication
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private IRepository<Cliente, int> repository;
        private string connectionString;

        public ClienteApplication(FacturacionContext context, IOptions<ConnectionString> connectionString)
        {
            this.repository = new Repository<Cliente, int>(context);
            this.connectionString = connectionString.Value.CustomerService;
        }


        public List<Cliente> GetClienteByName(string name)
        {
            List<Cliente> clienteResult = null;
            try
            {
                clienteResult = repository.List(w => w.Nombre.Contains(name) || w.Apellido.Contains(name)).OrderBy(o => o.Nombre).ToList();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

            return clienteResult;
        }
    }
}
