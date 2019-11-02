using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using System.Diagnostics;
using Newtonsoft.Json;

namespace GetOAuthToken
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void buttonGetCredential_Click(object sender, EventArgs e)
        {
            labelAccessTokenData.Text = "Requesting token...";
            try
            {
                AuthorizationToken result = GetOAuthToken.Program.RunAsync(textBoxTenantId.Text, textBoxClientId.Text, textBoxClientSecret.Text);
                labelExpiresInData.Text = result.Expires_In.ToString();
                labelNotBeforeData.Text = result.Not_Before.ToString();
                labelExpiresOnData.Text = result.Expires_On.ToString();
                labelTokenTypeData.Text = result.Token_Type;
                labelAccessTokenData.Text = result.Access_Token;
            }
            catch(Exception err)
            {
                labelAccessTokenData.Text = err.Message;
            }

        }

        public void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}