using DawaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DawaService.Models
{
    public class Adgangspunkt
    {
        public List<double> koordinater { get; set; }
        public string __invalid_name__nøjagtighed { get; set; }
        public int kilde { get; set; }
        public string tekniskstandard { get; set; }
        public double tekstretning { get; set; }
        public string ændret { get; set; }
    }
}
