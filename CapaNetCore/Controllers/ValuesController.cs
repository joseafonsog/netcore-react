using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNetCore.Models;
using CapaNetCore.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CapaNetCore.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly ApplicationDbContext _context;

    public ValuesController(ApplicationDbContext context)
    {
      _context = context;
    }

    // GET api/values
    [HttpGet]
    public object Get()
    {
      return _context.Personas.ToList();
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
      _context.Personas.Add(new Persona
      {
        Nombre = "Marito"
      });

      _context.SaveChanges();

      var persona = _context.Personas.FirstOrDefault(a => a.Id == 1);
      return persona.Nombre;
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody] Dto dto)
    {
      _context.Personas.Add(new Persona
      {
        Nombre = dto.Nombre
      });

      _context.SaveChanges();


    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
