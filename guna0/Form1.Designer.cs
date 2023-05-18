
namespace guna0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft PhagsPa", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(25, 2);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(172, 62);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "LOGIN";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.gunaLabel1);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Lime;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.LightGreen;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.DarkKhaki;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Yellow;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(272, 7);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Quality = 4;
            this.gunaGradientPanel1.Size = new System.Drawing.Size(223, 72);
            this.gunaGradientPanel1.TabIndex = 1;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
    }
}

