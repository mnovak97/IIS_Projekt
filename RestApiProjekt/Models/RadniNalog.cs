using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace RestApiProjekt.Models
{
    [DataContract]
    public class RadniNalog
    {
        [DataMember(Order = 0)]
        public int IDRadniNalog { get; set; }
        [DataMember(Order = 1)]
        public int KorisnikID { get; set; }
        [DataMember(Order = 2)]
        public int KupacID { get; set; }
        [DataMember(Order = 3)]
        public double UkupnaCijena { get; set; }
        [DataMember(Order = 4)]
        public bool Gotovo { get; set; }
        [DataMember(Order = 5)]
        public bool Garancija { get; set; }
        [DataMember(Order = 6)]
        public List<Usluga> Stavke { get; set; }

        public RadniNalog(int korinsikID,int kupacID,double ukupnaCijena,bool gotovo,bool garancija,List<Usluga> stavke)
        {
            this.KorisnikID = korinsikID;
            this.KupacID = kupacID;
            this.UkupnaCijena = ukupnaCijena;
            this.Gotovo = gotovo;
            this.Garancija = garancija;
            this.Stavke = stavke;
        }
    }
}
