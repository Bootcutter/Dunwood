using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using DunwoodCrossing.Classes;

namespace DunwoodCrossing.Migrations
{
    [DbContext(typeof(KarachtersContext))]
    [Migration("20160314204641_addDIary")]
    partial class addDIary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Description");

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
