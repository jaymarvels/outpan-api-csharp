using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OutPanApiGet
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var credentials = GetCredentials();
            if (string.IsNullOrEmpty(credentials))
            {
                MessageBox.Show("Please set your credentials first!");
                return;
            }

            var ean = GetEan();
            if (string.IsNullOrEmpty(ean))
            {
                MessageBox.Show("Please set a EAN first!");
                return;
            }

            var suffix = GetSuffix();

            var url = SetUrl(ean, suffix);

            WebRequest myReq = WebRequest.Create(url);
            myReq.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(credentials));
            WebResponse wr = myReq.GetResponse();
            Stream receiveStream = wr.GetResponseStream();
            if (receiveStream != null)
            {
                StreamReader reader = new StreamReader(receiveStream, Encoding.UTF8);
                string content = reader.ReadToEnd();
                switch (suffix)
                {
                    case "":
                        var allResult = JsonConvert.DeserializeObject<OutpanApiAllModel>(content);
                        var formatted = JsonConvert.SerializeObject(allResult, Formatting.Indented);
                        rTxtOutput.Clear();
                        rTxtOutput.Text = formatted;
                        break;
                    case "Attributes":
                        var attrResult = JsonConvert.DeserializeObject<OutpanApiAttributesModel>(content);
                        break;
                    case "Images":
                        var imageResult = JsonConvert.DeserializeObject<OutpanApiImageModel>(content);
                        break;
                    case "Name":
                        var nameResult = JsonConvert.DeserializeObject<OutpanApiNameModel>(content);
                        break;
                    case "Videos":
                        var videoResult = JsonConvert.DeserializeObject<OutpanApiVideosModel>(content);
                        break;                      
                }

                

            }
        }

        public string SetUrl(string gtin, string suffix)
        {
            var url = "https://api.outpan.com/v1/products/" + gtin + "/" + suffix;
            return url;
        }

        public string GetEan()
        {
            return txtEANNumber.Text.Trim();
        }

        public string GetSuffix()
        {
            if (cboRequestType.SelectedItem.ToString() == "All")
            {
                return "";
            }
            return cboRequestType.SelectedItem.ToString();
        }

        public void SetCredetntials(string credentials)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["userCredentials"].Value = credentials;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public string GetCredentials()
        {
            return ConfigurationManager.AppSettings["userCredentials"];
        }

        private void btnSetCredentials_Click(object sender, EventArgs e)
        {
            var apikey = txtApiValue.Text;
            var validate = apikey.Substring(apikey.Length - 1, 1);
            if (validate != ":")
            {
                MessageBox.Show(
                    "Please Enter a valid Api Key in the following format:- XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX:");
            }
            else
            {
                SetCredetntials(apikey);
            }
        }
    }
}
