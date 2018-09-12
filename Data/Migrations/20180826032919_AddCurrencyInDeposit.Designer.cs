﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(OceannicContext))]
    [Migration("20180826032919_AddCurrencyInDeposit")]
    partial class AddCurrencyInDeposit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Bank");
                });

            modelBuilder.Entity("Domain.Models.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Currency");
                });

            modelBuilder.Entity("Domain.Models.Deposit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("BankId");

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Describe");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.Property<int>("UserId");

                    b.Property<double>("Value");

                    b.Property<int>("WalletId");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("UserId");

                    b.HasIndex("WalletId");

                    b.ToTable("Deposit");
                });

            modelBuilder.Entity("Domain.Models.ImgUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataAlteracao");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<bool>("Deletado");

                    b.Property<string>("FileContentBase64");

                    b.Property<long>("FileLenght");

                    b.Property<string>("FileName");

                    b.Property<int>("IdNews");

                    b.Property<string>("MimeType");

                    b.HasKey("Id");

                    b.ToTable("ImgUser");
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Admin");

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cep")
                        .IsRequired();

                    b.Property<string>("Cpf")
                        .IsRequired();

                    b.Property<string>("Describe");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int?>("ImgUserId");

                    b.Property<DateTime>("InputDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Pw")
                        .IsRequired();

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("ImgUserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Domain.Models.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo");

                    b.Property<int>("CurrencyId");

                    b.Property<string>("Describe");

                    b.Property<string>("Guid");

                    b.Property<DateTime>("InputDate");

                    b.Property<DateTime?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("CurrencyId");

                    b.ToTable("Wallet");
                });

            modelBuilder.Entity("Domain.Models.Deposit", b =>
                {
                    b.HasOne("Domain.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Models.Wallet", "Wallet")
                        .WithMany()
                        .HasForeignKey("WalletId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Models.User", b =>
                {
                    b.HasOne("Domain.Models.ImgUser", "ImgUser")
                        .WithMany("User")
                        .HasForeignKey("ImgUserId");
                });

            modelBuilder.Entity("Domain.Models.Wallet", b =>
                {
                    b.HasOne("Domain.Models.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
