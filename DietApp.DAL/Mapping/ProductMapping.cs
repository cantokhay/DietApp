using DietApp.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.Property(p => p.ID);

            builder.Property(p => p.ID)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("ProductID");

            builder.Property(p => p.Name)
                .HasColumnType("nvarchar")
                .HasColumnName("ProductName")
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.Calory)
                .HasColumnType("float")
                .HasColumnName("Calory")
                .IsRequired();

                    

            builder.Property(p => p.PortionGram)
                .HasColumnType("float")
                .HasColumnName("PortionGram");
            //.IsRequired();


            //Navigation
            //Category 1-to-n Product
            
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryID);  

        }
    }
}
