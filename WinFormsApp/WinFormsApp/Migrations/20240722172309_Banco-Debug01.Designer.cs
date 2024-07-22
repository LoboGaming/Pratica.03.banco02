﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp.BancoDeDados;

#nullable disable

namespace WinFormsApp.Migrations
{
    [DbContext(typeof(BancoContext))]
    [Migration("20240722172309_Banco-Debug01")]
    partial class BancoDebug01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("WinFormsApp.Itens.Produto", b =>
                {
                    b.Property<int>("idProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeProduto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idProduto");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("WinFormsApp.Modelos.Compra", b =>
                {
                    b.Property<int>("idCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataCompra")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idCompra");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("WinFormsApp.Modelos.FuncaoFuncionario", b =>
                {
                    b.Property<int>("idFuncaoFuncionario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeFuncaoFuncionario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idFuncaoFuncionario");

                    b.ToTable("FuncaoFuncionarios");
                });

            modelBuilder.Entity("WinFormsApp.Modelos.Funcionario", b =>
                {
                    b.Property<int>("idFuncionario")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idFuncaoFuncionario")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeFuncionario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idFuncionario");

                    b.ToTable("Funcionarios");
                });
#pragma warning restore 612, 618
        }
    }
}
