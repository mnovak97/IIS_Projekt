using ClientApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClientApp
{
    public partial class RNGValidacija : Form
    {
        private string token;
        public RNGValidacija(string JWTtoken)
        {
            InitializeComponent();
            token = JWTtoken;
        }

        private void btnRNG_Click(object sender, EventArgs e)
        {
            Kupac noviKupac = new Kupac(txtIme.Text, txtEmail.Text, txtBrojMobitela.Text, txtAdresa.Text, txtOIB.Text);
            DataContractSerializer serializer = new DataContractSerializer(typeof(Kupac));
            MemoryStream data = new MemoryStream();
            XmlWriter writer = XmlWriter.Create(data);
            serializer.WriteObject(writer, noviKupac);
            writer.Close();

            byte[] dataForRequest = Encoding.UTF8.GetBytes(Encoding.UTF8.GetString(data.ToArray()));

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost:5000/api/Kupac/rng");
                request.Method = "POST";
                request.Accept = "application/xml";
                request.ContentType = "application/xml";
                request.PreAuthenticate = true;
                request.Headers.Add("Authorization", "Bearer " + token);
                Stream requestData = request.GetRequestStream();
                requestData.Write(dataForRequest, 0, dataForRequest.Length);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Kupac uspjesno dodan!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Validacija nije prošla!");
            }
        }
    }
}
