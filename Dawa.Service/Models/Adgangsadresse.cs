using DawaService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dawa.Service.Models
{
    public class Adgangsadresse
    {
        public string href { get; set; }
        public string id { get; set; }
        public string kvh { get; set; }
        public int status { get; set; }
        public Vejstykke vejstykke { get; set; }
        public string husnr { get; set; }
        public string supplerendebynavn { get; set; }
        public Postnummer postnummer { get; set; }
        public object stormodtagerpostnummer { get; set; }
        public Kommune kommune { get; set; }
        public Ejerlav ejerlav { get; set; }
        public string esrejendomsnr { get; set; }
        public string matrikelnr { get; set; }
        public Historik2 historik { get; set; }
        public Adgangspunkt adgangspunkt { get; set; }
        public DDKN DDKN { get; set; }
        public Sogn sogn { get; set; }
        public Region region { get; set; }
        public Retskreds retskreds { get; set; }
        public Politikreds politikreds { get; set; }
        public Opstillingskreds opstillingskreds { get; set; }
        public string zone { get; set; }
        public Jordstykke jordstykke { get; set; }
    }
}
