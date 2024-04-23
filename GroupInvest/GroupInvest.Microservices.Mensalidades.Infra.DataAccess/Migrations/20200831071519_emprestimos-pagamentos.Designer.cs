﻿// <auto-generated />
using System;
using GroupInvest.Microservices.Mensalidades.Infra.DataAccess.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroupInvest.Microservices.Mensalidades.Infra.DataAccess.Migrations
{
    [DbContext(typeof(MicroserviceMensalidadesDbContext))]
    [Migration("20200831071519_emprestimos-pagamentos")]
    partial class emprestimospagamentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Adesao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("NumeroCotas")
                        .HasColumnType("int");

                    b.Property<int?>("ParticipanteId")
                        .HasColumnType("int");

                    b.Property<int?>("PeriodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParticipanteId");

                    b.HasIndex("PeriodoId");

                    b.ToTable("Adesoes");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdesaoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataProximoVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Quitado")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("AdesaoId");

                    b.ToTable("Emprestimos");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.ItemPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EmprestimoId")
                        .HasColumnType("int");

                    b.Property<int?>("MensalidadeId")
                        .HasColumnType("int");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("EmprestimoId");

                    b.HasIndex("MensalidadeId");

                    b.HasIndex("PagamentoId");

                    b.ToTable("ItensPagamento");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Mensalidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdesaoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataReferencia")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataVencimento")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorDevido")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("AdesaoId");

                    b.ToTable("Mensalidades");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ValorTotalPagamento")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.PagamentoParcialEmprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("EmprestimoId")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorPagamento")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("EmprestimoId");

                    b.ToTable("PagamentosEmprestimos");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Participante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Participantes");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Periodo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AnoReferencia")
                        .HasColumnType("int");

                    b.Property<string>("Ativo")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("DataInicioPeriodo")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("DataTerminoPeriodo")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Periodos");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Adesao", b =>
                {
                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Participante", "Participante")
                        .WithMany()
                        .HasForeignKey("ParticipanteId");

                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Periodo", "Periodo")
                        .WithMany()
                        .HasForeignKey("PeriodoId");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Emprestimo", b =>
                {
                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Adesao", "Adesao")
                        .WithMany()
                        .HasForeignKey("AdesaoId");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.ItemPagamento", b =>
                {
                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Emprestimo", "Emprestimo")
                        .WithMany()
                        .HasForeignKey("EmprestimoId");

                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Mensalidade", "Mensalidade")
                        .WithMany()
                        .HasForeignKey("MensalidadeId");

                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Pagamento", "Pagamento")
                        .WithMany("ItensPagamento")
                        .HasForeignKey("PagamentoId");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Mensalidade", b =>
                {
                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Adesao", "Adesao")
                        .WithMany()
                        .HasForeignKey("AdesaoId");
                });

            modelBuilder.Entity("GroupInvest.Microservices.Mensalidades.Domain.Entidades.PagamentoParcialEmprestimo", b =>
                {
                    b.HasOne("GroupInvest.Microservices.Mensalidades.Domain.Entidades.Emprestimo", "Emprestimo")
                        .WithMany("PagamentosParciais")
                        .HasForeignKey("EmprestimoId");
                });
#pragma warning restore 612, 618
        }
    }
}
