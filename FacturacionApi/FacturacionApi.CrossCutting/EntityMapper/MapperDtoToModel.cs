using AutoMapper;
using FacturacionApi.Common.Dto;
using FacturacionApi.Model.Models;
using System;

namespace FacturacionApi.CrossCutting.EntityMapper
{
    public class MapperDtoToModel : Profile
    {
        public MapperDtoToModel()
        {
            CreateMap<VentaDto, Venta>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.ClienteId, y => y.MapFrom(z => z.ClienteId))
                .ForMember(x => x.Fecha, y => y.MapFrom(z => z.Fecha))
                .ForMember(x => x.Total, y => y.MapFrom(z => z.Total));

            CreateMap<ClienteDto, Cliente>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.NumeroDocumento, y => y.MapFrom(z => z.NumeroDocumento))
                .ForMember(x => x.Nombre, y => y.MapFrom(z => z.Nombre))
                .ForMember(x => x.Apellido, y => y.MapFrom(z => z.Apellido))
                .ForMember(x => x.Edad, y => y.MapFrom(z => z.Edad));

            CreateMap<ProductoDto, Producto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.Descripcion, y => y.MapFrom(z => z.Descripcion))
                .ForMember(x => x.Precio, y => y.MapFrom(z => z.Precio));

            CreateMap<VentaProductoDto, VentaProducto>()
                .ForMember(x => x.Id, y => y.MapFrom(z => z.Id))
                .ForMember(x => x.VentaId, y => y.MapFrom(z => z.VentaId))
                .ForMember(x => x.ProductoId, y => y.MapFrom(z => z.ProductoId))
                .ForMember(x => x.Cantidad, y => y.MapFrom(z => z.Cantidad))
                .ForMember(x => x.ValorUnitario, y => y.MapFrom(z => z.ValorUnitario))
                .ForMember(x => x.ValorTotal, y => y.MapFrom(z => z.ValorTotal));
        }
    }
}
