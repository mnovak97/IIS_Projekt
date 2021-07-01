using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SOAP_servis.Models
{
    [Serializable]
    public class Kupac
    {
        public string Ime { get; set; }
        public string Email { get; set; }
        public string BrojMobitela { get; set; }
        public string Adresa { get; set; }
        public string OIB { get; set; }

        public Kupac(string ime,string email,string brojMobitela,string adresa,string oib)
        {
            Ime = ime;
            Email = email;
            BrojMobitela = brojMobitela;
            Adresa = adresa;
            OIB = oib;
        }
    }
}