using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barbu_Madalina_Lab6.Models;

namespace Barbu_Madalina_Lab6.Data
{
    public class Barbu_Madalina_Lab6Context : DbContext
    {
        public Barbu_Madalina_Lab6Context (DbContextOptions<Barbu_Madalina_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Barbu_Madalina_Lab6.Models.Book> Book { get; set; }
    }
}
