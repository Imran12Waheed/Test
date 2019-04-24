using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HOS_ERP.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext() : base("ConString")
        {

        }
        public DbSet<DEF_MENUS> Menu { get; set; }
    }
}