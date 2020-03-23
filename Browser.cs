using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void butnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void butnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tboxAddressBar.Text);
        }

        private void butnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void butnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void tboxAddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(tboxAddressBar.Text);
            }
        }

        private void Browser_Resize(object sender, EventArgs e)
        {
            webBrowser1.Width = this.ClientRectangle.Width;
            webBrowser1.Height = this.ClientRectangle.Height - 100;
        }
    }
}
