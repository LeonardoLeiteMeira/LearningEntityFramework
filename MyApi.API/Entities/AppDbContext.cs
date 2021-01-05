using System;
using Microsoft.EntityFrameworkCore;

namespace MyApi.API.Entities
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Carro> Carros { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    }
}