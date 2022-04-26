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
    public class VentaServiceBusiness : IVentaBusiness
    {

        private Logger logger = LogManager.GetCurrentClassLogger();
        IVentaApplication ventaApplication;
        private readonly IMapper mapper;

        public VentaServiceBusiness(IMapper mapper, IVentaApplication ventaApplication)
        {
            this.mapper = mapper;
            this.ventaApplication = ventaApplication;
        }

        public ResultDto<VentaDto> DeleteVenta(List<int> id)
        {
            ResultDto<VentaDto> resultDto = new ResultDto<VentaDto>();
            resultDto.ResponseDto = new ResponseDto();
            resultDto.BusinessDto = null;
            foreach (var item in id)
            {
                try
                {

                    Venta ventaResult = ventaApplication.GetVenta(item);
                    if (ventaResult != null)
                    {
                        int updateVenta = ventaApplication.UpdateVenta(ventaResult);
                        if (updateVenta != 0)
                        {

                            resultDto.ResponseDto.Message = string.Format("{0}\n{1}", resultDto.ResponseDto.Message, string.Format("La eliminación de la venta [{0}] se realizo de forma exitosa", ventaResult.Id));
                            resultDto.ResponseDto.Response = (resultDto.ResponseDto.Response != null && resultDto.ResponseDto.Response != ResponseType.OK.GetDescription()) ? ResponseType.WARNING.GetDescription() : ResponseType.OK.GetDescription();
                        }
                        else
                        {
                            resultDto.ResponseDto.Message = string.Format("{0}\n{1}", resultDto.ResponseDto.Message, string.Format("La eliminación de la venta [{0}] arrojó 0 filas afectadas", ventaResult.Id));
                            resultDto.ResponseDto.Response = ResponseType.WARNING.GetDescription();
                        }
                    }
                    else
                    {
                        resultDto.ResponseDto.Message = string.Format("{0}\n{1}", resultDto.ResponseDto.Message, string.Format("La venta [{0}] no existe en base de datos", ventaResult.Id));
                        resultDto.ResponseDto.Response = ResponseType.WARNING.GetDescription();
                    }
                }

                catch (Exception ex)
                {
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La eliminación de la venta genero un error",
                        Response = ResponseType.FAIL.GetDescription()
                    };
                    logger.Error(ex.ToString());
                }
            }

            return resultDto;
        }

        public ResultDto<VentaDto> GetVenta(int id)
        {
            ResultDto<VentaDto> resultDto = new ResultDto<VentaDto>();
            try
            {
                Venta ventaResult = ventaApplication.GetVenta(id);
                if (ventaResult != null)
                {
                    VentaDto ventaDto = this.mapper.Map<Venta, VentaDto>(ventaResult);
                    resultDto.BusinessDto = new List<VentaDto>();
                    resultDto.BusinessDto.Add(ventaDto);
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta de la venta se realizo de forma exitosa",
                        Response = ResponseType.OK.GetDescription()
                    };
                }
                else
                {
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta de la venta no arrojó ningún resultado",
                        Response = ResponseType.WARNING.GetDescription()
                    };
                }
            }
            catch (Exception ex)
            {

                resultDto.BusinessDto = null;
                resultDto.ResponseDto = new ResponseDto()
                {
                    Message = "La consulta de la venta genero un error",
                    Response = ResponseType.ERROR.GetDescription()
                };
                logger.Error(ex.ToString());
            }

            return resultDto;
        }

        public ResultDto<VentaDto> GetVenta()
        {
            ResultDto<VentaDto> resultDto = new ResultDto<VentaDto>();
            try
            {
                List<Venta> ventaResult = ventaApplication.GetVenta();
                if (ventaResult != null)
                {
                    List<VentaDto> ventaDto = this.mapper.Map<List<Venta>, List<VentaDto>>(ventaResult);
                    resultDto.BusinessDto = new List<VentaDto>();
                    resultDto.BusinessDto = ventaDto;
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta de la venta se realizo de forma exitosa",
                        Response = ResponseType.OK.GetDescription()
                    };
                }
                else
                {
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La consulta de la venta no arrojó ningún resultado",
                        Response = ResponseType.WARNING.GetDescription()
                    };
                }
            }
            catch (Exception ex)
            {

                resultDto.BusinessDto = null;
                resultDto.ResponseDto = new ResponseDto()
                {
                    Message = "La consulta de la venta genero un error",
                    Response = ResponseType.ERROR.GetDescription()
                };
                logger.Error(ex.ToString());
            }

            return resultDto;
        }

        public ResultDto<VentaDto> SaveVenta(VentaDto ventaDto)
        {
            ResultDto<VentaDto> resultDto = new ResultDto<VentaDto>();
            try
            {
                Venta venta = this.mapper.Map<VentaDto, Venta>(ventaDto);
                venta.Fecha = DateTime.Now;
                Venta ventaResult = ventaApplication.SaveVenta(venta);

                resultDto.ResponseDto = new ResponseDto()
                {
                    Message = "La creación de la venta se realizo de forma exitosa",
                    Response = ResponseType.OK.GetDescription()
                };
            }
            catch (Exception ex)
            {

                resultDto.BusinessDto = null;
                resultDto.ResponseDto = new ResponseDto()
                {
                    Message = "La creación de la venta genero un error",
                    Response = ResponseType.ERROR.GetDescription()
                };
                logger.Error(ex.ToString());
            }

            return resultDto;
        }

        public ResultDto<VentaDto> UpdateVenta(VentaDto ventaDto)
        {
            ResultDto<VentaDto> resultDto = new ResultDto<VentaDto>();
            try
            {
                Venta ventaResult = ventaApplication.GetVenta(ventaDto.Id);
                Venta venta = this.mapper.Map<VentaDto, Venta>(ventaDto, ventaResult);
                int updateVenta = ventaApplication.UpdateVenta(venta);
                if (updateVenta != 0)
                {

                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La actualizacion de la venta se realizo de forma exitosa",
                        Response = ResponseType.OK.GetDescription()
                    };
                }
                else
                {
                    resultDto.ResponseDto = new ResponseDto()
                    {
                        Message = "La actualizacion de la venta arrojó 0 filas afectadas",
                        Response = ResponseType.WARNING.GetDescription()
                    };
                }
            }
            catch (Exception ex)
            {

                resultDto.BusinessDto = null;
                resultDto.ResponseDto = new ResponseDto()
                {
                    Message = "La actualizacion de la venta genero un error",
                    Response = ResponseType.ERROR.GetDescription()
                };
                logger.Error(ex.ToString());
            }

            return resultDto;
        }
    }
}
