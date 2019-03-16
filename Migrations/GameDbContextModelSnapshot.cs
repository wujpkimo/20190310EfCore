﻿// <auto-generated />
using EfcoreConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfcoreConsoleApp.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("EfcoreConsoleApp.Models.Pokemon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Hp");

                    b.Property<int>("MaxHp");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Pokemons");
                });

            modelBuilder.Entity("EfcoreConsoleApp.Models.PokemonBasicProperty", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<double>("Height");

                    b.Property<int>("PokemonId");

                    b.Property<double>("Weight");

                    b.HasKey("id");

                    b.HasIndex("PokemonId")
                        .IsUnique();

                    b.ToTable("PokemonBasicProperties");
                });

            modelBuilder.Entity("EfcoreConsoleApp.Models.PokemonBasicProperty", b =>
                {
                    b.HasOne("EfcoreConsoleApp.Models.Pokemon", "Pokemon")
                        .WithOne("BasicProperty")
                        .HasForeignKey("EfcoreConsoleApp.Models.PokemonBasicProperty", "PokemonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
