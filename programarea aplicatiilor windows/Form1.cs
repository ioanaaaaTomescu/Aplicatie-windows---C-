using Microsoft.Data.Sqlite;
using PROIECT_WAP_VARIANTA2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_WAP_VARIANTA2
{
    public partial class FormClient : Form
    {
        private List<Client> clients;
        //private MainFormViewModel viewModel;
        private const string ConnectionString = "Data Source=databaseProject.db";
        public FormClient()
        {
            InitializeComponent();
           clients = new List<Client>();
          // viewModel = new MainFormViewModel();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!,", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textBoxName.Text.Trim();
            int CNP = int.Parse(textBoxCNP.Text);
            double phone = double.Parse(textBoxphoneNumber.Text);
            maritalStatus status =(maritalStatus) Enum.Parse(typeof(maritalStatus), textBoxMaritalStatus.Text,true);
            int kids = int.Parse(textBoxnoKids.Text);
            Client client = new Client(name, status, kids, CNP, phone);
            //clients.Add(client);
            AddClient(client);
            DisplayClients();
            //viewModel.addClient();

        }

        private void DisplayClients()
        {
            listViewClients.Items.Clear();

            foreach (Client client in clients)
            {
                var listViewItem = new ListViewItem(client.name);
                listViewItem.SubItems.Add(client.CNP.ToString());
                listViewItem.SubItems.Add(client.phoneNumber.ToString());

                listViewItem.Tag = client;

                listViewClients.Items.Add(listViewItem);
            }
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            //textBoxName.DataBindings.Add("Text", viewModel, "name");
            //textBoxCNP.DataBindings.Add("Text", viewModel, nameof(MainFormViewModel.CNP));
            //textBoxphoneNumber.DataBindings.Add("Text", viewModel, nameof(MainFormViewModel.phone));
            toolStripStatusLabel1.BackColor = Color.Pink;
            LoadClient();
            DisplayClients();

        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_VisibleChanged(object sender, EventArgs e)
        {

        }

       

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            string name = textBoxName.Text.Trim();
            if (name.Length < 2)
            {
                errorProvider1.SetError(textBoxName, "The name is too short!!!");
                e.Cancel = true;
            }

        }

        private void textBoxName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxName, null);
        }
        private void textBoxnoKids_Validating(object sender, CancelEventArgs e)
        {
            int numberKids = int.Parse(textBoxnoKids.Text);
            if (numberKids < 0)
            {
                errorProviderNoKids.SetError(textBoxnoKids, "Come on!!!Insert a number at least equal with 0");
                e.Cancel = true;
            }
        }
        private void textBoxnoKids_Validated(object sender, EventArgs e)
        {
            errorProviderNoKids.SetError(textBoxnoKids, null);

        }

        private void FormClient_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode.ToString() == "A")
            {
                MessageBox.Show("Hello!Welcome to our bank, please register!");
            }
        }

        private void serializedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter b = new BinaryFormatter();
            //using iDisposable , we ca use an using block :))
            using (FileStream stream = File.Create("serialized.bin"))//it is converting to  a try->finally
            {
                b.Serialize(stream, clients);
            }
        }

        private void desearlizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter f = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("serialized.bin"))
            {
                clients=(List<Client>)f.Deserialize(stream);
                DisplayClients();
            }
        }

        private void serializationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
         private void updateListClient()
        {
            listViewClients.SelectedItems[1].SubItems[0].Text = textBoxName.Text;
            listViewClients.SelectedItems[1].SubItems[1].Text = textBoxCNP.ToString();
            listViewClients.SelectedItems[1].SubItems[2].Text = textBoxphoneNumber.ToString();
            //clear txt
            textBoxName.Text = "";
            textBoxCNP.Text = "";
            textBoxphoneNumber.Text = "";

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a client");
                return;
            }
            
            if (MessageBox.Show("Are you sure?", "Delete row", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{//{
            // //    clients.Remove((Client)listViewClients.SelectedItems[0].Tag);
            // //    DisplayClients();
            // //}
            // //foreach (ListViewItem eachItem in listViewClients.SelectedItems)
            // // {
            // //listViewClients.Items.Remove(eachItem);
            // // }

            //    ListViewItem listViewItem = listViewClients.SelectedItems[0];
            //    Client client = (Client)listViewClients.Tag;
            //    deleteClient(client);
            //    DisplayClients();

            //}
            {
                try
                {
                    ListViewItem selectedItem = listViewClients.SelectedItems[0];
                    Client client = (Client)selectedItem.Tag;

                    deleteClient(client);

                    DisplayClients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void deleteFromTheList()
        {
            if(MessageBox.Show("Are you sure you want to delete?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listViewClients.Items.RemoveAt(listViewClients.SelectedIndices[0]);
            }
            textBoxName.Text = "";
            textBoxCNP.Text = "";
            textBoxphoneNumber.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose a client!");
                return;
            }

            ListViewItem listViewItem = listViewClients.SelectedItems[0];
            Client client = (Client)listViewItem.Tag;

            EditFormClient editForm = new EditFormClient(client);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                UpdateClient(client);
                DisplayClients();
            }
        }

        private void btnTextFileClientForm_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Name,CNP,Phone number");

                    foreach (var client in clients)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\""
                                    , client.name.Replace("\"", "\"\"")
                                    , client.CNP.ToString().Replace("\"", "\"\"")
                                    , client.phoneNumber.ToString());
                    }
                }
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the name of the client";
        }

        private void textBoxName_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxCNP_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the CNP";
        }

        private void buttonAddNewClient_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Click to add a new client";
        }

        private void buttonAddNewClient_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxphoneNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxphoneNumber_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the phone number of the client";
        }

        private void textBoxphoneNumber_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxMaritalStatus_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose: single, married or serious_relationship";
        }

        private void textBoxMaritalStatus_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void textBoxnoKids_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter the number of kids of the client.";
        }

        private void textBoxnoKids_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void buttonDelete_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Delete the client";
        }

        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Edit the selected client";
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void AddClient(Client c)
        {
            string query = "INSERT INTO Clients(Name,CNP,PhoenNo) VALUES(@name, @cnp,@phone); SELECT last_insert_rowid();";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@name", c.name);
                command.Parameters.AddWithValue("@cnp", c.CNP);
                command.Parameters.AddWithValue("@phone", c.phoneNumber);
                connection.Open();
                long id=(long)command.ExecuteScalar();
                c.Id = id;
                clients.Add(c);
            }


        }
        private void LoadClient()
        {
            string query = "SELECT * FROM Clients";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long Id = (long)reader["Id"];
                        string Name = (string)reader["Name"];
                         int cnp = int.Parse(reader["CNP"].ToString());
                         double phoneno = double.Parse(reader["PhoenNo"].ToString());
                        Client c = new Client(Id, Name,cnp, phoneno);
                        clients.Add(c);
                    }
                }
            }
        }

        private void deleteClient(Client client)
        {
            string stringSql = "DELETE FROM Clients WHERE Id=@id";

            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                connection.Open();


                SqliteCommand command = new SqliteCommand(stringSql, connection);
                command.Parameters.AddWithValue("@id", client.Id);

                command.ExecuteNonQuery();

                clients.Remove(client);
            }
        }
        private void UpdateClient(Client client)
        {
            string query = "UPDATE Clients SET Name=@name, CNP=@CnP, PhoenNo=@phone WHERE Id=@id;";
            using (SqliteConnection connection = new SqliteConnection(ConnectionString))
            {
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@name", client.name);
                command.Parameters.AddWithValue("@CnP", client.CNP);
                command.Parameters.AddWithValue("@phone", client.phoneNumber);
                command.Parameters.AddWithValue("@id", client.Id);
                connection.Open();
                command.ExecuteNonQuery();


            }
        }
    }
}
