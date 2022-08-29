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
    public partial class EditFormClient : Form
    {
        #region Attributes
        private readonly Client _client;
        #endregion


        public EditFormClient(Client client)
        {
            
            InitializeComponent();
            _client = client;
        }
        private void EditForm_Load(object sender, System.EventArgs e)
        {
            textBoxNameEditForm.Text= _client.name;
            textBoxCNPEditForm.Text = _client.CNP.ToString();
            textBoxPhoneEditForm.Text = _client.phoneNumber.ToString();
            textBoxMaritalStatusEditForm.Text = _client.Status.ToString();
            textBoxNoKidsEditForm.Text = _client.noKids.ToString();
        }
        
        private void tbEditFormName_Click(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
           

            _client.name = textBoxNameEditForm.Text;
            _client.CNP = int.Parse(textBoxCNPEditForm.Text);
            _client.phoneNumber = int.Parse(textBoxPhoneEditForm.Text);
            _client.Status = (maritalStatus)Enum.Parse(typeof(maritalStatus), textBoxMaritalStatusEditForm.Text, true);
            _client.noKids = int.Parse(textBoxNoKidsEditForm.Text);
         

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void EditFormClient_Load(object sender, EventArgs e)
        {

        }
    }
}
