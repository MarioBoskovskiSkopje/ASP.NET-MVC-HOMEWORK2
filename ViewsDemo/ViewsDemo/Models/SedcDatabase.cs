using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ViewsDemo.Models
{
    public class SedcDatabase: DbContext
    {
        public DbSet<Picture> Pictures { get; set; }

        public SedcDatabase()
        {

        }
    }
}