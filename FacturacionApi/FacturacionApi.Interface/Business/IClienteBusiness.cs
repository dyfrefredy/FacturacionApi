using FacturacionApi.Common.Dto;
using FacturacionApi.Common.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacturacionApi.Interface.Business
{
    public interface IClienteBusiness
    {
        ResultDto<ClienteDto> GetClienteByName(string name);
    }
}
