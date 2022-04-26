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
    public class VentaApplication: IVentaApplication
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        private IRepository<Venta, long> repository;
        private string connectionString;

        public VentaApplication(FacturacionContext context, IOptions<ConnectionString> connectionString)
        {
            this.repository = new Repository<Venta, long>(context);
            this.connectionString = connectionString.Value.CustomerService;
        }

        public List<Venta> GetVenta()
        {
            List<Venta> ventaResult = null;
            try
            {
                ventaResult = repository.List()
                    .Include(i => i.VentaProductos)
                    .Include(i => i.Cliente)
                    .ToList();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

            return ventaResult;
        }

        public Venta GetVenta(long id)
        {
            Venta ventaResult = null;
            try
            {
                ventaResult = repository.GetById(id);
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

            return ventaResult;
        }

        public Venta SaveVenta(Venta venta)
        {
            Venta ventaResult = null;
            try
            {
                ventaResult = repository.Add(venta);
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

            return ventaResult;
        }


        public int UpdateVenta(Venta venta)
        {
            int ventaResult = 0;
            try
            {
                ventaResult = repository.Edit(venta);
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

            return ventaResult;
        }
    }
}
