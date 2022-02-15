using Microsoft.EntityFrameworkCore;
using MovieEticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieEticket.Data
{
    public class EticketDbContext:DbContext
    {
        public EticketDbContext(DbContextOptions<EticketDbContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorsssId,
                am.MoviesssId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(
                m => m.MoviesssId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actors).WithMany(am => am.Actors_Movies).HasForeignKey(
               m => m.ActorsssId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movies> Moviess { get; set; }
        public DbSet<Actor_Movie> Actors_Moives { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }


    }
}
