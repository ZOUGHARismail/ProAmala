using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAmala_Vol3.Models;

namespace WindowsFormsAmala_Vol3.GUI
{
    public partial class FormGestionDeMarche : Form
    {
        private Admin admin;
        public FormGestionDeMarche(Admin admin)
        {
            this.admin = admin;

            InitializeComponent();
        }

        private void FormGestionDeMarche_Load(object sender, EventArgs e)
        {
            this.comboMarche.DataSource = this.admin.chargerMarches();
            this.comboMarche.DisplayMember = this.admin.Marches.Columns[1].ColumnName;
            this.comboMarche.ValueMember = this.admin.Marches.Columns[0].ColumnName;
            
            this.comboMarche1.Visible = false;
            this.ComboBoxMateriel.Visible = false;
            this.ComboBoxMateriel.DataSource = this.admin.chargerProduit();
            this.ComboBoxMateriel.DisplayMember = this.admin.Produits.Columns[1].ColumnName;
            this.ComboBoxMateriel.ValueMember = this.admin.Produits.Columns[0].ColumnName;
        }
        private void btnAjouterMarch_Click(object sender, EventArgs e)
        {
            try
            {
                this.admin.AjouterMarche(txtNameMarche.Text, Int32.Parse(txtBG.Text),
                DateTime.Parse(dtmMarche.Value.ToString()));
                this.comboMarche.DataSource = this.admin.chargerMarches();
                this.comboMarche.DisplayMember = this.admin.Marches.Columns[1].ColumnName;
                this.comboMarche.ValueMember = this.admin.Marches.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void FormGestionDeMarche_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.admin.connection.Close();
        }
        
        private void btnEnregDetail_Click(object sender, EventArgs e)
        {
            try
            {
                this.admin.CurrentMarche.enregistrerDetail();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvMarche_Click(object sender, EventArgs e)
        {
            try
            {
                this.ComboBoxMateriel.Visible = true;
                Point p = this.dgvMarche.CurrentCell.ContentBounds.Location;
                ComboBoxMateriel.Width = this.dgvMarche.Columns[1].Width;
                p.X = 155 + p.X + this.dgvMarche.Location.X;
                p.Y = 18 + p.Y + this.dgvMarche.Location.Y + this.dgvMarche.CurrentRow.Height * this.dgvMarche.CurrentRow.Index;
                //MessageBox.Show("X="+p.X);
                //MessageBox.Show("Y=" + p.Y);
                // this.comboRaces.Size = this.dataGridViewChevaux.CurrentRow.Cells[2].Size;
                this.ComboBoxMateriel.SelectedValue = this.dgvMarche.CurrentRow.Cells[1].Value;
                this.ComboBoxMateriel.Location = p;

                this.comboMarche1.Visible = true;

                Point p1 = this.dgvMarche.CurrentCell.ContentBounds.Location;
                comboMarche1.Width = this.dgvMarche.Columns[0].Width;
                p1.X = 1 + p1.X + this.dgvMarche.Location.X;
                p1.Y = 18 + p1.Y + this.dgvMarche.Location.Y + this.dgvMarche.CurrentRow.Height * this.dgvMarche.CurrentRow.Index;
                //MessageBox.Show("X="+p.X);
                //MessageBox.Show("Y=" + p.Y);
                // this.comboRaces.Size = this.dataGridViewChevaux.CurrentRow.Cells[2].Size;
                this.comboMarche1.SelectedValue = this.dgvMarche.CurrentRow.Cells[0].Value;
                this.comboMarche1.Location = p1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }        
        }
        private void ComboBoxMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ComboBoxMateriel.SelectedValue is Int32)
                    this.dgvMarche.CurrentRow.Cells[1].Value = this.ComboBoxMateriel.SelectedValue;
                if (this.comboMarche1.SelectedValue is Int32)
                    this.dgvMarche.CurrentRow.Cells[0].Value = this.comboMarche.SelectedValue;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            new FormReportAll().Show();
        }

        private void comboMarche_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(this.comboTroupe.SelectedValue.ToString( ));
                if (this.comboMarche.SelectedValue is Int32)
                {
                    this.admin.CurrentMarche = new Marche(Int32.Parse(this.comboMarche.SelectedValue.ToString()));
                    this.dgvMarche.DataSource = this.admin.CurrentMarche.chargerDetail();
                    this.comboMarche1.DataSource = this.admin.CurrentMarche.CurrentMarcheDisplayMember();
                    this.comboMarche1.DisplayMember = this.admin.Marches.Columns[1].ColumnName;
                    this.comboMarche1.ValueMember = this.admin.Marches.Columns[0].ColumnName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
