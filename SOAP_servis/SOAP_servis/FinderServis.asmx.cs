using SOAP_servis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace SOAP_servis
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FinderServis : System.Web.Services.WebService
    {
        internal static List<Kupac> PopisKupaca;
        XmlDocument xmlDoc;

        public FinderServis()
        {
           
            PopisKupaca = new List<Kupac>();
            Kupac k1 = new Kupac("Martin", "ipad3monkey@gmail.com", "0919158566", "Gornji Bukovac 96", "12345678941");
            Kupac k2 = new Kupac("Marko", "marko@gmail.com", "0994569874", "Ilica 242", "45621478963");
            PopisKupaca.Add(k1);
            PopisKupaca.Add(k2);
            xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Kupci");
            xmlDoc.AppendChild(root);
            foreach (var kupac in PopisKupaca)
            {
                XmlElement child = xmlDoc.CreateElement("Kupac");
                XmlElement ime = xmlDoc.CreateElement("Ime");
                ime.InnerText = kupac.Ime;
                child.AppendChild(ime);
                XmlElement email = xmlDoc.CreateElement("Email");
                email.InnerText = kupac.Email;
                child.AppendChild(email);
                XmlElement brojMobitela = xmlDoc.CreateElement("BrojMobitela");
                brojMobitela.InnerText = kupac.BrojMobitela;
                child.AppendChild(brojMobitela);
                XmlElement adresa = xmlDoc.CreateElement("Adresa");
                adresa.InnerText = kupac.Adresa;
                child.AppendChild(adresa);
                XmlElement oib = xmlDoc.CreateElement("OIB");
                oib.InnerText = kupac.OIB;
                child.AppendChild(oib);
                root.AppendChild(child);
            }
            xmlDoc.Save("D:\\Documents\\GitHub\\IIS_Projekt\\SOAP_servis\\SOAP_servis\\Kupci.xml");
        }
        [WebMethod]
        public XmlNode Find(string word)
        {
            XmlNode kupac = xmlDoc.SelectSingleNode("/Kupci/Kupac[Ime='"+word+"']");

            return kupac;

        }
    }
}
