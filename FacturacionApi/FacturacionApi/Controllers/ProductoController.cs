using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FacturacionApi.Common.Dto;
using FacturacionApi.Common.Setting;
using FacturacionApi.Common.Utility;
using FacturacionApi.Interface.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacturacionApi.Controllers
{
    [Route("facturacion/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoBusiness productoService;        

        public ProductoController(IProductoBusiness productoService)
        {
            this.productoService = productoService;            
        }


        [HttpGet("GetProductoByName/{name}")]
        public ResultDto<ProductoDto> GetProductoByName(string name)
        {
            var cliente = productoService.GetProductoByName(name);
            return cliente;
        }
    }
}
