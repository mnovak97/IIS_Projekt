using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;

namespace ClientApp
{
    public partial class Temperatura : Form
    {
        public Temperatura()
        {
            InitializeComponent();
        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("data.xml");
            //method name
            doc.DocumentElement.ChildNodes[0].InnerText = "Temperatura.temp";
            //parametar string(Ime grada)
            doc.DocumentElement.ChildNodes[1].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText = txtImeGrada.Text;
            
            //save xml in stream 
            MemoryStream xmlStream = new MemoryStream();
            doc.Save(xmlStream);

            byte[] data = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(xmlStream.ToArray()));

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:8080");
            request.Method = "POST";
            request.Accept = "application/xml";
            request.ContentType = "application/xml";
            Stream dataForRequest = request.GetRequestStream();
            dataForRequest.Write(data, 0, data.Length);
            dataForRequest.Close();


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataResponse = response.GetResponseStream();

            XmlDocument docResponse = new XmlDocument();
            docResponse.Load(dataResponse);

            //getting response value
            lblTemperatura.Text = docResponse.DocumentElement.ChildNodes[0].ChildNodes[0].ChildNodes[0].ChildNodes[0].InnerText;

        }
    }
}
