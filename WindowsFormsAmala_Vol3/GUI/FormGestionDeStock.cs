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
    public partial class FormGestionDeStock : Form
    {
        private Admin admin; 
        public FormGestionDeStock(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }
        private void FormGestionDeStock_Load(object sender, EventArgs e)
        {

            this.guna2DataGridView1.DataSource = this.admin.chargerProduit();
            this.guna2DataGridView1.Columns[0].Visible=false;
            this.guna2DataGridView1.Columns[2].Visible = false;
        }
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            new FormImprimersStock().Show();
        }
        private void btnUbdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.admin.enregistrerProduit();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormGestionDeStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.admin.connection.Close();
        }
    }
}
