using System;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public DateTime Birthdate { get; set; }
    public string ImageUrl { get; set; }
  }
}