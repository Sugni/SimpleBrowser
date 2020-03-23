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
            webBrowser1.Width = this.ClientRectangle.Width;
            webBrowser1.Height = this.ClientRectangle.Height - 100;
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
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

        private void butnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;

            foreach (Control c in this.Controls)
            {
                c.BackColor = Color.Black;
                c.ForeColor = Color.White;
            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            foreach (Control c in this.Controls)
            {
                c.BackColor = Color.White;
                c.ForeColor = Color.Black;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
