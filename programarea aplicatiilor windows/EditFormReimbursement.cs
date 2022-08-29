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
    public partial class EditFormReimbursement : Form
    {
		#region Attributes
		private readonly Reimbursement _reimbursement;
		#endregion


		public EditFormReimbursement(Reimbursement reim)
		{
			
			InitializeComponent();
			_reimbursement = reim;
		}

        private void EditFormReimbursement_Load(object sender, EventArgs e)
        {
		    textBoxName.Text = _reimbursement.nameClient;
			dateTimeReimbursemetEdit.Value = _reimbursement.dateOfReimbursment;
        }

        private void btnOKEditReimbursment_Click(object sender, EventArgs e)
        {
			_reimbursement.nameClient= textBoxName.Text;
			_reimbursement.dateOfReimbursment = dateTimeReimbursemetEdit.Value;
		}
    }
}
