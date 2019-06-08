using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AceCodeDay2019
{
    public partial class Form2 : Form
    {
        public Form2(string url)
        {
            InitializeComponent();
            webBrowser1.Navigate(url);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Completely);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private async void oblivionButton1_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            webBrowser1.Refresh(WebBrowserRefreshOption.Normal);
            panel1.Size = new Size(0, 0);
        }
    }
}
