﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(RopaContext))]
    partial class RopaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Core.Entities.DatosCompra.Insumo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("StockMax")
                        .HasColumnType("int");

                    b.Property<int>("StockMin")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnit")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("insumo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosCompra.InsumoPrenda", b =>
                {
                    b.Property<int>("IdPrendaFk")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdInsumoFk")
                        .HasColumnType("int");

                    b.HasKey("IdPrendaFk");

                    b.HasIndex("IdInsumoFk");

                    b.ToTable("insumoprenda", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosCompra.InsumoProveedor", b =>
                {
                    b.Property<int>("IdProveedorFk")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdInsumoFk")
                        .HasColumnType("int");

                    b.HasKey("IdProveedorFk");

                    b.HasIndex("IdInsumoFk");

                    b.ToTable("insumoproveedor", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosEmpresa.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime");

                    b.Property<int>("IdMuniciFk")
                        .HasColumnType("int");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RazonSocial")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("RepresentanteLegal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdMuniciFk");

                    b.HasIndex("Nit")
                        .IsUnique();

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProducInveFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTallaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdVentaFk")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnit")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdProducInveFk");

                    b.HasIndex("IdTallaFk");

                    b.HasIndex("IdVentaFk");

                    b.ToTable("detalleventa", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.Inventario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CodInv")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendaFk")
                        .HasColumnType("int");

                    b.Property<double>("ValorVtaCop")
                        .HasColumnType("double");

                    b.Property<double>("ValorVtaUsd")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("CodInv")
                        .IsUnique();

                    b.HasIndex("IdPrendaFk");

                    b.ToTable("inventario", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.InventarioTalla", b =>
                {
                    b.Property<int>("IdTallaFk")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("IdInventaFk")
                        .HasColumnType("int");

                    b.HasKey("IdTallaFk");

                    b.HasIndex("IdInventaFk");

                    b.ToTable("inventariotalla", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.Talla", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("Descripcion")
                        .IsUnique();

                    b.ToTable("talla", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.DetalleOrden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducida")
                        .HasColumnType("int");

                    b.Property<int>("CantidadProducir")
                        .HasColumnType("int");

                    b.Property<int>("IdColorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdOrdenFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrendaFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdColorFk");

                    b.HasIndex("IdEstadoFk");

                    b.HasIndex("IdOrdenFk");

                    b.HasIndex("IdPrendaFk");

                    b.ToTable("detalleorden", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.FormaPago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descipcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("formapago", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdEmpleadoFk");

                    b.HasIndex("IdEstadoFk");

                    b.ToTable("orden", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime");

                    b.Property<int>("IdClienteFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdFormaPagoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdClienteFk");

                    b.HasIndex("IdEmpleadoFk");

                    b.HasIndex("IdFormaPagoFk");

                    b.ToTable("venta", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Location.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Location.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDeparFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("IdDeparFk");

                    b.ToTable("municipio", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Location.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("SueldoBase")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("cargo", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdMuniciFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente")
                        .IsUnique();

                    b.HasIndex("IdMuniciFk");

                    b.HasIndex("IdTipoPersFk");

                    b.ToTable("cliente", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime");

                    b.Property<int>("IdCargoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdMuniciFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdCargoFk");

                    b.HasIndex("IdEmpleado")
                        .IsUnique();

                    b.HasIndex("IdMuniciFk");

                    b.ToTable("empleado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdMuniciFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersFk")
                        .HasColumnType("int");

                    b.Property<int>("NitProveedor")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdMuniciFk");

                    b.HasIndex("IdTipoPersFk");

                    b.HasIndex("NitProveedor")
                        .IsUnique();

                    b.ToTable("proveedor", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Persona.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ropa.Colores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("color", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ropa.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdTipoEstaFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoEstaFk");

                    b.ToTable("estado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ropa.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ropa.Prenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdGeneroFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPrenda")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoProFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("ValorUnitCop")
                        .HasColumnType("double");

                    b.Property<double>("ValorUnitUsd")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("IdEstadoFk");

                    b.HasIndex("IdGeneroFk");

                    b.HasIndex("IdPrenda")
                        .IsUnique();

                    b.HasIndex("IdTipoProFk");

                    b.ToTable("prenda", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ropa.TipoEstado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tipoestado", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Ropa.TipoProteccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("tipoproteccion", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosCompra.InsumoPrenda", b =>
                {
                    b.HasOne("Core.Entities.DatosCompra.Insumo", "Insumos")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("IdInsumoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ropa.Prenda", "Prendas")
                        .WithMany("InsumoPrendas")
                        .HasForeignKey("IdPrendaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumos");

                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Core.Entities.DatosCompra.InsumoProveedor", b =>
                {
                    b.HasOne("Core.Entities.DatosCompra.Insumo", "Insumos")
                        .WithMany("InsumoProveedores")
                        .HasForeignKey("IdInsumoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona.Proveedor", "Proveedores")
                        .WithMany("InsumoProveedores")
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Insumos");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Core.Entities.DatosEmpresa.Empresa", b =>
                {
                    b.HasOne("Core.Entities.Location.Municipio", "Municipio")
                        .WithMany("Empresas")
                        .HasForeignKey("IdMuniciFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.DetalleVenta", b =>
                {
                    b.HasOne("Core.Entities.DatosInventario.Inventario", "Inventario")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdProducInveFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.DatosInventario.Talla", "Talla")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdTallaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.DatosVenta.Venta", "Venta")
                        .WithMany("DetalleVentas")
                        .HasForeignKey("IdVentaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventario");

                    b.Navigation("Talla");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.Inventario", b =>
                {
                    b.HasOne("Core.Entities.Ropa.Prenda", "Prenda")
                        .WithMany("Inventarios")
                        .HasForeignKey("IdPrendaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.InventarioTalla", b =>
                {
                    b.HasOne("Core.Entities.DatosInventario.Inventario", "Inventarios")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("IdInventaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.DatosInventario.Talla", "Tallas")
                        .WithMany("InventarioTallas")
                        .HasForeignKey("IdTallaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inventarios");

                    b.Navigation("Tallas");
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.DetalleOrden", b =>
                {
                    b.HasOne("Core.Entities.Ropa.Colores", "Colores")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdColorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ropa.Estado", "Estado")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.DatosVenta.Orden", "Orden")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdOrdenFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ropa.Prenda", "Prenda")
                        .WithMany("DetalleOrdenes")
                        .HasForeignKey("IdPrendaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Colores");

                    b.Navigation("Estado");

                    b.Navigation("Orden");

                    b.Navigation("Prenda");
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.Orden", b =>
                {
                    b.HasOne("Core.Entities.Persona.Cliente", "Cliente")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona.Empleado", "Empleado")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdEmpleadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ropa.Estado", "Estado")
                        .WithMany("Ordenes")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.Venta", b =>
                {
                    b.HasOne("Core.Entities.Persona.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("IdClienteFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona.Empleado", "Empleado")
                        .WithMany("Ventas")
                        .HasForeignKey("IdEmpleadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.DatosVenta.FormaPago", "FormaPago")
                        .WithMany("Ventas")
                        .HasForeignKey("IdFormaPagoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("FormaPago");
                });

            modelBuilder.Entity("Core.Entities.Location.Departamento", b =>
                {
                    b.HasOne("Core.Entities.Location.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Core.Entities.Location.Municipio", b =>
                {
                    b.HasOne("Core.Entities.Location.Departamento", "Departamento")
                        .WithMany("Municipios")
                        .HasForeignKey("IdDeparFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Core.Entities.Persona.Cliente", b =>
                {
                    b.HasOne("Core.Entities.Location.Municipio", "Municipio")
                        .WithMany("Clientes")
                        .HasForeignKey("IdMuniciFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona.TipoPersona", "TipoPersona")
                        .WithMany("Clientes")
                        .HasForeignKey("IdTipoPersFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Core.Entities.Persona.Empleado", b =>
                {
                    b.HasOne("Core.Entities.Persona.Cargo", "Cargo")
                        .WithMany("Empleados")
                        .HasForeignKey("IdCargoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Location.Municipio", "Municipio")
                        .WithMany("Empleados")
                        .HasForeignKey("IdMuniciFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("Municipio");
                });

            modelBuilder.Entity("Core.Entities.Persona.Proveedor", b =>
                {
                    b.HasOne("Core.Entities.Location.Municipio", "Municipio")
                        .WithMany("Proveedores")
                        .HasForeignKey("IdMuniciFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Persona.TipoPersona", "TipoPersona")
                        .WithMany("Proveedores")
                        .HasForeignKey("IdTipoPersFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Municipio");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Core.Entities.Ropa.Estado", b =>
                {
                    b.HasOne("Core.Entities.Ropa.TipoEstado", "TipoEstado")
                        .WithMany("Estados")
                        .HasForeignKey("IdTipoEstaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoEstado");
                });

            modelBuilder.Entity("Core.Entities.Ropa.Prenda", b =>
                {
                    b.HasOne("Core.Entities.Ropa.Estado", "Estado")
                        .WithMany("Prendas")
                        .HasForeignKey("IdEstadoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ropa.Genero", "Genero")
                        .WithMany("Prendas")
                        .HasForeignKey("IdGeneroFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Ropa.TipoProteccion", "TipoProteccion")
                        .WithMany("Prendas")
                        .HasForeignKey("IdTipoProFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");

                    b.Navigation("Genero");

                    b.Navigation("TipoProteccion");
                });

            modelBuilder.Entity("Core.Entities.DatosCompra.Insumo", b =>
                {
                    b.Navigation("InsumoPrendas");

                    b.Navigation("InsumoProveedores");
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.Inventario", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Core.Entities.DatosInventario.Talla", b =>
                {
                    b.Navigation("DetalleVentas");

                    b.Navigation("InventarioTallas");
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.FormaPago", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.Orden", b =>
                {
                    b.Navigation("DetalleOrdenes");
                });

            modelBuilder.Entity("Core.Entities.DatosVenta.Venta", b =>
                {
                    b.Navigation("DetalleVentas");
                });

            modelBuilder.Entity("Core.Entities.Location.Departamento", b =>
                {
                    b.Navigation("Municipios");
                });

            modelBuilder.Entity("Core.Entities.Location.Municipio", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Empleados");

                    b.Navigation("Empresas");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Core.Entities.Location.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Core.Entities.Persona.Cargo", b =>
                {
                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Core.Entities.Persona.Cliente", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Core.Entities.Persona.Empleado", b =>
                {
                    b.Navigation("Ordenes");

                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("Core.Entities.Persona.Proveedor", b =>
                {
                    b.Navigation("InsumoProveedores");
                });

            modelBuilder.Entity("Core.Entities.Persona.TipoPersona", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("Proveedores");
                });

            modelBuilder.Entity("Core.Entities.Ropa.Colores", b =>
                {
                    b.Navigation("DetalleOrdenes");
                });

            modelBuilder.Entity("Core.Entities.Ropa.Estado", b =>
                {
                    b.Navigation("DetalleOrdenes");

                    b.Navigation("Ordenes");

                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Core.Entities.Ropa.Genero", b =>
                {
                    b.Navigation("Prendas");
                });

            modelBuilder.Entity("Core.Entities.Ropa.Prenda", b =>
                {
                    b.Navigation("DetalleOrdenes");

                    b.Navigation("InsumoPrendas");

                    b.Navigation("Inventarios");
                });

            modelBuilder.Entity("Core.Entities.Ropa.TipoEstado", b =>
                {
                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Core.Entities.Ropa.TipoProteccion", b =>
                {
                    b.Navigation("Prendas");
                });
#pragma warning restore 612, 618
        }
    }
}