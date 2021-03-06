﻿using System;
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
            var cred = GetCredentials();
            if (!string.IsNullOrEmpty(cred))
            {
                txtApiValue.Text = cred;
            }
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
                        ClearText();
                        SetTextOutPut(formatted);
                        break;
                    case "attributes":
                        var attrResult = JsonConvert.DeserializeObject<OutpanApiAttributesModel>(content);
                        var attrformatted = JsonConvert.SerializeObject(attrResult, Formatting.Indented);
                        ClearText();
                        SetTextOutPut(attrformatted);
                        break;
                    case "images":
                        var imageResult = JsonConvert.DeserializeObject<OutpanApiImageModel>(content);
                        var imgformatted = JsonConvert.SerializeObject(imageResult, Formatting.Indented);
                        ClearText();
                        SetTextOutPut(imgformatted);
                        break;
                    case "name":
                        var nameResult = JsonConvert.DeserializeObject<OutpanApiNameModel>(content);
                        var nameformatted = JsonConvert.SerializeObject(nameResult, Formatting.Indented);
                        ClearText();
                        SetTextOutPut(nameformatted);
                        break;
                    case "videos":
                        var videoResult = JsonConvert.DeserializeObject<OutpanApiVideosModel>(content);
                        var videoformatted = JsonConvert.SerializeObject(videoResult, Formatting.Indented);
                        ClearText();
                        SetTextOutPut(videoformatted);
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
            return cboRequestType.SelectedItem.ToString().ToLower();
        }

        public void SetCredetntials(string credentials)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            configuration.AppSettings.Settings["userCredentials"].Value = credentials;
            configuration.Save(ConfigurationSaveMode.Minimal);
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

        public void ClearText()
        {
            rTxtOutput.Clear();
        }

        public void SetTextOutPut(string formatted)
        {
            rTxtOutput.Text = formatted;
        }
    }
}
