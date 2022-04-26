using FacturacionApi.Common.Dto;
using FacturacionApi.Common.Utility;
using FacturacionApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Interface.Application
{
    public interface IVentaApplication
    {
        List<Venta> GetVenta();

        Venta GetVenta(long id);

        Venta SaveVenta(Venta venta);

        int UpdateVenta(Venta venta);
    }
}
