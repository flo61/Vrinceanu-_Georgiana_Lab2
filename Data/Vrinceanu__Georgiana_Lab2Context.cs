using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vrinceanu__Georgiana_Lab2.Models;

namespace Vrinceanu__Georgiana_Lab2.Data
{
    public class Vrinceanu__Georgiana_Lab2Context : DbContext
    {
        public Vrinceanu__Georgiana_Lab2Context (DbContextOptions<Vrinceanu__Georgiana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vrinceanu__Georgiana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Vrinceanu__Georgiana_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
