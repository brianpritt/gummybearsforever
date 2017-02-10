using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using GummyBearsForever.Models;

namespace gummybearsforever.Migrations
{
    [DbContext(typeof(GummyBearsForeverDbContext))]
    partial class GummyBearsForeverDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GummyBearsForever.Models.Inventory", b =>
                {
                    b.Property<int>("GummyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cost");

                    b.Property<string>("Country");

                    b.Property<string>("GummyName");

                    b.HasKey("GummyId");

                    b.ToTable("GummyBears");
                });
        }
    }
}
