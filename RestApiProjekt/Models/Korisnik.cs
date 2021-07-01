using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RestApiProjekt.Models
{
    [DataContract]
    public class Korisnik
    {
        [DataMember(Order = 0)]
        public int IDKorisnik { get; set; }
        [DataMember(Order = 1)]
        public string Role { get; set; }
        [DataMember(Order = 2)]
        public string KorisnickoIme { get; set; }
        [DataMember(Order = 3)]
        public string Lozinka { get; set; }

        public Korisnik(string role,string korisnickoIme,string lozinka)
        {
            this.Role = role;
            this.KorisnickoIme = korisnickoIme;
            this.Lozinka = lozinka;
        }
    }
}
