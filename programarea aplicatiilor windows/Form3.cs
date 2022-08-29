using System;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_WAP_VARIANTA2
{
    public partial class FormCredit : Form
    {
        private const string ConnectionString = "Data Source=databaseProject.db";
        private List<Credit> credits;
        public FormCredit()
        {
            InitializeComponent();
            credits = new List<Credit>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelClientName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxClientName_Validating(object sender, CancelEventArgs e)
        {
            string name = textBoxClientName.Text.Trim();
            if (name.Length < 2)
            {
                errorProviderClientCredit.SetError(textBoxClientName, "The name is too short!!!");
                e.Cancel = true;
            }
        }

        private void textBoxClientName_Validated(object sender, EventArgs e)
        {
            errorProviderClientCredit.SetError(textBoxClientName, null);
        }
        private void textBoxEmployeeName_Validating(object sender, CancelEventArgs e)
        {
            string name = textBoxEmployeeName.Text.Trim();
            if (name.Length < 2)
            {
                errorProviderEmployeeName.SetError(textBoxEmployeeName, "The name is too short!!!");
                e.Cancel = true;
            }
        }
        private void textBoxEmployeeName_Validated(object sender, EventArgs e)
        {
            errorProviderEmployeeName.SetError(textBoxEmployeeName, null);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string client = textBoxClientName.Text.Trim();
            string employee = textBoxEmployeeName.Text.Trim();
            int cnp = int.Parse(textBoxCNPCredit.Text);
            int accountNo = int.Parse(textBoxAccountNumber.Text);
            int id = int.Parse(textBoxCreditId.Text);
            Credit c = new Credit(client, employee, cnp, accountNo, id);
            //credits.Add(c);
            AddCredit(c);
            DisplayCredits();



        }

        public void DisplayCredits()
        {
            //listViewCredits.Items.Clear();
            //foreach(Credit c in credits)
            //{
            //    ListViewItem item = new ListViewItem(c.name);
            //    item.SubItems.Add(c.employeeName);
            //    item.SubItems.Add(c.CNP.ToString());
            //    item.SubItems.Add(c.idCredit.ToString());
            //    //item.SubItems.Add(c.accountNumber.ToString());
            //    listViewCredits.Tag = c;
            //    listViewCredits.Items.Add(item);
            //}
            listViewCredits.Items.Clear();

            foreach (Credit c in credits)
            {
                var listViewItem = new ListViewItem(c.name);
                listViewItem.SubItems.Add(c.employeeName);
                listViewItem.SubItems.Add(c.CNP.ToString());
                listViewItem.SubItems.Add(c.phoneNumber.ToString());

                listViewItem.Tag = c;

                listViewCredits.Items.Add(listViewItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewCredits.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a client");
                return;
            }
            if (MessageBox.Show("Are you sure?", "Delete client", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    foreach (ListViewItem eachItem in listViewCredits.SelectedItems)
            //    {
            //        listViewCredits.Items.Remove(eachItem);
            //    }
            //}
            {
                try
                {
                    ListViewItem selectedItem = listViewCredits.SelectedItems[0];
                    Credit credit = (Credit)selectedItem.Tag;

                    DeleteCredits(credit);

                    DisplayCredits();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewCredits.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a field!");
                return;
            }

            ListViewItem listViewItem = listViewCredits.SelectedItems[0];
            Credit credits = (Credit)listViewItem.Tag;

            EditFormCredits editForm = new EditFormCredits(credits);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                UpdateCredits(credits);
                DisplayCredits();
            }
        }

        private void FormCredit_Load(object sender, EventArgs e)
        {
      
            LoadCredits();
            DisplayCredits();

        }

        private void binarySerializationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExportAsATextFileCredit_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Client name,Employee name,CNP client,credit ID");

                    foreach (var c in credits)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\",\"{3}\""
                                    , c.name.Replace("\"", "\"\"")
                                    , c.employeeName.Replace("\"", "\"\"")
                                    , c.CNP.ToString().Replace("\"","\"\"")
                                    , c.idCredit.ToString());
                    }
                }
            }
        }

         private void AddCredit(Credit cred)
        {
            var queryString = "insert into Credits(ClientName, EmployeeName, CNPClient,CreditId)" +
                        " values(@clientname,@employeename,@cnpclient,@creditid);  " +
                        "SELECT last_insert_rowid()";

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                //1. Add the new participant to the database
                var command = new SqliteCommand(queryString, connection);
                command.Parameters.AddWithValue("@clientname", cred.name);
                command.Parameters.AddWithValue("@employeename", cred.employeeName);
                command.Parameters.AddWithValue("@cnpclient", cred.CNP);
                command.Parameters.AddWithValue("@creditid", cred.idCredit);

                cred.Id = (long)command.ExecuteScalar();

                //2. Add the new participants to the local collection
                credits.Add(cred);
            }
        }
        private void LoadCredits()
        {
            const string stringSql = "SELECT * FROM Credits";

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SqliteCommand(stringSql, connection);

                using (SqliteDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        long id = (long)sqlReader["Id"];
                        string cname = (string)sqlReader["ClientName"];
                        string ename = (string)sqlReader["EmployeeName"];
                        int cnp = int.Parse(sqlReader["CNPClient"].ToString());
                        int creditid = int.Parse(sqlReader["CreditId"].ToString());

                        Credit credit = new Credit(id, cname, ename, cnp,creditid);
                        credits.Add(credit);
                    }
                }
            }
        }

        private void DeleteCredits(Credit cred)
        {
             string stringSql = "DELETE FROM Credits WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();

               
                SqliteCommand command = new SqliteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@id", cred.Id);

                command.ExecuteNonQuery();

                credits.Remove(cred);
            }
        }

        private void UpdateCredits(Credit credit)
        {
            string query = "UPDATE Credits SET ClientName=@namec, EmployeeName=@namee, CNPClient=@Cnp, CreditId=@creditid WHERE Id=@id;";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@namec", credit.name );
                command.Parameters.AddWithValue("@namee", credit.employeeName);
                command.Parameters.AddWithValue("@Cnp", credit.employeeName);
                command.Parameters.AddWithValue("@creditid", credit.idCredit);
                command.Parameters.AddWithValue("@id", credit.Id);
                connection.Open();
                command.ExecuteNonQuery();


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormReimbursement rFe = new FormReimbursement();
            rFe.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm w = new WelcomeForm();
            w.ShowDialog();
        }
    }
}

