namespace AceCodeDay2019
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.oblivionButton1 = new OblivionUI.Controls.OblivionButton(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(784, 461);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AceCodeDay2019.Properties.Resources.splash_gradient;
            this.panel1.Controls.Add(this.oblivionButton1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 461);
            this.panel1.TabIndex = 2;
            // 
            // oblivionButton1
            // 
            this.oblivionButton1.BackColor = System.Drawing.Color.RoyalBlue;
            this.oblivionButton1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.oblivionButton1.FlatAppearance.BorderSize = 0;
            this.oblivionButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.oblivionButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.oblivionButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.oblivionButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oblivionButton1.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.oblivionButton1.ForeColor = System.Drawing.Color.White;
            this.oblivionButton1.Location = new System.Drawing.Point(259, 135);
            this.oblivionButton1.Name = "oblivionButton1";
            this.oblivionButton1.Size = new System.Drawing.Size(301, 168);
            this.oblivionButton1.TabIndex = 0;
            this.oblivionButton1.Text = "Reveal Your Results!";
            this.oblivionButton1.UseVisualStyleBackColor = false;
            this.oblivionButton1.Click += new System.EventHandler(this.oblivionButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "See your results!";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private OblivionUI.Controls.OblivionButton oblivionButton1;
    }
}