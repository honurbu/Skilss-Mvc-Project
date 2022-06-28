using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Skills_MVC_CodeFirstEntity.Models.siniflar
{
    public class Context : DbContext
    {
        public DbSet<Yetenekler> YETENEKLERS { get; set; }
    }
}