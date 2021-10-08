using Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Migration
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Book", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("Name");

                b.Property<string>("Responsible")
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("Responsible");

                b.Property<string>("Email")
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("Email");

                b.Property<string>("Telephone")
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("Telephone");

                b.Property<string>("Whatsapp")
                    .IsRequired()
                    .HasColumnType("varchar(250)")
                    .HasColumnName("Whatsapp");

                b.HasKey("Id");

                b.ToTable("SupplierRegistration");
            });
#pragma warning restore 612, 618
        }
    }
}
