using DawaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DawaService.Models
{
    public class Postnummer
    {
        public string href { get; set; }
        public string nr { get; set; }
        public string navn { get; set; }
    }

    public class Kommuner
    {
        public string href { get; set; }
        public string kode { get; set; }
        public string navn { get; set; }
    }
}
