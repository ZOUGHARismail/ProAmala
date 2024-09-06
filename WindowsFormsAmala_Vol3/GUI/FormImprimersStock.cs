using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAmala_Vol3.GUI
{
    public partial class FormImprimersStock : Form
    {
        public FormImprimersStock()
        {
            InitializeComponent();
        }
        private void FormImprimersStock_Load(object sender, EventArgs e)
        {
            CrystalReportImprimerStock stock = new CrystalReportImprimerStock();
            crystalReportViewer1.ReportSource = stock;
        }
    }
}
