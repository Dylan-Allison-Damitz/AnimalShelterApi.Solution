using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelterApi.Models;

namespace AnimalShelterApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalShelterApiContext _db;

    public AnimalsController(AnimalShelterApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string name, string species, string gender, string color, int age, string description)
    {
      var query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }    

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      } 

      if (color != null)
      {
        query = query.Where(entry => entry.Color == color);
      } 

      if (age != 0)
      {
        query = query.Where(entry => entry.Age == age);
      }                

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      } 

      return await query.ToListAsync();
    }
  }
}