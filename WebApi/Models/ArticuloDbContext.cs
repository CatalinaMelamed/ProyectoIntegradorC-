using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ArticuloDbContext: DbContext
    {
        public DbSet<Articulo> Articuloes{ get; set; }
    }
}