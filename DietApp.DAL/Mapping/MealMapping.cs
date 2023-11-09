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
    public class MealMapping : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.ToTable("Meal");

            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("MealID");

            builder.Property(a => a.Name)
                .HasColumnType("nvarchar")
                .HasColumnName("MealName")
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
