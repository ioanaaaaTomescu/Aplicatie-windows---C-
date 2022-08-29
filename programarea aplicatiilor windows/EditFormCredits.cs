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
    public partial class EditFormCredits : Form
    {
        private readonly Credit _credit;
        public EditFormCredits(Credit credit)
        {
            InitializeComponent();
            _credit = credit;

        }

      

        private void EditFormCredits_Load(object sender, EventArgs e)
        {
            textBoxClientNameEdit.Text = _credit.name;
            textBoxEmployeeNameEdit.Text = _credit.employeeName;
            textBoxCNPClientEdit.Text = _credit.CNP.ToString();
            textBoxCreditIDEdit.Text = _credit.idCredit.ToString();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            _credit.name = textBoxClientNameEdit.Text;
            _credit.employeeName = textBoxEmployeeNameEdit.Text;
            _credit.CNP = int.Parse(textBoxCNPClientEdit.Text);
            _credit.idCredit = int.Parse(textBoxCreditIDEdit.Text);

        }
    }
}
