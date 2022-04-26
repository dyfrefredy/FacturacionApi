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
    public class VentaController : ControllerBase
    {
        private readonly IVentaBusiness ventaService;        

        public VentaController(IVentaBusiness ventaService)
        {
            this.ventaService = ventaService;            
        }

        // GET: api/<VentaController>
        [HttpGet]
        public ResultDto<VentaDto> Get()
        {
           var result = ventaService.GetVenta();
            return result;
        }

        // GET api/<VentaController>/5
        [HttpGet("{id}")]
        public ResultDto<VentaDto> Get(int id)
        {
            var result = ventaService.GetVenta(id);
            return result;
        }

        // POST api/<VentaController>
        [HttpPost]        
        public ResultDto<VentaDto> Post([FromBody] VentaDto ventaDto)
        {
            var result = ventaService.SaveVenta(ventaDto);
            return result;
        }

        // PUT api/<VentaController>/5
        [HttpPut]
        public ResultDto<VentaDto> Put([FromBody] VentaDto ventaDto)
        {
            var result = ventaService.UpdateVenta(ventaDto);
            return result;
        }

        // DELETE api/<VentaController>/5
        [HttpDelete("{id}")]
        [AcceptVerbs("DELETE")]
        public ResultDto<VentaDto> Delete(List<int> id)
        {
            var result = ventaService.DeleteVenta(id);            
            return result;            
        }
    }
}
