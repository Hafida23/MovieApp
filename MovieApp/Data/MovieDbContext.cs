using Microsoft.EntityFrameworkCore;
using MovieApp.Models;
using System;

namespace MovieApp.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions options)
            : base(options)
        {

        }   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                new Movie { Id=1, Title="Winter sleep",Length=3,Genre="Drama",MainActor="Haluk Bilginer",DateRelease=new DateTime(2011,11,21)},
                new Movie { Id = 2, Title = "A Bout De Soufle", Length = 2, Genre = "Action", MainActor = "Jean Belmondo", DateRelease = new DateTime(2009,03,12)},
                new Movie { Id = 3, Title = "Umbrellas of Cherbourg", Length = 2, Genre = "Drama", MainActor = "Michael Caine", DateRelease = new DateTime(1959,10,02) }
                );
        }
        public DbSet<Movie> Movies { get; set;}
    }
}
