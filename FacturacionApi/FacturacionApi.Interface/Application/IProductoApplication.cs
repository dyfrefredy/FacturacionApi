using FacturacionApi.Common.Dto;
using FacturacionApi.Common.Utility;
using FacturacionApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Interface.Application
{
    public interface IProductoApplication
    {
        List<Producto> GetProductoByName(string name);
    }
}
