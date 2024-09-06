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
    public partial class FormReportAll : Form
    {
        public FormReportAll()
        {
            InitializeComponent();
        }

        private void FormReportAll_Load(object sender, EventArgs e)
        {
            CrystalReportALL aLL = new CrystalReportALL();
            crystalReportViewer1.ReportSource = aLL;
        }
    }
}
