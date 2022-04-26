using AutoMapper;
using FacturacionApi.Application.Application;
using FacturacionApi.Common.Dto;
using FacturacionApi.Common.Enumeration;
using FacturacionApi.Common.Helper;
using FacturacionApi.Common.Utility;
using FacturacionApi.Interface.Application;
using FacturacionApi.Interface.Business;
using FacturacionApi.Model.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Service.Business
{
    public class ProductoServiceBusiness : IProductoBusiness
    {

        private Logger logger = LogManager.GetCurrentClassLogger();
        IProductoApplication productoApplication;
        private readonly IMapper mapper;

        public ProductoServiceBusiness(IMapper mapper, IProductoApplication productoApplication)
        {
            this.mapper = mapper;
            this.productoApplication = productoApplication;
        }


        public ResultDto<ProductoDto> GetProductoByName(string name)
        {
            ResultDto<ProductoDto> resultDto = new ResultDto<ProductoDto>();
            try
            {
                List<Producto> productoResult = productoApplication.GetProductoByName(name);
                if (productoResult != null)
                {
                    List<ProductoDto> productoDto = this.mapper.Map<List<Producto>, List<ProductoDto>>(productoResult);
                    resultDto.BusinessDto = new List<ProductoDto>();
                    resultDto.BusinessDto = productoDto;
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta del producto se realizo de forma exitosa",
                        Response = ResponseType.OK.GetDescription()
                    };
                }
                else
                {
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta no arrojó ningún resultado",
                        Response = ResponseType.WARNING.GetDescription()
                    };
                }
            }
            catch (Exception ex)
            {

                resultDto.BusinessDto = null;
                resultDto.ResponseDto = new ResponseDto()
                {
                    Message = "La consulta del producto genero un error",
                    Response = ResponseType.ERROR.GetDescription()
                };
                logger.Error(ex.ToString());
            }

            return resultDto;
        }
    }
}
