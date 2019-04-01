using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapaNetCore.Models
{
  public class Dto
  {
        [JsonProperty("nombre")]
    public string Nombre { get; set; }
  }
}
