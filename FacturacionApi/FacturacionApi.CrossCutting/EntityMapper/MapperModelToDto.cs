using AutoMapper;
using FacturacionApi.Common.Dto;
using FacturacionApi.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionApi.CrossCutting.EntityMapper
{
    public class MapperModelToDto : Profile
    {
        public MapperModelToDto()
        {
            CreateMap<Venta, VentaDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.ClienteId, y => y.MapFrom(z => z.ClienteId))
                .ForMember(x => x.Fecha, y => y.MapFrom(z => z.Fecha))
                .ForMember(x => x.Total, y => y.MapFrom(z => z.Total));

            CreateMap<Cliente, ClienteDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.NumeroDocumento, y => y.MapFrom(z => z.NumeroDocumento))
                .ForMember(x => x.Nombre, y => y.MapFrom(z => z.Nombre))
                .ForMember(x => x.Apellido, y => y.MapFrom(z => z.Apellido))
                .ForMember(x => x.Edad, y => y.MapFrom(z => z.Edad));

            CreateMap<Producto, ProductoDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.Descripcion))
                .ForMember(x => x.Precio, y => y.MapFrom(z => z.Precio));

            CreateMap<VentaProducto, VentaProductoDto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.VentaId, y => y.MapFrom(z => z.VentaId))
                .ForMember(x => x.ProductoId, y => y.MapFrom(z => z.ProductoId))
                .ForMember(x => x.Cantidad, y => y.MapFrom(z => z.Cantidad))
                .ForMember(x => x.ValorUnitario, y => y.MapFrom(z => z.ValorUnitario))
                .ForMember(x => x.ValorTotal, y => y.MapFrom(z => z.ValorTotal));
        }
    }
}
