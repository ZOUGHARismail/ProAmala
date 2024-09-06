namespace WindowsFormsAmala_Vol3.GUI
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnGesDeSortie = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGesDeMarche = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGesDeLocalite = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnGesDeStock = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGesDeSortie);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGesDeMarche);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGesDeLocalite);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnGesDeStock);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(800, 597);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnGesDeSortie
            // 
            this.btnGesDeSortie.CheckedState.Parent = this.btnGesDeSortie;
            this.btnGesDeSortie.CustomImages.Parent = this.btnGesDeSortie;
            this.btnGesDeSortie.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGesDeSortie.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnGesDeSortie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGesDeSortie.ForeColor = System.Drawing.Color.Black;
            this.btnGesDeSortie.HoverState.Parent = this.btnGesDeSortie;
            this.btnGesDeSortie.Location = new System.Drawing.Point(298, 288);
            this.btnGesDeSortie.Name = "btnGesDeSortie";
            this.btnGesDeSortie.ShadowDecoration.Parent = this.btnGesDeSortie;
            this.btnGesDeSortie.Size = new System.Drawing.Size(230, 45);
            this.btnGesDeSortie.TabIndex = 4;
            this.btnGesDeSortie.Text = "Gestion Sortie L\'inventaire";
            this.btnGesDeSortie.Click += new System.EventHandler(this.btnGesDeSortie_Click);
            // 
            // btnGesDeMarche
            // 
            this.btnGesDeMarche.CheckedState.Parent = this.btnGesDeMarche;
            this.btnGesDeMarche.CustomImages.Parent = this.btnGesDeMarche;
            this.btnGesDeMarche.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGesDeMarche.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnGesDeMarche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGesDeMarche.ForeColor = System.Drawing.Color.Black;
            this.btnGesDeMarche.HoverState.Parent = this.btnGesDeMarche;
            this.btnGesDeMarche.Location = new System.Drawing.Point(298, 157);
            this.btnGesDeMarche.Name = "btnGesDeMarche";
            this.btnGesDeMarche.ShadowDecoration.Parent = this.btnGesDeMarche;
            this.btnGesDeMarche.Size = new System.Drawing.Size(230, 45);
            this.btnGesDeMarche.TabIndex = 3;
            this.btnGesDeMarche.Text = "Gestion De Marche";
            this.btnGesDeMarche.Click += new System.EventHandler(this.btnGesDeMarche_Click);
            // 
            // btnGesDeLocalite
            // 
            this.btnGesDeLocalite.CheckedState.Parent = this.btnGesDeLocalite;
            this.btnGesDeLocalite.CustomImages.Parent = this.btnGesDeLocalite;
            this.btnGesDeLocalite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGesDeLocalite.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnGesDeLocalite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGesDeLocalite.ForeColor = System.Drawing.Color.Black;
            this.btnGesDeLocalite.HoverState.Parent = this.btnGesDeLocalite;
            this.btnGesDeLocalite.Location = new System.Drawing.Point(298, 223);
            this.btnGesDeLocalite.Name = "btnGesDeLocalite";
            this.btnGesDeLocalite.ShadowDecoration.Parent = this.btnGesDeLocalite;
            this.btnGesDeLocalite.Size = new System.Drawing.Size(230, 45);
            this.btnGesDeLocalite.TabIndex = 2;
            this.btnGesDeLocalite.Text = "Gestion De Localite";
            this.btnGesDeLocalite.Click += new System.EventHandler(this.btnGesDeLocalite_Click);
            // 
            // btnGesDeStock
            // 
            this.btnGesDeStock.CheckedState.Parent = this.btnGesDeStock;
            this.btnGesDeStock.CustomImages.Parent = this.btnGesDeStock;
            this.btnGesDeStock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGesDeStock.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnGesDeStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGesDeStock.ForeColor = System.Drawing.Color.Black;
            this.btnGesDeStock.HoverState.Parent = this.btnGesDeStock;
            this.btnGesDeStock.Location = new System.Drawing.Point(298, 89);
            this.btnGesDeStock.Name = "btnGesDeStock";
            this.btnGesDeStock.ShadowDecoration.Parent = this.btnGesDeStock;
            this.btnGesDeStock.Size = new System.Drawing.Size(230, 45);
            this.btnGesDeStock.TabIndex = 0;
            this.btnGesDeStock.Text = "Gestion De Stock";
            this.btnGesDeStock.Click += new System.EventHandler(this.btnGesDeStock_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnGesDeSortie;
        private Guna.UI2.WinForms.Guna2GradientButton btnGesDeMarche;
        private Guna.UI2.WinForms.Guna2GradientButton btnGesDeLocalite;
        private Guna.UI2.WinForms.Guna2GradientButton btnGesDeStock;
    }
}