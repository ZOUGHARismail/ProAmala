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
    public partial class FormImprimerSortier : Form
    {
        string VILLE;
        public FormImprimerSortier( string ville)
        {
            InitializeComponent();
            this.VILLE = ville;
        }

        private void FormImprimerSortier_Load(object sender, EventArgs e)
        {
            CrystalReportSortier cr = new CrystalReportSortier();
            cr.SetParameterValue("localite", VILLE);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
