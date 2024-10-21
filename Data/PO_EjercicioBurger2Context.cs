using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PO_EjercicioBurger2.Models;

namespace PO_EjercicioBurger2.Data
{
    public class PO_EjercicioBurger2Context : DbContext
    {
        public PO_EjercicioBurger2Context (DbContextOptions<PO_EjercicioBurger2Context> options)
            : base(options)
        {
        }

        public DbSet<PO_EjercicioBurger2.Models.Burger> Burger { get; set; } = default!;
        public DbSet<PO_EjercicioBurger2.Models.Promo> Promo { get; set; } = default!;
    }
}
