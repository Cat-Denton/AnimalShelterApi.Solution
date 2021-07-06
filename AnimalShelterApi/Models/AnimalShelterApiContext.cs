using System;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
      : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal{AnimalId = 1, Name = "Hiccup", Species = "Cat", Gender = "Male", Birthdate = Convert.ToDateTime("2015-01-01T00:00:00"), ImageUrl = "imgur.com/hiccupcat" },
          new Animal{AnimalId = 2, Name = "Zipper", Species = "Dog", Gender = "Female", Birthdate = Convert.ToDateTime("2015-01-01T00:00:00"), ImageUrl = "imgur.com/zipdog" },
          new Animal{AnimalId = 3, Name = "Coraline", Species = "Cat", Gender = "Female", Birthdate = Convert.ToDateTime("2015-01-01T00:00:00"), ImageUrl = "imgur.com/coralcat" },
          new Animal{AnimalId = 4, Name = "Winchester", Species = "Dog", Gender = "Male", Birthdate = Convert.ToDateTime("2015-01-01T00:00:00"), ImageUrl = "imgur.com/windoge" }
        );
    }
  }
}