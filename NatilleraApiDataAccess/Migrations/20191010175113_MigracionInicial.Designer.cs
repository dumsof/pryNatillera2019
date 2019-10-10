﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NatilleraApiDataAccess;

namespace NatilleraApiDataAccess.Migrations
{
    [DbContext(typeof(NatilleraDBContext))]
    [Migration("20191010175113_MigracionInicial")]
    partial class MigracionInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("NatilleraApiDataAccess.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.ActividadesRecaudos", b =>
                {
                    b.Property<int>("ActividadRecaudoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionActividad");

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaRealizaActividad");

                    b.Property<int?>("NatillerasNatilleraId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("SociosSocioId");

                    b.Property<decimal>("ValorInvertido")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorNetoGanancia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorRecaudado")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ActividadRecaudoId");

                    b.HasIndex("NatillerasNatilleraId");

                    b.HasIndex("SociosSocioId");

                    b.ToTable("ActividadesRecaudos");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.CuotasPrestamos", b =>
                {
                    b.Property<int>("CuotaPrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiasMora");

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaEsperaPago");

                    b.Property<DateTime>("FechaLimitePago");

                    b.Property<int?>("PrestamosPrestamoId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<decimal>("ValorCuota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorDiasMora")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorInteres")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorNetoPagoCuota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CuotaPrestamoId");

                    b.HasIndex("PrestamosPrestamoId");

                    b.ToTable("CuotasPrestamos");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.CuotasSocios", b =>
                {
                    b.Property<int>("CuotaSocioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaPagoCuota");

                    b.Property<int?>("NatillerasNatilleraId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("SociosSocioId");

                    b.Property<decimal>("ValorCuota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorMulta")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorTotalCuota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CuotaSocioId");

                    b.HasIndex("NatillerasNatilleraId");

                    b.HasIndex("SociosSocioId");

                    b.ToTable("CuotasSocios");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.NatilleraSocios", b =>
                {
                    b.Property<int>("NatilleraSocioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("NatillerasNatilleraId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("SociosSocioId");

                    b.HasKey("NatilleraSocioId");

                    b.HasIndex("NatillerasNatilleraId");

                    b.HasIndex("SociosSocioId");

                    b.ToTable("NatilleraSocios");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.Natilleras", b =>
                {
                    b.Property<int>("NatilleraId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("DiasGraciaMora");

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasDefaultValueSql("getdate()");

                    b.Property<DateTime>("FechaInicioPagoCuota");

                    b.Property<string>("Nombre");

                    b.Property<int>("NumeroCuotas");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("TipoPago");

                    b.Property<decimal>("ValorCuotaPagar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("ValorMoraDiaFijo");

                    b.Property<decimal>("ValorMoraPagar")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("NatilleraId");

                    b.ToTable("Natilleras");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.Prestamos", b =>
                {
                    b.Property<int>("PrestamoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaDesembolso");

                    b.Property<int>("PorcentajeInteres");

                    b.Property<string>("ResponsablePagoPrestamo")
                        .HasMaxLength(250);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("SociosSocioId");

                    b.Property<decimal>("ValorCuotasNatillaActual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorPrestado")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PrestamoId");

                    b.HasIndex("SociosSocioId");

                    b.ToTable("Prestamos");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.Socios", b =>
                {
                    b.Property<int>("SocioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasMaxLength(250);

                    b.Property<string>("Celular")
                        .HasMaxLength(20);

                    b.Property<string>("CorreoElectronico")
                        .HasMaxLength(150);

                    b.Property<string>("Direccion")
                        .HasMaxLength(250);

                    b.Property<DateTime>("FechaActualizacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("FechaCreacionRow")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Nombres")
                        .HasMaxLength(200);

                    b.Property<string>("NumeroDocumento")
                        .HasMaxLength(20);

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Telefono")
                        .HasMaxLength(20);

                    b.Property<int?>("TiposDocumentosTipoDocumentoId");

                    b.HasKey("SocioId");

                    b.HasIndex("TiposDocumentosTipoDocumentoId");

                    b.ToTable("Socios");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.TiposDocumentos", b =>
                {
                    b.Property<int>("TipoDocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(200);

                    b.HasKey("TipoDocumentoId");

                    b.ToTable("TiposDocumentos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NatilleraApiDataAccess.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NatilleraApiDataAccess.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NatilleraApiDataAccess.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NatilleraApiDataAccess.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.ActividadesRecaudos", b =>
                {
                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Natilleras", "Natilleras")
                        .WithMany()
                        .HasForeignKey("NatillerasNatilleraId");

                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Socios", "Socios")
                        .WithMany()
                        .HasForeignKey("SociosSocioId");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.CuotasPrestamos", b =>
                {
                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Prestamos", "Prestamos")
                        .WithMany("CuotasPrestamos")
                        .HasForeignKey("PrestamosPrestamoId");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.CuotasSocios", b =>
                {
                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Natilleras", "Natilleras")
                        .WithMany("CuotasSocios")
                        .HasForeignKey("NatillerasNatilleraId");

                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Socios", "Socios")
                        .WithMany()
                        .HasForeignKey("SociosSocioId");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.NatilleraSocios", b =>
                {
                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Natilleras", "Natilleras")
                        .WithMany("NatilleraSocios")
                        .HasForeignKey("NatillerasNatilleraId");

                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Socios", "Socios")
                        .WithMany("NatilleraSocios")
                        .HasForeignKey("SociosSocioId");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.Prestamos", b =>
                {
                    b.HasOne("NatilleraApiDataAccessContract.Entidades.Socios", "Socios")
                        .WithMany()
                        .HasForeignKey("SociosSocioId");
                });

            modelBuilder.Entity("NatilleraApiDataAccessContract.Entidades.Socios", b =>
                {
                    b.HasOne("NatilleraApiDataAccessContract.Entidades.TiposDocumentos", "TiposDocumentos")
                        .WithMany()
                        .HasForeignKey("TiposDocumentosTipoDocumentoId");
                });
#pragma warning restore 612, 618
        }
    }
}