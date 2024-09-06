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
    public partial class FormGesSortieInventaire : Form
    {
        private Admin admin;
        public FormGesSortieInventaire(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void FormGesSortieInventaire_Load(object sender, EventArgs e)
        {
            this.ComboLocalite.DataSource = this.admin.chargerLocalite();
            this.ComboLocalite.DisplayMember = this.admin.Localites.Columns[1].ColumnName;
            this.ComboLocalite.ValueMember = this.admin.Localites.Columns[0].ColumnName;
            /////////////////////////////////////////////////
            this.ComboBoxLocalite.Visible = false;
            ////////////////////////////////////////////////
            this.ComboBoxMateriel.Visible = false;
            this.ComboBoxMateriel.DataSource = this.admin.chargerProduit();
            this.ComboBoxMateriel.DisplayMember = this.admin.Produits.Columns[1].ColumnName;
            this.ComboBoxMateriel.ValueMember = this.admin.Produits.Columns[0].ColumnName;

        }
        private void ComboLocalite_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(this.comboTroupe.SelectedValue.ToString( ));
                if (this.ComboLocalite.SelectedValue is Int32)
                {
                    this.admin.CurrentLocalite = new Localite(Int32.Parse(this.ComboLocalite.SelectedValue.ToString()));
                    this.dgvDelevery.DataSource = this.admin.CurrentLocalite.chargerDelevery();
                    this.ComboBoxLocalite.DataSource = this.admin.CurrentLocalite.CurrentLocaliteDisplayMember();
                    this.ComboBoxLocalite.DisplayMember = this.admin.Localites.Columns[1].ColumnName;
                    this.ComboBoxLocalite.ValueMember = this.admin.Localites.Columns[0].ColumnName;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvDelevery_Click(object sender, EventArgs e)
        {
            this.ComboBoxLocalite.Visible = true;
            Point p = this.dgvDelevery.CurrentCell.ContentBounds.Location;
            ComboBoxLocalite.Width = this.dgvDelevery.Columns[1].Width;
            p.X = 150 + p.X + this.dgvDelevery.Location.X;
            p.Y = 18 + p.Y + this.dgvDelevery.Location.Y + this.dgvDelevery.CurrentRow.Height * this.dgvDelevery.CurrentRow.Index;
            //MessageBox.Show("X="+p.X);
            //MessageBox.Show("Y=" + p.Y);
            // this.comboRaces.Size = this.dataGridViewChevaux.CurrentRow.Cells[2].Size;
            this.ComboBoxLocalite.SelectedValue = this.dgvDelevery.CurrentRow.Cells[1].Value;
            this.ComboBoxLocalite.Location = p;

            this.ComboBoxMateriel.Visible = true;
            Point p1 = this.dgvDelevery.CurrentCell.ContentBounds.Location;
            ComboBoxMateriel.Width = this.dgvDelevery.Columns[2].Width;
            p1.X = 384 + p1.X + this.dgvDelevery.Location.X;
            p1.Y = 18 + p1.Y + this.dgvDelevery.Location.Y + this.dgvDelevery.CurrentRow.Height * this.dgvDelevery.CurrentRow.Index;
            //MessageBox.Show("X="+p.X);
            //MessageBox.Show("Y=" + p.Y);
            // this.comboRaces.Size = this.dataGridViewChevaux.CurrentRow.Cells[2].Size;
            this.ComboBoxMateriel.SelectedValue = this.dgvDelevery.CurrentRow.Cells[2].Value;
            this.ComboBoxMateriel.Location = p1;
        }
        private void ComboBoxMateriel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ComboBoxMateriel.SelectedValue is Int32)
                    this.dgvDelevery.CurrentRow.Cells[2].Value = this.ComboBoxMateriel.SelectedValue;
                if (this.ComboBoxLocalite.SelectedValue is Int32)
                    this.dgvDelevery.CurrentRow.Cells[1].Value = this.ComboLocalite.SelectedValue;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private void btnEnregDelevery_Click(object sender, EventArgs e)
        {
            this.admin.CurrentLocalite.enregistrerDelevery();
        }

        private void btnAjouterLocalite_Click(object sender, EventArgs e)
        {

            txtLocalite.Visible = true;
            btnLocaliteOk.Visible = true;
        }

        private void btnLocaliteOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLocalite.Text.Length > 0)
                {
                    this.admin.AjouterLocalite(txtLocalite.Text);
                    this.admin.chargerLocalite();
                    txtLocalite.Visible = false;
                    btnLocaliteOk.Visible = false;
                }
                else
                {
                    MessageBox.Show("Localite Vide");
                    txtLocalite.Visible = false;
                    btnLocaliteOk.Visible = false;
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnImprimer_Click(object sender, EventArgs e)
        {
            string ville = this.admin.CurrentLocalite.LocaliteDisplayMember(Int32.Parse(ComboLocalite.SelectedValue.ToString()));
            new FormImprimerSortier(ville).Show();
            //MessageBox.Show(this.admin.CurrentLocalite.LocaliteDisplayMember
            //    (Int32.Parse(ComboLocalite.SelectedValue.ToString())));

        }

        private void FormGesSortieInventaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.admin.connection.Close();
        }
    }
}
