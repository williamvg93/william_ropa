using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiRopa.Dtos.Get.DatosCompra;
using ApiRopa.Dtos.Get.DatosEmpresa;
using ApiRopa.Dtos.Get.DatosInventario;
using ApiRopa.Dtos.Get.DatosVenta;
using ApiRopa.Dtos.Get.Location;
using ApiRopa.Dtos.Post.DatosCompra;
using ApiRopa.Dtos.Post.DatosEmpresa;
using ApiRopa.Dtos.Post.DatosInventario;
using ApiRopa.Dtos.Post.DatosVenta;
using ApiRopa.Dtos.Post.Location;
using AutoMapper;
using Core.Interfaces.DatosCompra;
using Core.Interfaces.DatosEmpresa;
using Core.Interfaces.DatosInventario;
using Core.Interfaces.DatosVenta;
using Core.Interfaces.Location;

namespace ApiRopa.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Insumo, InsumoDto>()
        .ReverseMap();

        CreateMap<InsumoPrenda, InsumoPrendaDto>()
        .ReverseMap();
        CreateMap<InsumoPrenda, InsumoPrendaPDto>()
        .ReverseMap();

        CreateMap<InsumoProveedor, InsumoProveedorDto>()
        .ReverseMap();
        CreateMap<InsumoProveedor, InsumoProveedorPDto>()
        .ReverseMap();

        CreateMap<Empresa, EmpresaDto>()
        .ReverseMap();
        CreateMap<Empresa, EmpresaPDto>()
        .ReverseMap();

        CreateMap<DetalleVenta, DetalleVentaDto>()
        .ReverseMap();
        CreateMap<DetalleVenta, DetalleVentaPDto>()
        .ReverseMap();

        CreateMap<Inventario, InventarioDto>()
        .ReverseMap();
        CreateMap<Inventario, InventarioPDto>()
        .ReverseMap();

        CreateMap<InventarioTalla, InventarioTallaDto>()
        .ReverseMap();
        CreateMap<InventarioTalla, InventarioTallaPDto>()
        .ReverseMap();

        CreateMap<Talla, TallaDto>()
        .ReverseMap();

        CreateMap<DetalleOrden, DetalleOrdenDto>()
        .ReverseMap();
        CreateMap<DetalleOrden, DetalleOrdenPDto>()
        .ReverseMap();

        CreateMap<Orden, OrdenDto>()
        .ReverseMap();
        CreateMap<Orden, OrdenPDto>()
        .ReverseMap();

        CreateMap<Venta, VentaDto>()
        .ReverseMap();
        CreateMap<Venta, VentaPDto>()
        .ReverseMap();

        CreateMap<Pais, PaisDto>()
        .ReverseMap();

        CreateMap<Departamento, DepartamentoDto>()
        .ReverseMap();
        CreateMap<Departamento, DepartamentoPDto>()
        .ReverseMap();

        CreateMap<Municipio, MunicipioDto>()
        .ReverseMap();
        CreateMap<Municipio, MunicipioPDto>()
        .ReverseMap();


    }
}
