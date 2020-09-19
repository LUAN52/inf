using ConsoleApp13.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13.Data
{
    public class Context : DbContext
    {
       public Context()
        {
        }

        public Context(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Blocos> Blocos { get; set; }

        public DbSet<Turmas> Turmas { get; set;}

        public DbSet<Disciplinas> Displinas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=inf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Disciplinas>().HasKey(p => p.Id);
            modelBuilder.Entity<Curso>().HasKey(p => p.Id);
            modelBuilder.Entity<Turmas>().HasKey(p => p.Id);
            modelBuilder.Entity<Blocos>().HasKey(p => p.Id);

            modelBuilder.Entity<Curso>().HasMany(p => p.Turmas);
            modelBuilder.Entity<Turmas>().HasMany(p => p.Blocos);
            modelBuilder.Entity<Blocos>().HasMany(p => p.Disciplinas);


        }
    }
}
