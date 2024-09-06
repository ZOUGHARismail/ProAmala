namespace WindowsFormsAmala_Vol3.GUI
{
    partial class FormGesSortieInventaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDelevery = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ComboLocalite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEnregDelevery = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBoxLocalite = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboBoxMateriel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAjouterLocalite = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtLocalite = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLocaliteOk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnImprimer = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelevery)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDelevery
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDelevery.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDelevery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDelevery.BackgroundColor = System.Drawing.Color.White;
            this.dgvDelevery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDelevery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDelevery.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelevery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDelevery.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDelevery.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDelevery.EnableHeadersVisualStyles = false;
            this.dgvDelevery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDelevery.Location = new System.Drawing.Point(41, 83);
            this.dgvDelevery.Name = "dgvDelevery";
            this.dgvDelevery.RowHeadersVisible = false;
            this.dgvDelevery.RowTemplate.Height = 28;
            this.dgvDelevery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelevery.Size = new System.Drawing.Size(1811, 471);
            this.dgvDelevery.TabIndex = 6;
            this.dgvDelevery.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDelevery.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDelevery.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDelevery.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDelevery.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDelevery.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDelevery.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDelevery.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDelevery.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDelevery.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDelevery.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDelevery.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDelevery.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDelevery.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvDelevery.ThemeStyle.ReadOnly = false;
            this.dgvDelevery.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDelevery.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDelevery.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDelevery.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDelevery.ThemeStyle.RowsStyle.Height = 28;
            this.dgvDelevery.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDelevery.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDelevery.Click += new System.EventHandler(this.dgvDelevery_Click);
            // 
            // ComboLocalite
            // 
            this.ComboLocalite.BackColor = System.Drawing.Color.Transparent;
            this.ComboLocalite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboLocalite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboLocalite.FocusedColor = System.Drawing.Color.Empty;
            this.ComboLocalite.FocusedState.Parent = this.ComboLocalite;
            this.ComboLocalite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboLocalite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboLocalite.FormattingEnabled = true;
            this.ComboLocalite.HoverState.Parent = this.ComboLocalite;
            this.ComboLocalite.ItemHeight = 30;
            this.ComboLocalite.ItemsAppearance.Parent = this.ComboLocalite;
            this.ComboLocalite.Location = new System.Drawing.Point(837, 12);
            this.ComboLocalite.Name = "ComboLocalite";
            this.ComboLocalite.ShadowDecoration.Parent = this.ComboLocalite;
            this.ComboLocalite.Size = new System.Drawing.Size(299, 36);
            this.ComboLocalite.TabIndex = 5;
            this.ComboLocalite.SelectedIndexChanged += new System.EventHandler(this.ComboLocalite_SelectedIndexChanged);
            // 
            // btnEnregDelevery
            // 
            this.btnEnregDelevery.CheckedState.Parent = this.btnEnregDelevery;
            this.btnEnregDelevery.CustomImages.Parent = this.btnEnregDelevery;
            this.btnEnregDelevery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnregDelevery.ForeColor = System.Drawing.Color.White;
            this.btnEnregDelevery.HoverState.Parent = this.btnEnregDelevery;
            this.btnEnregDelevery.Location = new System.Drawing.Point(837, 603);
            this.btnEnregDelevery.Name = "btnEnregDelevery";
            this.btnEnregDelevery.ShadowDecoration.Parent = this.btnEnregDelevery;
            this.btnEnregDelevery.Size = new System.Drawing.Size(299, 34);
            this.btnEnregDelevery.TabIndex = 8;
            this.btnEnregDelevery.Text = "Enregistrer Sortie De l\'inventaire";
            this.btnEnregDelevery.Click += new System.EventHandler(this.btnEnregDelevery_Click);
            // 
            // ComboBoxLocalite
            // 
            this.ComboBoxLocalite.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxLocalite.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxLocalite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxLocalite.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxLocalite.FocusedState.Parent = this.ComboBoxLocalite;
            this.ComboBoxLocalite.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxLocalite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxLocalite.FormattingEnabled = true;
            this.ComboBoxLocalite.HoverState.Parent = this.ComboBoxLocalite;
            this.ComboBoxLocalite.ItemHeight = 20;
            this.ComboBoxLocalite.ItemsAppearance.Parent = this.ComboBoxLocalite;
            this.ComboBoxLocalite.Location = new System.Drawing.Point(504, 3);
            this.ComboBoxLocalite.Name = "ComboBoxLocalite";
            this.ComboBoxLocalite.ShadowDecoration.Parent = this.ComboBoxLocalite;
            this.ComboBoxLocalite.Size = new System.Drawing.Size(140, 26);
            this.ComboBoxLocalite.TabIndex = 9;
            // 
            // ComboBoxMateriel
            // 
            this.ComboBoxMateriel.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxMateriel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxMateriel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMateriel.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxMateriel.FocusedState.Parent = this.ComboBoxMateriel;
            this.ComboBoxMateriel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxMateriel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxMateriel.FormattingEnabled = true;
            this.ComboBoxMateriel.HoverState.Parent = this.ComboBoxMateriel;
            this.ComboBoxMateriel.ItemHeight = 20;
            this.ComboBoxMateriel.ItemsAppearance.Parent = this.ComboBoxMateriel;
            this.ComboBoxMateriel.Location = new System.Drawing.Point(358, 3);
            this.ComboBoxMateriel.Name = "ComboBoxMateriel";
            this.ComboBoxMateriel.ShadowDecoration.Parent = this.ComboBoxMateriel;
            this.ComboBoxMateriel.Size = new System.Drawing.Size(140, 26);
            this.ComboBoxMateriel.TabIndex = 10;
            this.ComboBoxMateriel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMateriel_SelectedIndexChanged);
            // 
            // btnAjouterLocalite
            // 
            this.btnAjouterLocalite.CheckedState.Parent = this.btnAjouterLocalite;
            this.btnAjouterLocalite.CustomImages.Parent = this.btnAjouterLocalite;
            this.btnAjouterLocalite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouterLocalite.ForeColor = System.Drawing.Color.White;
            this.btnAjouterLocalite.HoverState.Parent = this.btnAjouterLocalite;
            this.btnAjouterLocalite.Location = new System.Drawing.Point(1157, 14);
            this.btnAjouterLocalite.Name = "btnAjouterLocalite";
            this.btnAjouterLocalite.ShadowDecoration.Parent = this.btnAjouterLocalite;
            this.btnAjouterLocalite.Size = new System.Drawing.Size(158, 34);
            this.btnAjouterLocalite.TabIndex = 11;
            this.btnAjouterLocalite.Text = "Ajouter Localite";
            this.btnAjouterLocalite.Click += new System.EventHandler(this.btnAjouterLocalite_Click);
            // 
            // txtLocalite
            // 
            this.txtLocalite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocalite.DefaultText = "";
            this.txtLocalite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocalite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocalite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalite.DisabledState.Parent = this.txtLocalite;
            this.txtLocalite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocalite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocalite.FocusedState.Parent = this.txtLocalite;
            this.txtLocalite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocalite.HoverState.Parent = this.txtLocalite;
            this.txtLocalite.Location = new System.Drawing.Point(1333, 14);
            this.txtLocalite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocalite.Name = "txtLocalite";
            this.txtLocalite.PasswordChar = '\0';
            this.txtLocalite.PlaceholderText = "";
            this.txtLocalite.SelectedText = "";
            this.txtLocalite.ShadowDecoration.Parent = this.txtLocalite;
            this.txtLocalite.Size = new System.Drawing.Size(268, 34);
            this.txtLocalite.TabIndex = 12;
            this.txtLocalite.Visible = false;
            // 
            // btnLocaliteOk
            // 
            this.btnLocaliteOk.CheckedState.Parent = this.btnLocaliteOk;
            this.btnLocaliteOk.CustomImages.Parent = this.btnLocaliteOk;
            this.btnLocaliteOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLocaliteOk.ForeColor = System.Drawing.Color.White;
            this.btnLocaliteOk.HoverState.Parent = this.btnLocaliteOk;
            this.btnLocaliteOk.Location = new System.Drawing.Point(1608, 14);
            this.btnLocaliteOk.Name = "btnLocaliteOk";
            this.btnLocaliteOk.ShadowDecoration.Parent = this.btnLocaliteOk;
            this.btnLocaliteOk.Size = new System.Drawing.Size(54, 34);
            this.btnLocaliteOk.TabIndex = 13;
            this.btnLocaliteOk.Text = "ok";
            this.btnLocaliteOk.Visible = false;
            this.btnLocaliteOk.Click += new System.EventHandler(this.btnLocaliteOk_Click);
            // 
            // btnImprimer
            // 
            this.btnImprimer.CheckedState.Parent = this.btnImprimer;
            this.btnImprimer.CustomImages.Parent = this.btnImprimer;
            this.btnImprimer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImprimer.ForeColor = System.Drawing.Color.White;
            this.btnImprimer.HoverState.Parent = this.btnImprimer;
            this.btnImprimer.Location = new System.Drawing.Point(1157, 603);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.ShadowDecoration.Parent = this.btnImprimer;
            this.btnImprimer.Size = new System.Drawing.Size(180, 34);
            this.btnImprimer.TabIndex = 15;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.Click += new System.EventHandler(this.btnImprimer_Click);
            // 
            // FormGesSortieInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1844, 770);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.btnLocaliteOk);
            this.Controls.Add(this.txtLocalite);
            this.Controls.Add(this.btnAjouterLocalite);
            this.Controls.Add(this.ComboBoxMateriel);
            this.Controls.Add(this.ComboBoxLocalite);
            this.Controls.Add(this.btnEnregDelevery);
            this.Controls.Add(this.dgvDelevery);
            this.Controls.Add(this.ComboLocalite);
            this.Name = "FormGesSortieInventaire";
            this.Text = "FormGesSortieInventaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGesSortieInventaire_FormClosing);
            this.Load += new System.EventHandler(this.FormGesSortieInventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelevery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDelevery;
        private Guna.UI2.WinForms.Guna2ComboBox ComboLocalite;
        private Guna.UI2.WinForms.Guna2GradientButton btnEnregDelevery;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxLocalite;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMateriel;
        private Guna.UI2.WinForms.Guna2GradientButton btnAjouterLocalite;
        private Guna.UI2.WinForms.Guna2TextBox txtLocalite;
        private Guna.UI2.WinForms.Guna2GradientButton btnLocaliteOk;
        private Guna.UI2.WinForms.Guna2Button btnImprimer;
    }
}