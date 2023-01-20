using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FilmesAssistidos.Models;

namespace FilmesAssistidos.Data
{
    public class FilmesDbContext : DbContext
    {
        public FilmesDbContext(DbContextOptions<FilmesDbContext> options) : base(options)
        { 
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}