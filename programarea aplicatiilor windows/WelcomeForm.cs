using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_WAP_VARIANTA2
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormClient  fClient = new FormClient();
            fClient.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCredit fCredit = new FormCredit();
            fCredit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormReimbursement fReimbursement = new FormReimbursement();
            fReimbursement.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormChart fChart = new FormChart();
            fChart.ShowDialog();
        }
    }
}
