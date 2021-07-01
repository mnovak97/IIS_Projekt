using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiProjekt.Models;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Runtime.Serialization;
using System.IO;
using Commons.Xml.Relaxng;

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

        [HttpPost("xml")]
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
                    DataContractSerializer deserializer = new DataContractSerializer(typeof(Kupac));
                    Kupac noviKupac = (Kupac)deserializer.ReadObject(xmlStream);
                    Startup.PopisKupaca.Add(noviKupac);
                }
                catch
                {

                    Response.StatusCode = StatusCodes.Status400BadRequest;
                }
            }
        }

        private void XmlValidacija(object sender, ValidationEventArgs e)
        {
            error = true;
        }
    }
}