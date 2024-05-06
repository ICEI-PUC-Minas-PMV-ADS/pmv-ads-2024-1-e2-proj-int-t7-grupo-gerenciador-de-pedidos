﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Models;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MesaId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("StatusId");

                    b.ToTable("ItemPedidos");
                });

            modelBuilder.Entity("backend.Models.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("backend.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("MesaId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MesaId");

                    b.HasIndex("StatusId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("backend.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Valor")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("backend.Models.StatusPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StatusPedidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusPedidoId");

                    b.ToTable("StatusPedidos");
                });

            modelBuilder.Entity("backend.Models.ItemPedido", b =>
                {
                    b.HasOne("backend.Models.Mesa", "Mesa")
                        .WithMany()
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Produto", "Produto")
                        .WithMany("ItemPedidos")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.StatusPedido", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mesa");

                    b.Navigation("Produto");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("backend.Models.Pedido", b =>
                {
                    b.HasOne("backend.Models.Mesa", "Mesa")
                        .WithMany("Pedidos")
                        .HasForeignKey("MesaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.StatusPedido", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mesa");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("backend.Models.StatusPedido", b =>
                {
                    b.HasOne("backend.Models.StatusPedido", null)
                        .WithMany("StatusPedidos")
                        .HasForeignKey("StatusPedidoId");
                });

            modelBuilder.Entity("backend.Models.Mesa", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("backend.Models.Produto", b =>
                {
                    b.Navigation("ItemPedidos");
                });

            modelBuilder.Entity("backend.Models.StatusPedido", b =>
                {
                    b.Navigation("StatusPedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
