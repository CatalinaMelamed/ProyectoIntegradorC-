using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ClienteDbContext:DbContext
    {        
        public DbSet<Cliente> Clientes { get; set; }//declarar las propiedades de DBSet de nuestro modelo para acceder a las colecciones

        
    }
}