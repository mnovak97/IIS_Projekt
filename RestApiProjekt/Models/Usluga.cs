using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RestApiProjekt.Models
{
    [DataContract]
    public class Usluga
    {
        [DataMember(Order = 0)]
        public int IDUsluga { get; set; }
        [DataMember(Order = 1)]
        public string Sifra { get; set; }
        [DataMember(Order = 2)]
        public string NazivUsluga { get; set; }
        [DataMember(Order = 3)]
        public int Komada { get; set; }
        [DataMember(Order = 4)]
        public double Cijena { get; set; }

        public Usluga(string sifra,string nazivUsluga,int komada,double cijena)
        {
            this.Sifra = sifra;
            this.NazivUsluga = nazivUsluga;
            this.Komada = komada;
            this.Cijena = cijena;
        }

    }
}
