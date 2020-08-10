using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.DataLayer2.Models.Configurations
{
    class DbGeographicalPointsConfigurations : IEntityTypeConfiguration<DbGeographicalPoints>
    {

        public void Configure(EntityTypeBuilder<DbGeographicalPoints> builder)
        {
            
            builder.HasKey(s => s.ID);
            
              
        }

    }
}
