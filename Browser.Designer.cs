namespace SimpleBrowser
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.butnHome = new System.Windows.Forms.Button();
            this.tboxAddressBar = new System.Windows.Forms.TextBox();
            this.butnGo = new System.Windows.Forms.Button();
            this.butnBack = new System.Windows.Forms.Button();
            this.butnForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // butnHome
            // 
            this.butnHome.Location = new System.Drawing.Point(12, 12);
            this.butnHome.Name = "butnHome";
            this.butnHome.Size = new System.Drawing.Size(123, 44);
            this.butnHome.TabIndex = 1;
            this.butnHome.Text = "Home";
            this.butnHome.UseVisualStyleBackColor = true;
            this.butnHome.Click += new System.EventHandler(this.butnHome_Click);
            // 
            // tboxAddressBar
            // 
            this.tboxAddressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAddressBar.Location = new System.Drawing.Point(141, 12);
            this.tboxAddressBar.Name = "tboxAddressBar";
            this.tboxAddressBar.Size = new System.Drawing.Size(290, 38);
            this.tboxAddressBar.TabIndex = 2;
            // 
            // butnGo
            // 
            this.butnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnGo.Location = new System.Drawing.Point(437, 12);
            this.butnGo.Name = "butnGo";
            this.butnGo.Size = new System.Drawing.Size(123, 44);
            this.butnGo.TabIndex = 3;
            this.butnGo.Text = "🗸";
            this.butnGo.UseVisualStyleBackColor = true;
            this.butnGo.Click += new System.EventHandler(this.butnGo_Click);
            // 
            // butnBack
            // 
            this.butnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnBack.Location = new System.Drawing.Point(12, 62);
            this.butnBack.Name = "butnBack";
            this.butnBack.Size = new System.Drawing.Size(59, 44);
            this.butnBack.TabIndex = 4;
            this.butnBack.Text = "↶";
            this.butnBack.UseVisualStyleBackColor = true;
            this.butnBack.Click += new System.EventHandler(this.butnBack_Click);
            // 
            // butnForward
            // 
            this.butnForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnForward.Location = new System.Drawing.Point(77, 62);
            this.butnForward.Name = "butnForward";
            this.butnForward.Size = new System.Drawing.Size(58, 44);
            this.butnForward.TabIndex = 5;
            this.butnForward.Text = "↷";
            this.butnForward.UseVisualStyleBackColor = true;
            this.butnForward.Click += new System.EventHandler(this.butnForward_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butnForward);
            this.Controls.Add(this.butnBack);
            this.Controls.Add(this.butnGo);
            this.Controls.Add(this.tboxAddressBar);
            this.Controls.Add(this.butnHome);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Browser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button butnHome;
        private System.Windows.Forms.TextBox tboxAddressBar;
        private System.Windows.Forms.Button butnGo;
        private System.Windows.Forms.Button butnBack;
        private System.Windows.Forms.Button butnForward;
    }
}

