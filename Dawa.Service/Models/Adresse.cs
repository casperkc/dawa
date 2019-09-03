using System;

namespace Dawa.Service.Models
{
    public class Adresse
    {
        public Guid Id { get; set; }

        public string Adressebetegnelse { get; set; }

        public string Etage { get; set; }

        public string Dør { get; set; }

        public string Kvhx { get; set; }

        public int Status { get; set; }

        public int Darstatus { get; set; }

        public Uri Href { get; set; }

        public Historik Historik { get; set; }

        //public Adgangsadresse Adgangsadresse { get; set; }
    }
}
