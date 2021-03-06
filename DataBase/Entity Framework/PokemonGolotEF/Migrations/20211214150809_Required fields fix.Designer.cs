// <auto-generated />
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
    [Migration("20211214150809_Required fields fix")]
    partial class Requiredfieldsfix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PokemonGolotEF.Model.Egg", b =>
                {
                    b.Property<double>("km_egg")
                        .HasColumnType("double precision");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("km_egg");

                    b.ToTable("Egg");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Element", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .HasColumnType("text");

                    b.HasKey("name");

                    b.ToTable("Element");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.EvolutionChain", b =>
                {
                    b.Property<int>("pokemon_base")
                        .HasColumnType("integer");

                    b.Property<int>("pokemon_evolved")
                        .HasColumnType("integer");

                    b.Property<int>("candy_needed")
                        .HasColumnType("integer");

                    b.HasKey("pokemon_base", "pokemon_evolved");

                    b.HasIndex("pokemon_evolved");

                    b.ToTable("Evolution_chain");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Gym", b =>
                {
                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("team")
                        .HasColumnType("text");

                    b.HasKey("location");

                    b.HasIndex("team");

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

            modelBuilder.Entity("PokemonGolotEF.Model.LevelupObjectReward", b =>
                {
                    b.Property<short>("level")
                        .HasColumnType("smallint");

                    b.Property<string>("object_name")
                        .HasColumnType("text");

                    b.Property<int>("quantity")
                        .HasColumnType("integer");

                    b.HasKey("level", "object_name");

                    b.HasIndex("object_name");

                    b.ToTable("Levelup_object_rewards");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Movement", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("duration")
                        .HasColumnType("integer");

                    b.Property<string>("element")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("energy")
                        .HasColumnType("double precision");

                    b.Property<int>("power")
                        .HasColumnType("integer");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("name");

                    b.HasIndex("element");

                    b.ToTable("Movement");
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

            modelBuilder.Entity("PokemonGolotEF.Model.PackageOffer", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<bool>("active")
                        .HasColumnType("boolean");

                    b.Property<double>("price")
                        .HasColumnType("double precision");

                    b.HasKey("name");

                    b.ToTable("Package_offer");
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

            modelBuilder.Entity("PokemonGolotEF.Model.PokemonLevel", b =>
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

            modelBuilder.Entity("PokemonGolotEF.Model.PokemonOwned", b =>
                {
                    b.Property<int>("pokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("pokemonId"));

                    b.Property<int>("atack_iv")
                        .HasColumnType("integer");

                    b.Property<int>("defense_iv")
                        .HasColumnType("integer");

                    b.Property<float>("level")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("owner")
                        .IsRequired()
                        .HasColumnType("character varying(20)");

                    b.Property<int>("pokemon")
                        .HasColumnType("integer");

                    b.Property<int>("stamina_iv")
                        .HasColumnType("integer");

                    b.HasKey("pokemonId");

                    b.HasIndex("level");

                    b.HasIndex("owner");

                    b.HasIndex("pokemon");

                    b.ToTable("Pokemon_owned");
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

            modelBuilder.Entity("PokemonGolotEF.Model.Present", b =>
                {
                    b.Property<int>("presentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("presentId"));

                    b.Property<DateTime>("getDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("opened")
                        .HasColumnType("boolean");

                    b.Property<string>("owner")
                        .IsRequired()
                        .HasColumnType("character varying(20)");

                    b.Property<string>("pokeStop")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("receptor")
                        .HasColumnType("character varying(20)");

                    b.Property<DateTime>("sendDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("presentId");

                    b.HasIndex("owner");

                    b.HasIndex("pokeStop");

                    b.HasIndex("receptor");

                    b.ToTable("Present");
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

            modelBuilder.Entity("PokemonGolotEF.Model.RaidParticipant", b =>
                {
                    b.Property<string>("gym")
                        .HasColumnType("text");

                    b.Property<string>("user")
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Raidlocation")
                        .HasColumnType("text");

                    b.HasKey("gym", "user");

                    b.HasIndex("Raidlocation");

                    b.HasIndex("user");

                    b.ToTable("Raid_participants");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Team", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("name");

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

                    b.Property<string>("team")
                        .HasColumnType("text");

                    b.Property<int>("won_battles")
                        .HasColumnType("integer");

                    b.HasKey("user_name");

                    b.HasIndex("level");

                    b.HasIndex("team");

                    b.ToTable("User");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.EvolutionChain", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.Pokemon", "PokemonBase")
                        .WithMany()
                        .HasForeignKey("pokemon_base")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.Pokemon", "PokemonEvolved")
                        .WithMany()
                        .HasForeignKey("pokemon_evolved")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PokemonBase");

                    b.Navigation("PokemonEvolved");
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
                        .HasForeignKey("team");

                    b.Navigation("PokeStop");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.LevelupObjectReward", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.Level", "Level")
                        .WithMany("rewards")
                        .HasForeignKey("level")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.Object", "Object")
                        .WithMany("levels")
                        .HasForeignKey("object_name")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("Object");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Movement", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.Element", "Element")
                        .WithMany()
                        .HasForeignKey("element")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Element");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.PokemonOwned", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.PokemonLevel", "Level")
                        .WithMany("pokemons")
                        .HasForeignKey("level")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.User", "Owner")
                        .WithMany("pokemons")
                        .HasForeignKey("owner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.Pokemon", "Pokemon")
                        .WithMany("Owners")
                        .HasForeignKey("pokemon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Level");

                    b.Navigation("Owner");

                    b.Navigation("Pokemon");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Present", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.User", "Owner")
                        .WithMany("presentsToSend")
                        .HasForeignKey("owner")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.PokeStop", "PokeStop")
                        .WithMany("presents")
                        .HasForeignKey("pokeStop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.User", "Receptor")
                        .WithMany("recivedPresents")
                        .HasForeignKey("receptor");

                    b.Navigation("Owner");

                    b.Navigation("PokeStop");

                    b.Navigation("Receptor");
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

            modelBuilder.Entity("PokemonGolotEF.Model.RaidParticipant", b =>
                {
                    b.HasOne("PokemonGolotEF.Model.Raid", null)
                        .WithMany("Participants")
                        .HasForeignKey("Raidlocation");

                    b.HasOne("PokemonGolotEF.Model.Gym", "Gym")
                        .WithMany()
                        .HasForeignKey("gym")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokemonGolotEF.Model.User", "User")
                        .WithMany("raidsParticipated")
                        .HasForeignKey("user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gym");

                    b.Navigation("User");
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
                        .HasForeignKey("team");

                    b.Navigation("Level");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Gym", b =>
                {
                    b.Navigation("raids");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Level", b =>
                {
                    b.Navigation("rewards");

                    b.Navigation("users");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Object", b =>
                {
                    b.Navigation("levels");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Pokemon", b =>
                {
                    b.Navigation("Owners");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.PokemonLevel", b =>
                {
                    b.Navigation("pokemons");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.PokeStop", b =>
                {
                    b.Navigation("presents");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Raid", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.Team", b =>
                {
                    b.Navigation("Gyms");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("PokemonGolotEF.Model.User", b =>
                {
                    b.Navigation("pokemons");

                    b.Navigation("presentsToSend");

                    b.Navigation("raidsParticipated");

                    b.Navigation("recivedPresents");
                });
#pragma warning restore 612, 618
        }
    }
}
