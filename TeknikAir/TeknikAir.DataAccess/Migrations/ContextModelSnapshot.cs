// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeknikAir.DataAccess.Concrete;

#nullable disable

namespace TeknikAir.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TeknikAir.Entity.Entity.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"), 1L, 1);

                    b.Property<string>("AboutDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("TeknikAir.Entity.Entity.Partner", b =>
                {
                    b.Property<int>("PartnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PartnerId"), 1L, 1);

                    b.Property<string>("PartnerImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartnerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartnerId");

                    b.ToTable("Partners");
                });

            modelBuilder.Entity("TeknikAir.Entity.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("TeknikAir.Entity.Entity.Reference", b =>
                {
                    b.Property<int>("ReferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReferenceId"), 1L, 1);

                    b.Property<DateTime>("ReferenceDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferenceName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReferenceId");

                    b.ToTable("References");
                });
#pragma warning restore 612, 618
        }
    }
}
