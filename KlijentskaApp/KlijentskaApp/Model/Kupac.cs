using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KlijentskaApp.Model
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/RestApiProjekt.Models")]
    class Kupac
    {
        [DataMember(Order = 0)]
        public string Ime { get; set; }
        [DataMember(Order = 1)]
        public string Email { get; set; }
        [DataMember(Order = 2)]
        public string BrojMobitela { get; set; }
        [DataMember(Order = 3)]
        public string Adresa { get; set; }
        [DataMember(Order = 4)]
        public string OIB { get; set; }

        public Kupac(string ime, string email, string brojMobitela, string adresa, string oib)
        {
            Ime = ime;
            Email = email;
            BrojMobitela = brojMobitela;
            Adresa = adresa;
            OIB = oib;
        }
        public Kupac()
        {

        }
    }

}
