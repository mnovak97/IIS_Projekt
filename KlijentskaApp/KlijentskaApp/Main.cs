using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlijentskaApp
{
    public partial class Main : Form
    {

        private string token;
        public Main(string JWTToken)
        {
            InitializeComponent();
            token = JWTToken;
        }

        private void btnXSD_Click(object sender, EventArgs e)
        {
            XSDValidacija form = new XSDValidacija(token);
            form.Show();
        }

        private void btnRNG_Click(object sender, EventArgs e)
        {

        }

        private void btnPretrazivanje_Click(object sender, EventArgs e)
        {

        }

        private void btnTemperatura_Click(object sender, EventArgs e)
        {

        }
    }
}
