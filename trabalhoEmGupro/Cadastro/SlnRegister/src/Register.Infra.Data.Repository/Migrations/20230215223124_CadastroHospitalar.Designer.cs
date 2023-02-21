﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Register.Infra.Data.Repository.Context;

#nullable disable

namespace Register.Infra.Data.Repository.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    [Migration("20230215223124_CadastroHospitalar")]
    partial class CadastroHospitalar
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Register.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Address");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "Blumenau",
                            District = "SC",
                            Number = "123",
                            PersonId = 1,
                            PostalCode = "89012-412",
                            Street = "Rua Curitiba"
                        },
                        new
                        {
                            Id = 2,
                            City = "Blumenau",
                            District = "SC",
                            Number = "453",
                            PersonId = 2,
                            PostalCode = "89051-260",
                            Street = "Rua Pedro Francisco Cordeiro"
                        },
                        new
                        {
                            Id = 3,
                            City = "Blumenau",
                            District = "SC",
                            Number = "1963",
                            PersonId = 3,
                            PostalCode = "89051-170",
                            Street = "Rua Caiena"
                        },
                        new
                        {
                            Id = 4,
                            City = "Blumenau",
                            District = "SC",
                            Number = "2587",
                            PersonId = 4,
                            PostalCode = "89046-636",
                            Street = "Rua Áustria"
                        },
                        new
                        {
                            Id = 5,
                            City = "Blumenau",
                            District = "SC",
                            Number = "8746",
                            PersonId = 5,
                            PostalCode = "89027-351",
                            Street = "Rua Bruno Hort"
                        },
                        new
                        {
                            Id = 6,
                            City = "Blumenau",
                            District = "SC",
                            Number = "7895",
                            PersonId = 6,
                            PostalCode = "89022-275",
                            Street = "Rua Turvo"
                        },
                        new
                        {
                            Id = 7,
                            City = "Blumenau",
                            District = "SC",
                            Number = "753",
                            PersonId = 7,
                            PostalCode = "89095-510",
                            Street = "Rua Otto Manzke"
                        },
                        new
                        {
                            Id = 8,
                            City = "Blumenau",
                            District = "SC",
                            Number = "951",
                            PersonId = 8,
                            PostalCode = "89057-496",
                            Street = "Rua Augusto Setter"
                        },
                        new
                        {
                            Id = 9,
                            City = "Blumenau",
                            District = "SC",
                            Number = "852",
                            PersonId = 9,
                            PostalCode = "89095-525",
                            Street = "Rua Três Primos"
                        });
                });

            modelBuilder.Entity("Register.Domain.Entities.Condition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conditions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Critical"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Serious"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fair"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Good"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Undetermined"
                        });
                });

            modelBuilder.Entity("Register.Domain.Entities.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.HasIndex("SpecialtyId");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CNPJ = "12.234.567/0001-89",
                            CRM = "CRM/SP 123456",
                            PersonId = 4,
                            SpecialtyId = 4
                        },
                        new
                        {
                            Id = 2,
                            CNPJ = "56.741.963/0001-42",
                            CRM = "CRM/SC 456983",
                            PersonId = 5,
                            SpecialtyId = 1
                        },
                        new
                        {
                            Id = 3,
                            CNPJ = "89.466.123/0001-26",
                            CRM = "CRM/RS 123147",
                            PersonId = 6,
                            SpecialtyId = 2
                        });
                });

            modelBuilder.Entity("Register.Domain.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConditionId")
                        .HasColumnType("int");

                    b.Property<int?>("MRNumber")
                        .HasColumnType("int");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConditionId");

                    b.HasIndex("PersonId");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConditionId = 3,
                            MRNumber = 1,
                            PersonId = 1
                        },
                        new
                        {
                            Id = 2,
                            ConditionId = 3,
                            MRNumber = 2,
                            PersonId = 2
                        },
                        new
                        {
                            Id = 3,
                            ConditionId = 1,
                            MRNumber = 3,
                            PersonId = 3
                        });
                });

            modelBuilder.Entity("Register.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "123.456.789-12",
                            Gender = 2,
                            Name = "Maria Clara de Souza"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "789.456.123-78",
                            Gender = 1,
                            Name = "Paulo Moreira"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "753.159.456-58",
                            Gender = 2,
                            Name = "Rafaella Rodrigues da Silva"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "951.357.321-56",
                            Gender = 1,
                            Name = "João de Oliveira"
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "741.852.963-37",
                            Gender = 2,
                            Name = "Clara Maria Moretti"
                        },
                        new
                        {
                            Id = 6,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "963.852.741-15",
                            Gender = 1,
                            Name = "Ricardo Alves de Souza"
                        },
                        new
                        {
                            Id = 7,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "248.862.176-49",
                            Gender = 2,
                            Name = "Helena Muller"
                        },
                        new
                        {
                            Id = 8,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "154.268.729-16",
                            Gender = 1,
                            Name = "Gabriel Bugmann Vanzuita"
                        },
                        new
                        {
                            Id = 9,
                            BirthDate = new DateTime(2000, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CPF = "217.369.252-98",
                            Gender = 2,
                            Name = "Laura Elena Fisher"
                        });
                });

            modelBuilder.Entity("Register.Domain.Entities.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Specialties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pediatric"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cardiology"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Dermatology"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Gastroenterology"
                        });
                });

            modelBuilder.Entity("Register.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Register.Domain.Entities.Address", b =>
                {
                    b.HasOne("Register.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Register.Domain.Entities.Doctor", b =>
                {
                    b.HasOne("Register.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Register.Domain.Entities.Specialty", "Specialty")
                        .WithMany("DoctorList")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Specialty");
                });

            modelBuilder.Entity("Register.Domain.Entities.Patient", b =>
                {
                    b.HasOne("Register.Domain.Entities.Condition", "Condition")
                        .WithMany("PatientList")
                        .HasForeignKey("ConditionId");

                    b.HasOne("Register.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Condition");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Register.Domain.Entities.User", b =>
                {
                    b.HasOne("Register.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Register.Domain.Entities.Condition", b =>
                {
                    b.Navigation("PatientList");
                });

            modelBuilder.Entity("Register.Domain.Entities.Specialty", b =>
                {
                    b.Navigation("DoctorList");
                });
#pragma warning restore 612, 618
        }
    }
}
