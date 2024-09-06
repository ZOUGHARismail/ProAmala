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
    public partial class Form2 : Form
    {
        private Admin admin;
        public Form2(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }
        private void btnGesDeStock_Click(object sender, EventArgs e)
        {
            new FormGestionDeStock(this.admin).Show();
        }
        private void btnGesDeLocalite_Click(object sender, EventArgs e)
        {
            new FormGestionDeLocalite(this.admin).Show();
        }
        private void btnGesDeMarche_Click(object sender, EventArgs e)
        {
            new FormGestionDeMarche(this.admin).Show();
        }
        private void btnGesDeSortie_Click(object sender, EventArgs e)
        {
            new FormGesSortieInventaire(this.admin).Show();
        }
    }
}
