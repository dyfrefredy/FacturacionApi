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
    public class ClienteController : ControllerBase
    {
        private readonly IClienteBusiness clienteService;        

        public ClienteController(IClienteBusiness clienteService)
        {
            this.clienteService = clienteService;            
        }


        [HttpGet("GetClienteByName/{name}")]
        public ResultDto<ClienteDto> GetClienteByName(string name)
        {
            var cliente = clienteService.GetClienteByName(name);
            return cliente;
        }
    }
}
