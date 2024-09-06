namespace WindowsFormsAmala_Vol3.GUI
{
    partial class FormGestionDeMarche
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
            this.txtNameMarche = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBG = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboMarche = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgvMarche = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtmMarche = new System.Windows.Forms.DateTimePicker();
            this.btnAjouterMarch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEnregDetail = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ComboBoxMateriel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboMarche1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarche)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameMarche
            // 
            this.txtNameMarche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameMarche.DefaultText = "";
            this.txtNameMarche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameMarche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameMarche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMarche.DisabledState.Parent = this.txtNameMarche;
            this.txtNameMarche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameMarche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMarche.FocusedState.Parent = this.txtNameMarche;
            this.txtNameMarche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameMarche.HoverState.Parent = this.txtNameMarche;
            this.txtNameMarche.Location = new System.Drawing.Point(819, 25);
            this.txtNameMarche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameMarche.Name = "txtNameMarche";
            this.txtNameMarche.PasswordChar = '\0';
            this.txtNameMarche.PlaceholderText = "";
            this.txtNameMarche.SelectedText = "";
            this.txtNameMarche.ShadowDecoration.Parent = this.txtNameMarche;
            this.txtNameMarche.Size = new System.Drawing.Size(190, 36);
            this.txtNameMarche.TabIndex = 0;
            // 
            // txtBG
            // 
            this.txtBG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBG.DefaultText = "";
            this.txtBG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBG.DisabledState.Parent = this.txtBG;
            this.txtBG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBG.FocusedState.Parent = this.txtBG;
            this.txtBG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBG.HoverState.Parent = this.txtBG;
            this.txtBG.Location = new System.Drawing.Point(819, 71);
            this.txtBG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBG.Name = "txtBG";
            this.txtBG.PasswordChar = '\0';
            this.txtBG.PlaceholderText = "";
            this.txtBG.SelectedText = "";
            this.txtBG.ShadowDecoration.Parent = this.txtBG;
            this.txtBG.Size = new System.Drawing.Size(190, 36);
            this.txtBG.TabIndex = 1;
            // 
            // comboMarche
            // 
            this.comboMarche.BackColor = System.Drawing.Color.Transparent;
            this.comboMarche.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMarche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarche.FocusedColor = System.Drawing.Color.Empty;
            this.comboMarche.FocusedState.Parent = this.comboMarche;
            this.comboMarche.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboMarche.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboMarche.FormattingEnabled = true;
            this.comboMarche.HoverState.Parent = this.comboMarche;
            this.comboMarche.ItemHeight = 30;
            this.comboMarche.ItemsAppearance.Parent = this.comboMarche;
            this.comboMarche.Location = new System.Drawing.Point(766, 217);
            this.comboMarche.Name = "comboMarche";
            this.comboMarche.ShadowDecoration.Parent = this.comboMarche;
            this.comboMarche.Size = new System.Drawing.Size(299, 36);
            this.comboMarche.TabIndex = 3;
            this.comboMarche.SelectedIndexChanged += new System.EventHandler(this.comboMarche_SelectedIndexChanged);
            // 
            // dgvMarche
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMarche.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarche.BackgroundColor = System.Drawing.Color.White;
            this.dgvMarche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarche.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarche.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarche.EnableHeadersVisualStyles = false;
            this.dgvMarche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMarche.Location = new System.Drawing.Point(31, 284);
            this.dgvMarche.Name = "dgvMarche";
            this.dgvMarche.RowHeadersVisible = false;
            this.dgvMarche.RowTemplate.Height = 28;
            this.dgvMarche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarche.Size = new System.Drawing.Size(1856, 461);
            this.dgvMarche.TabIndex = 4;
            this.dgvMarche.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMarche.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMarche.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMarche.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMarche.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMarche.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMarche.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMarche.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMarche.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMarche.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMarche.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMarche.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMarche.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMarche.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvMarche.ThemeStyle.ReadOnly = false;
            this.dgvMarche.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMarche.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMarche.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvMarche.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMarche.ThemeStyle.RowsStyle.Height = 28;
            this.dgvMarche.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMarche.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMarche.Click += new System.EventHandler(this.dgvMarche_Click);
            // 
            // dtmMarche
            // 
            this.dtmMarche.Location = new System.Drawing.Point(757, 115);
            this.dtmMarche.Name = "dtmMarche";
            this.dtmMarche.Size = new System.Drawing.Size(299, 26);
            this.dtmMarche.TabIndex = 5;
            // 
            // btnAjouterMarch
            // 
            this.btnAjouterMarch.CheckedState.Parent = this.btnAjouterMarch;
            this.btnAjouterMarch.CustomImages.Parent = this.btnAjouterMarch;
            this.btnAjouterMarch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouterMarch.ForeColor = System.Drawing.Color.White;
            this.btnAjouterMarch.HoverState.Parent = this.btnAjouterMarch;
            this.btnAjouterMarch.Location = new System.Drawing.Point(819, 168);
            this.btnAjouterMarch.Name = "btnAjouterMarch";
            this.btnAjouterMarch.ShadowDecoration.Parent = this.btnAjouterMarch;
            this.btnAjouterMarch.Size = new System.Drawing.Size(190, 34);
            this.btnAjouterMarch.TabIndex = 6;
            this.btnAjouterMarch.Text = "Ajouter A Marche";
            this.btnAjouterMarch.Click += new System.EventHandler(this.btnAjouterMarch_Click);
            // 
            // btnEnregDetail
            // 
            this.btnEnregDetail.CheckedState.Parent = this.btnEnregDetail;
            this.btnEnregDetail.CustomImages.Parent = this.btnEnregDetail;
            this.btnEnregDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnregDetail.ForeColor = System.Drawing.Color.White;
            this.btnEnregDetail.HoverState.Parent = this.btnEnregDetail;
            this.btnEnregDetail.Location = new System.Drawing.Point(766, 768);
            this.btnEnregDetail.Name = "btnEnregDetail";
            this.btnEnregDetail.ShadowDecoration.Parent = this.btnEnregDetail;
            this.btnEnregDetail.Size = new System.Drawing.Size(299, 34);
            this.btnEnregDetail.TabIndex = 7;
            this.btnEnregDetail.Text = "Enregistrer Detail De Marche";
            this.btnEnregDetail.Click += new System.EventHandler(this.btnEnregDetail_Click);
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
            this.ComboBoxMateriel.Location = new System.Drawing.Point(351, 166);
            this.ComboBoxMateriel.Name = "ComboBoxMateriel";
            this.ComboBoxMateriel.ShadowDecoration.Parent = this.ComboBoxMateriel;
            this.ComboBoxMateriel.Size = new System.Drawing.Size(140, 26);
            this.ComboBoxMateriel.TabIndex = 8;
            this.ComboBoxMateriel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMateriel_SelectedIndexChanged);
            // 
            // comboMarche1
            // 
            this.comboMarche1.BackColor = System.Drawing.Color.Transparent;
            this.comboMarche1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMarche1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarche1.FocusedColor = System.Drawing.Color.Empty;
            this.comboMarche1.FocusedState.Parent = this.comboMarche1;
            this.comboMarche1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboMarche1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboMarche1.FormattingEnabled = true;
            this.comboMarche1.HoverState.Parent = this.comboMarche1;
            this.comboMarche1.ItemHeight = 20;
            this.comboMarche1.ItemsAppearance.Parent = this.comboMarche1;
            this.comboMarche1.Location = new System.Drawing.Point(351, 217);
            this.comboMarche1.Name = "comboMarche1";
            this.comboMarche1.ShadowDecoration.Parent = this.comboMarche1;
            this.comboMarche1.Size = new System.Drawing.Size(140, 26);
            this.comboMarche1.TabIndex = 9;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1096, 768);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(179, 34);
            this.guna2GradientButton1.TabIndex = 10;
            this.guna2GradientButton1.Text = "Imprimer Inventaire";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // FormGestionDeMarche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 818);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.comboMarche1);
            this.Controls.Add(this.ComboBoxMateriel);
            this.Controls.Add(this.btnEnregDetail);
            this.Controls.Add(this.btnAjouterMarch);
            this.Controls.Add(this.dtmMarche);
            this.Controls.Add(this.dgvMarche);
            this.Controls.Add(this.comboMarche);
            this.Controls.Add(this.txtBG);
            this.Controls.Add(this.txtNameMarche);
            this.Name = "FormGestionDeMarche";
            this.Text = "FormGestionDeMarche";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionDeMarche_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionDeMarche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNameMarche;
        private Guna.UI2.WinForms.Guna2TextBox txtBG;
        private Guna.UI2.WinForms.Guna2ComboBox comboMarche;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMarche;
        private System.Windows.Forms.DateTimePicker dtmMarche;
        private Guna.UI2.WinForms.Guna2GradientButton btnAjouterMarch;
        private Guna.UI2.WinForms.Guna2GradientButton btnEnregDetail;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxMateriel;
        private Guna.UI2.WinForms.Guna2ComboBox comboMarche1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}