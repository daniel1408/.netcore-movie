using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using movie.Models;

namespace movie.Models
{
    public class DataBase : DbContext
    {        
        public DbSet<Filmes> filmes { get; set; }
        public DbSet<User> usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./movie.db");
        }
    }
}