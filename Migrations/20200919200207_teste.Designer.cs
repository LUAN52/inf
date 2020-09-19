﻿// <auto-generated />
using System;
using ConsoleApp13.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp13.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200919200207_teste")]
    partial class teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp13.Disciplinas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BlocosId")
                        .HasColumnType("int");

                    b.Property<string>("nomeDisciplina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlocosId");

                    b.ToTable("Displinas");
                });

            modelBuilder.Entity("ConsoleApp13.Models.Blocos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumeroBloco")
                        .HasColumnType("int");

                    b.Property<int?>("TurmasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TurmasId");

                    b.ToTable("Blocos");
                });

            modelBuilder.Entity("ConsoleApp13.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NomeCurso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("ConsoleApp13.Models.Turmas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CursoId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroTurma")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Turmas");
                });

            modelBuilder.Entity("ConsoleApp13.Disciplinas", b =>
                {
                    b.HasOne("ConsoleApp13.Models.Blocos", null)
                        .WithMany("Disciplinas")
                        .HasForeignKey("BlocosId");
                });

            modelBuilder.Entity("ConsoleApp13.Models.Blocos", b =>
                {
                    b.HasOne("ConsoleApp13.Models.Turmas", null)
                        .WithMany("Blocos")
                        .HasForeignKey("TurmasId");
                });

            modelBuilder.Entity("ConsoleApp13.Models.Turmas", b =>
                {
                    b.HasOne("ConsoleApp13.Models.Curso", null)
                        .WithMany("Turmas")
                        .HasForeignKey("CursoId");
                });
#pragma warning restore 612, 618
        }
    }
}
