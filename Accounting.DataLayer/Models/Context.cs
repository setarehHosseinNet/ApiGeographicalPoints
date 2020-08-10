using Accounting.DataLayer.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.DataLayer.Models
{
    public class Context
    {
        public class ContextDb : DbContext
        {
            public ContextDb() : base()

            {
            }

            public DbSet<Persen> Persen { get; set; }
            public DbSet<DbGeographicalPoints> DbGeographicalPoints { get; set; }
            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
            }
        }
    }
}

namespace System.Configuration
{
    class ApplicationSettingsBase
    {
        protected static Settings Synchronized(Settings settings)
        {
            throw new NotImplementedException();
        }
    }
}