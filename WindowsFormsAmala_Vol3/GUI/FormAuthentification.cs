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
    public partial class FormAuthentification : Form
    {
        public FormAuthentification()
        {
            InitializeComponent();
        }

        private void btnAthentifier_Click(object sender, EventArgs e)
        {
            try
            {
                User u = new User(txtLogin.Text, txtPassword.Text);
                u.authentifier();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
