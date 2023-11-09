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
    internal class ActivityMapping : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity");

            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("ActivityID");

            builder.Property(a => a.AddedDate)    
                .HasColumnType("DateTime")
                .HasColumnName("CreatedDate")
                .IsRequired();

            builder.Property(a => a.Steps)
                .HasColumnType("integer")
                .HasColumnName("Steps");

            builder.Property(a => a.AvgCalories)
                .HasColumnType("float")
                .HasColumnName("AvgCalories");

        

              




        }
    }
}
