using Microsoft.EntityFrameworkCore;
using Proy1.Shared.Entity;
using System.Collections.Generic;
using System;

namespace Proy1.Server
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Movie> Movies{get;set;}
        public DbSet<Actor> Actor{get;set;}
        public DbSet<Category> Category{get;set;}
        public DbSet<CategoryMovie> CategoryMovie{get;set;}
        public DbSet<ActorMovie> ActorMovie{get;set;}

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base (options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CategoryMovie>().HasKey(x => new(x.CategoryId, x.MovieId));
            modelBuilder.Entity<ActorMovie>().HasKey(x => new(x.ActorId, x.MovieId));
            base.OnModelCreating(modelBuilder);
        }
    }
}