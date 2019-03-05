using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestOfCore.Models
{
    public class CoffeDbContenxt : DbContext
    {
        public CoffeDbContenxt(DbContextOptions<CoffeDbContenxt> options) : base(options)
        {

        }

        public DbSet<Coffe> Coffes {get; set;}
    }
}
