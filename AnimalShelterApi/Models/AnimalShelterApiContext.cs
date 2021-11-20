using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
              new Animal { AnimalId = 1, Name = "Ralph", Species = "Canine", Gender = "Male", Color = "Brown", Age = 3, Description = "Ralph is a 3 year old male dog. He is brown in color and as lovable as they come!"},
              new Animal { AnimalId = 2, Name = "Suzy", Species = "Feline", Gender = "Female", Color = "Orange", Age = 9, Description = "Suzy is an older 9 year old female cat. She is orange in color, gentle and nurturing -- great for an older person with plenty of patience."},
              new Animal { AnimalId = 3, Name = "Terry", Species = "Canine", Gender = "Female", Color = "Black", Age = 5, Description = "Terry is a 5 year old female dog. Terry is black in color, energetic and ready to meet her new active family!"},
              new Animal { AnimalId = 4, Name = "Jake", Species = "Feline", Gender = "Male", Color = "Tabby", Age = 4, Description = "Jake is a 4 year old male cat. Jake is a tabby cat, and quite playful. He'd be a great addition to a younger family."},
              new Animal { AnimalId = 5, Name = "Dino", Species = "Canine", Gender = "Male", Color = "Yellow", Age = 8, Description = "Dino is an 8 year old male dog. Dino is Yellow in color. Don't let his age fool you; this happy dog's best days are still in front of him."},
              new Animal { AnimalId = 6, Name = "Lambert", Species = "Feline", Gender = "Female", Color = "Grey", Age = 1, Description = "Lambert is a 1 year old female kitten, grey in color. Lambert is as cute and cuddly as they come, and is sure to warm even the coldest of hearts."}
          );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}