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
    internal class AppUserMapping : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {

            builder.ToTable("AppUser");

            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                .UseIdentityColumn()
                .HasColumnType("integer")
                .HasColumnName("AppUserID");

            builder.Property(a => a.Name)
                .HasColumnType("nvarchar")
                .HasColumnName("FirstName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(a => a.Lastname)
                .HasColumnType("nvarchar")
                .HasColumnName("LastName")
                .HasMaxLength(50)
                .IsRequired();


            builder.Property(a => a.Password)
                .HasColumnType("nvarchar")
                .HasColumnName("Password")
                .HasMaxLength(60)
                .IsRequired();


            builder.Property(a => a.Gender)
                .HasColumnType("nvarchar")
                .HasColumnName("Gender")
                .HasMaxLength(5);
            //.IsRequired();

            builder.Property(a => a.BirthDate)
                .HasColumnType("DateTime")
                .HasColumnName("BirthDate");
            //.IsRequired();

            builder.Property(a => a.Height)
                .HasColumnType("float")
                .HasColumnName("Height");
            //.IsRequired();

            builder.Property(a => a.TargetWeight)
                .HasColumnType("float")
                .HasColumnName("TargetWeight");
                //.IsRequired();


            //Navigation

      
        }
    }
}
