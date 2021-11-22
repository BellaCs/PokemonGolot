﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PokemonGolotEF.Data;

#nullable disable

namespace PokemonGolotEF.Migrations
{
    [DbContext(typeof(PokemonGolotDBContext))]
    [Migration("20211119145832_Raids implemented")]
    partial class Raidsimplemented
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PokemonGolotEF.Model.Gym", b =>
                {
                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("team_name")
                        .HasColumnType("text");

                    b.HasKey("location");

                    b.HasIndex("team_name");

                    b.ToTable("Gym");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Level", b =>
                {
                    b.Property<short>("level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<short>("level"));

                    b.Property<int>("necessary_xp")
                        .HasColumnType("integer");

                    b.HasKey("level");

                    b.ToTable("Level");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Object", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("name");

                    b.ToTable("Object");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Pokemon", b =>
                {
                    b.Property<int>("num_pokedex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("num_pokedex"));

                    b.Property<double>("attack")
                        .HasColumnType("double precision");

                    b.Property<double>("defense")
                        .HasColumnType("double precision");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("female_gender")
                        .HasColumnType("boolean");

                    b.Property<string>("img_back")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("img_front")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("male_gender")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rarity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("stamina")
                        .HasColumnType("double precision");

                    b.HasKey("num_pokedex");

                    b.ToTable("Pokemon");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Pokemon_level", b =>
                {
                    b.Property<float>("pokemon_level")
                        .HasColumnType("real");

                    b.Property<int>("candy_to_upgrade")
                        .HasColumnType("integer");

                    b.Property<double>("pc_multiplier")
                        .HasColumnType("double precision");

                    b.Property<int>("stardust_to_upgrade")
                        .HasColumnType("integer");

                    b.HasKey("pokemon_level");

                    b.ToTable("Pokemon_level");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.PokeStop", b =>
                {
                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("location");

                    b.ToTable("PokeStop");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Raid", b =>
                {
                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<int>("boss")
                        .HasColumnType("integer");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("location");

                    b.HasIndex("boss");

                    b.ToTable("Raid");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Team", b =>
                {
                    b.Property<string>("team_name")
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("team_name");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.User", b =>
                {
                    b.Property<string>("user_name")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("birth_date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("caputred_pokemon")
                        .HasColumnType("integer");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<char>("gender")
                        .HasColumnType("character(1)");

                    b.Property<int>("inventory_capacity")
                        .HasColumnType("integer");

                    b.Property<short>("level")
                        .HasColumnType("smallint");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("pokemon_slots")
                        .HasColumnType("integer");

                    b.Property<int>("remaining_experience")
                        .HasColumnType("integer");

                    b.Property<string>("team_name")
                        .HasColumnType("text");

                    b.Property<int>("won_battles")
                        .HasColumnType("integer");

                    b.HasKey("user_name");

                    b.HasIndex("level");

                    b.HasIndex("team_name");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Gym", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.PokeStop", "PokeStop")
                        .WithMany()
                        .HasForeignKey("location")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.Team", "Team")
                        .WithMany("Gyms")
                        .HasForeignKey("team_name");

                    b.Navigation("PokeStop");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Raid", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.Pokemon", "Pokemon")
                        .WithMany()
                        .HasForeignKey("boss")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.Gym", "Gym")
                        .WithMany("raids")
                        .HasForeignKey("location")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gym");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.User", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.Level", "Level")
                        .WithMany("users")
                        .HasForeignKey("level")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.Team", "Team")
                        .WithMany("Users")
                        .HasForeignKey("team_name");

                    b.Navigation("Level");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Gym", b =>
                {
                    b.Navigation("raids");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Level", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Team", b =>
                {
                    b.Navigation("Gyms");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
