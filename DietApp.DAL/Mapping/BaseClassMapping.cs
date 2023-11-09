using DietApp.DATA;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietApp.DAL.Mapping
{
    public class BaseClassMapping : IEntityTypeConfiguration<BaseClass>
    {
        public void Configure(EntityTypeBuilder<BaseClass> builder)
        {

        }

    }
}
