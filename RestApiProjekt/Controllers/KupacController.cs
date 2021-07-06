using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiProjekt.Models;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Runtime.Serialization;
using System.IO;
using Commons.Xml.Relaxng;
using Microsoft.AspNetCore.Authorization;
using System.Xml.Linq;
using System;
using System.Xml.Serialization;

namespace RestApiProjekt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KupacController : ControllerBase
    {
        
        public List<Kupac> Get()
        {
            return Startup.PopisKupaca;
        }

        private bool error = false;

        [Authorize]
        [HttpPost("xsd")]
        public void PostXMl(XmlElement xmlKupac)
        {
            try
            {
                XmlDocument doc = xmlKupac.OwnerDocument;
                doc.AppendChild(xmlKupac);
                doc.Schemas.Add("http://schemas.datacontract.org/2004/07/RestApiProjekt.Models", "Kupac.xsd");

                ValidationEventHandler validation = new ValidationEventHandler(XmlValidacija);
                doc.Validate(validation);

                if (!error)
                {
                    DataContractSerializer deserijalizacija = new DataContractSerializer(typeof(Kupac));
                    MemoryStream xmlStream = new MemoryStream();
                    doc.Save(xmlStream);
                    xmlStream.Position = 0;
                    Kupac noviKupac = (Kupac)deserijalizacija.ReadObject(xmlStream);
                    Startup.PopisKupaca.Add(noviKupac);
                }
                else
                {
                    Response.StatusCode = StatusCodes.Status400BadRequest;
                }
            }
            catch
            {
                Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
        [Authorize]
        [HttpPost("rng")]
        public void PostRng(XmlElement xmlKupac)
        {
            XmlDocument xmlDoc = xmlKupac.OwnerDocument;
            xmlDoc.AppendChild(xmlKupac);
            MemoryStream xmlStream = new MemoryStream();
            xmlDoc.Save(xmlStream);
            xmlStream.Position = 0;

            XmlReader instance = new XmlTextReader(xmlStream);
            XmlReader grammar = new XmlTextReader("Kupac.rng");
            using (XmlReader reader = new RelaxngValidatingReader(instance,grammar))
            {
                try
                {
                    while (!reader.EOF)
                    {
                        reader.Read();
                    }
                    Startup.PopisKupaca.Add(kreairajKupca(xmlDoc));
                }
                catch
                {

                    Response.StatusCode = StatusCodes.Status400BadRequest;
                }
            }
        }

        private Kupac kreairajKupca(XmlDocument xmlDoc)
        {
            Kupac noviKupac = new Kupac();
            noviKupac.Ime = xmlDoc.DocumentElement.ChildNodes[0].InnerText;
            noviKupac.Email = xmlDoc.DocumentElement.ChildNodes[1].InnerText;
            noviKupac.BrojMobitela = xmlDoc.DocumentElement.ChildNodes[2].InnerText;
            noviKupac.Adresa = xmlDoc.DocumentElement.ChildNodes[3].InnerText;
            noviKupac.OIB = xmlDoc.DocumentElement.ChildNodes[4].InnerText;

            return noviKupac;
        }

        private void XmlValidacija(object sender, ValidationEventArgs e)
        {
            error = true;
        }
    }
}