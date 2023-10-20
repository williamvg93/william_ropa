using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using ApiRopa.Dtos.Get.DatosCompra;
using ApiRopa.Dtos.Get.DatosEmpresa;
using ApiRopa.Dtos.Get.DatosInventario;
using ApiRopa.Dtos.Get.DatosVenta;
using ApiRopa.Dtos.Get.Location;
using ApiRopa.Dtos.Get.Persona;
using ApiRopa.Dtos.Get.Ropa;
using ApiRopa.Dtos.Post.DatosCompra;
using ApiRopa.Dtos.Post.DatosEmpresa;
using ApiRopa.Dtos.Post.DatosInventario;
using ApiRopa.Dtos.Post.DatosVenta;
using ApiRopa.Dtos.Post.Location;
using ApiRopa.Dtos.Post.Persona;
using ApiRopa.Dtos.Post.Ropa;
using AutoMapper;
using Core.Entities.DatosCompra;
using Core.Entities.DatosEmpresa;
using Core.Entities.DatosInventario;
using Core.Entities.DatosVenta;
using Core.Entities.Location;
using Core.Entities.Persona;
using Core.Entities.Ropa;

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

        CreateMap<FormaPago, FormaPagoDto>()
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

        CreateMap<Cargo, CargoDto>()
        .ReverseMap();

        CreateMap<Cliente, ClienteDto>()
        .ReverseMap();
        CreateMap<Cliente, ClientePDto>()
        .ReverseMap();

        CreateMap<Empleado, EmpleadoDto>()
        .ReverseMap();
        CreateMap<Empleado, EmpleadoPDto>()
        .ReverseMap();

        CreateMap<Proveedor, ProveedorDto>()
        .ReverseMap();
        CreateMap<Proveedor, ProveedorPDto>()
        .ReverseMap();

        CreateMap<TipoPersona, TipoPersonaDto>()
        .ReverseMap();

        CreateMap<Colores, ColoresDto>()
        .ReverseMap();

        CreateMap<Estado, EstadoDto>()
        .ReverseMap();
        CreateMap<Estado, EstadoPDto>()
        .ReverseMap();

        CreateMap<Genero, GeneroDto>()
        .ReverseMap();

        CreateMap<Prenda, PrendaDto>()
        .ReverseMap();
        CreateMap<Prenda, PrendaPDto>()
        .ReverseMap();

        CreateMap<TipoEstado, TipoEstadoDto>()
        .ReverseMap();

        CreateMap<TipoProteccion, TipoProteccionDto>()
        .ReverseMap();
    }
}
