using FacturacionApi.Common.Dto;
using FacturacionApi.Common.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Interface.Business
{
    public interface IVentaBusiness
    {
        ResultDto<VentaDto> SaveVenta(VentaDto ventaDto);
        ResultDto<VentaDto> GetVenta(int id);
        ResultDto<VentaDto> GetVenta();
        ResultDto<VentaDto> UpdateVenta(VentaDto ventaDto);
        ResultDto<VentaDto> DeleteVenta(List<int> id);
    }
}
