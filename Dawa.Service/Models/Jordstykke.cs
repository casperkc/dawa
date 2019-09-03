using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DawaService.Models
{
    public class Jordstykke
    {
        public string href { get; set; }
        public string matrikelnr { get; set; }
        public string esrejendomsnr { get; set; }
        public Ejerlav2 ejerlav { get; set; }
    }
}
