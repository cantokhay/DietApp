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
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("CategoryID");

            builder.Property(a => a.Name)
                .HasColumnType("nvarchar")
                .HasColumnName("CategoryName")
                .HasMaxLength(50)
                .IsRequired();


            builder.HasMany(c=>c.Products)
                .WithOne(p=>p.Category)
                .HasForeignKey(p=>p.CategoryID);
                

        }
    }
}

