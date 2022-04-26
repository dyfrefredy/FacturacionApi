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
    public class ClienteServiceBusiness : IClienteBusiness
    {

        private Logger logger = LogManager.GetCurrentClassLogger();
        IClienteApplication clienteApplication;
        private readonly IMapper mapper;

        public ClienteServiceBusiness(IMapper mapper, IClienteApplication clienteApplication)
        {
            this.mapper = mapper;
            this.clienteApplication = clienteApplication;
        }


        public ResultDto<ClienteDto> GetClienteByName(string name)
        {
            ResultDto<ClienteDto> resultDto = new ResultDto<ClienteDto>();
            try
            {
                List<Cliente> clienteResult = clienteApplication.GetClienteByName(name);
                if (clienteResult != null)
                {
                    List<ClienteDto> clienteDto = this.mapper.Map<List<Cliente>, List<ClienteDto>>(clienteResult);
                    resultDto.BusinessDto = new List<ClienteDto>();
                    resultDto.BusinessDto = clienteDto;
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta del cliente se realizo de forma exitosa",
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
                    Message = "La consulta del cliente genero un error",
                    Response = ResponseType.ERROR.GetDescription()
                };
                logger.Error(ex.ToString());
            }

            return resultDto;
        }
    }
}
