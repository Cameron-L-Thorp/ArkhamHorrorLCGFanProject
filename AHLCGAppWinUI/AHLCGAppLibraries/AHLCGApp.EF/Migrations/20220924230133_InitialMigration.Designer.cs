// <auto-generated />
using System;
using AHLCGApp.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AHLCGApp.EF.Migrations
{
    [DbContext(typeof(AHLCGDBContext))]
    [Migration("20220924230133_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AHLCGApp.Domain.Models.Ability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AbilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AssetId")
                        .HasColumnType("int");

                    b.Property<int?>("InvestigatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("InvestigatorId");

                    b.ToTable("Ability");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Asset", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AgilityVal")
                        .HasColumnType("int");

                    b.Property<int>("CampaignId")
                        .HasColumnType("int");

                    b.Property<int>("ClassType")
                        .HasColumnType("int");

                    b.Property<int>("CombatVal")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<int>("IntVal")
                        .HasColumnType("int");

                    b.Property<bool>("IsMultiClass")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sanity")
                        .HasColumnType("int");

                    b.Property<string>("Slot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WillVal")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Investigator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Agility")
                        .HasColumnType("int");

                    b.Property<int>("ClassType")
                        .HasColumnType("int");

                    b.Property<int>("Combat")
                        .HasColumnType("int");

                    b.Property<int>("DeckSize")
                        .HasColumnType("int");

                    b.Property<string>("ElderSignAbility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlavorText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Intellect")
                        .HasColumnType("int");

                    b.Property<int>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<int>("MaxSanity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SecondaryClassType")
                        .HasColumnType("int");

                    b.Property<int>("Willpower")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Investigators");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Trait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AssetId")
                        .HasColumnType("int");

                    b.Property<int?>("InvestigatorId")
                        .HasColumnType("int");

                    b.Property<string>("TraitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("InvestigatorId");

                    b.ToTable("Trait");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Ability", b =>
                {
                    b.HasOne("AHLCGApp.Domain.Models.Asset", null)
                        .WithMany("Abilities")
                        .HasForeignKey("AssetId");

                    b.HasOne("AHLCGApp.Domain.Models.Investigator", null)
                        .WithMany("Abilities")
                        .HasForeignKey("InvestigatorId");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Trait", b =>
                {
                    b.HasOne("AHLCGApp.Domain.Models.Asset", null)
                        .WithMany("Traits")
                        .HasForeignKey("AssetId");

                    b.HasOne("AHLCGApp.Domain.Models.Investigator", null)
                        .WithMany("Traits")
                        .HasForeignKey("InvestigatorId");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Asset", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("Traits");
                });

            modelBuilder.Entity("AHLCGApp.Domain.Models.Investigator", b =>
                {
                    b.Navigation("Abilities");

                    b.Navigation("Traits");
                });
#pragma warning restore 612, 618
        }
    }
}
