using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DunwoodCrossing.Classes;

namespace DunwoodCrossing.Migrations
{
    [DbContext(typeof(KarachtersContext))]
    partial class KarachtersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DunwoodCrossing.Classes.Karachter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Background");

                    b.Property<string>("Charisma");

                    b.Property<string>("Constitution");

                    b.Property<string>("Dexterity");

                    b.Property<string>("FileName");

                    b.Property<string>("Hitpoints");

                    b.Property<string>("Intelligence");

                    b.Property<string>("Name");

                    b.Property<string>("Quote");

                    b.Property<string>("SquareFileName");

                    b.Property<string>("Strength");

                    b.Property<string>("Wisdom");

                    b.HasKey("Id");
                });
        }
    }
}
