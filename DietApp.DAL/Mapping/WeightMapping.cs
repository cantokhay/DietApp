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
    public class WeightMapping : IEntityTypeConfiguration<Weight>
    {
        public void Configure(EntityTypeBuilder<Weight> builder)
        {
            builder.ToTable("Weight");

            builder.HasKey(a => a.UpdatedWeight);

            builder.Property(a => a.UpdatedWeight)
                .HasColumnType("float")
                .HasColumnName("UpdatedWeight")
                .IsRequired();

           builder.Property(a => a.CreatedDate)
                .HasColumnType("DateTime")
                .HasColumnName("CreatedDate")
                .IsRequired();

        }
    }
}
