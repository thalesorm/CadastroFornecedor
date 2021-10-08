using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Mapping
{
    public class SupplierRegitration
    {
        public void Configure(EntityTypeBuilder<SupplierRegitration> builder)
        {
            builder.ToTable("SupplierRegitrations");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Name)
                .HasColumnName("Name")
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(prop => prop.Responsible)
                .HasColumnName("Responsible")
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(prop => prop.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(prop => prop.Telephone)
                .HasColumnName("Telephone")
                .HasColumnType("varchar(250)")
                .IsRequired();

            builder.Property(prop => prop.Whatsapp)
                .HasColumnName("Whatsapp")
                .HasColumnType("varchar(250)")
                .IsRequired();


        }




    }
}
