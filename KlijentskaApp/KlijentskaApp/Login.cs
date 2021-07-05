using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KlijentskaApp
{
    public partial class Login : Form
    {
        private string token;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri("http://localhost:5000/api/Login");
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.ContentType = "application/json";
                webRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
                {
                    string json = "{\"username\":\"" + txtUsername.Text + "\"," +
                      "\"password\":\"" + txtPasword.Text + "\"}";
                    streamWriter.Write(json);
                }

                var response = (HttpWebResponse)webRequest.GetResponse();
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    dynamic data = JObject.Parse(result);
                    token = data.token;
                }

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.Hide();
                    Main mainForm = new Main(token);
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid username or password");
            }

          
            
        }
    }
}
