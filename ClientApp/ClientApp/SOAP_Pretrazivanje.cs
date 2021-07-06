using ClientApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ClientApp
{
    public partial class SOAP_Pretrazivanje : Form
    {
        public SOAP_Pretrazivanje()
        {
            InitializeComponent();
        }

        private void btnPretrazivanje_Click(object sender, EventArgs e)
        {
            FindService.FinderServisSoapClient service = new FindService.FinderServisSoapClient();
            XElement result = service.Find(txtRijec.Text);
            prikaziKupca(result);
        }

        private void prikaziKupca(XElement result)
        {
            //Ime
            var imeNode = result.Descendants("Ime");
            var ime = imeNode.FirstOrDefault();
            txtIme.Text = (string)ime;

            //Email
            var emailNode = result.Descendants("Email");
            var email = emailNode.FirstOrDefault();
            txtEmail.Text = (string)email;

            //BrojMobitela
            var brojMobitelaNode = result.Descendants("BrojMobitela");
            var brojMobitela = brojMobitelaNode.FirstOrDefault();
            txtBrojMobitela.Text = (string)brojMobitela;

            //Adresa
            var adresaNode = result.Descendants("Adresa");
            var adresa = adresaNode.FirstOrDefault();
            txtAdresa.Text = (string)adresa;

            //OIB
            var OIBNode = result.Descendants("OIB");
            var OIB = OIBNode.FirstOrDefault();
            txtOIB.Text = (string)OIB;
        }
    }
}
