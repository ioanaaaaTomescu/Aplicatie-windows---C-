using Microsoft.Data.Sqlite;
using PROIECT_WAP_VARIANTA2.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_WAP_VARIANTA2
{ [Serializable]
    public partial class FormReimbursement : Form
    {  // private readonly List<Reimbursement> reimbursements;
        private string connectionString = "Data Source=database.db";
        private readonly MainFormNewModelcs viewModel;
        string path = Environment.CurrentDirectory + "/" + "data_Reimbursements.txt";
        int _currentReimbursementIndex;
        public FormReimbursement()
        {
            InitializeComponent();
            //reimbursements = new List<Reimbursement>();
            viewModel = new MainFormNewModelcs();
         
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }                                                    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        private void textBoxNameR_Validating(object sender, CancelEventArgs e)
        {
            string name = textBoxNameR.Text.Trim();
            if (name.Length < 2)
            {
                errorProvider1.SetError(textBoxNameR, "The name is too short!!!");
                e.Cancel = true;
            }
        }
        private void textBoxNameR_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(textBoxNameR, null);

        }

        private void textBoxNameR_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode.ToString() == "R")
            {
                MessageBox.Show("Register a new reimbursement");
            }
        }

        private void btFileFormReimbursement_Click(object sender, EventArgs e)
        {

        }

        private void btnSerializeReimbursementForm_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using(FileStream stream = File.Create("serializedReimbursement.bin"))
            {

            }
        }

        private void buttonAddReimbusment_Click(object sender, EventArgs e)
        {
            //if (!ValidateChildren())
            //{
            //    MessageBox.Show("The form containd=s errors!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string name = textBoxNameR.Text.Trim();
            ////float interest = float.Parse(textBox1.Text);
            //DateTime date = dateTimeReimbusement.Value;
            //Reimbursement r= new Reimbursement(name,date);
            //reimbursements.Add(r);
            //DisplayReimbursments();

            string name = textBoxNameR.Text;

            DateTime date = dateTimeReimbusement.Value;
            try
            {
                var reimbur = new Reimbursement(name, date);

            }
            catch (InvalidReimburmsentDate ex)
            {

                MessageBox.Show(string.Format("The  date {0} is invalid!", ex.reimbursmentDate));
            }
            catch (Exception)
            {

                MessageBox.Show("An exception has been encountered! Please contact the technical support.");


            }
            finally
            {
                Debug.WriteLine("Always executed");
            }
            try
            {
                var reim = new Reimbursement(name, date);

            }
            catch (InvalidInterestDate excep)
            {

                MessageBox.Show(string.Format("The  interest {0} is invalid!", excep.interest));
            }
            catch (Exception)
            {

                MessageBox.Show("An exception has been encountered! Please contact the technical support.");


            }
            finally
            {
                Debug.WriteLine("Always executed");
            }
            var r = new Reimbursement(name, date);
            viewModel.Reimbursement.Add(r);
            //AddReimbursmentDatabase(r);
            DisplayReimbursments();


            //viewModel.AddReimbursment();
           // DisplayReimbursments();


        }

        private void DisplayReimbursments()
        {
           dgvReimbursements.Rows.Clear();

			foreach (Reimbursement r in viewModel.Reimbursement)
            { 

				int rowIndex = dgvReimbursements.Rows.Add(
                    new object[] {
                        r.nameClient,
                        r.dateOfReimbursment
                    });
              dgvReimbursements.Rows[rowIndex].Tag = r;
			}
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            BinaryFormatter bin = new BinaryFormatter();
            using (FileStream stream = File.Create("serialized_Reimbursement.bin"))
            {
                bin.Serialize(stream, viewModel.Reimbursement);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter binarry = new BinaryFormatter();
            using (FileStream stream = File.OpenRead("deserialize_Reimbursement.bin"))
            {
                //viewModel.Reimbursement = (List<Reimbursement>)binarry.Deserialize(stream);
                DisplayReimbursments();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Name,Reimbursment date");

                    foreach (var r in viewModel.Reimbursement)
                    {
                        sw.WriteLine("\"{0}\", \"{1}\""
                                    , r.nameClient.Replace("\"", "\"\"")
                                    , r.dateOfReimbursment.ToShortDateString());
                    }
                }
            }
        }

        private void btnCreateNewFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
            {
                File.CreateText(path);
                MessageBox.Show("File sucessfully created!");
            }
        }

        private void listViewReimbursement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void dateTimeReimbusement_Validating(object sender, CancelEventArgs e)
        //{
        //    DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        //    if (dateTimeReimbusement.Value < date)
        //    {
        //        errorProviderDateReimbursement.SetError(dateTimeReimbusement, "You cannot insert a date which is in the past...think about the future!");
        //        e.Cancel = true;

        //    }

        //}

        //private void dateTimeReimbusement_Validated(object sender, EventArgs e)
        //{
        //    errorProviderDateReimbursement.SetError(dateTimeReimbusement, null);
        //}

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //if (listViewReimbursement.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Choose a client");
            //    return;
            //}
            //if (MessageBox.Show("Are you sure?", "Delete participant", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    foreach (ListViewItem eachItem in listViewReimbursement.SelectedItems)
            //    {
            //        listViewReimbursement.Items.Remove(eachItem);
            //    }
            //}

            //if (dgvReimbursements.SelectedRows.Count == 0)
            //{
            //    MessageBox.Show("Choose a row!");
            //    return;

            //}

            //DataGridViewRow row = dgvReimbursements.SelectedRows[0];
            //Reimbursement reimbursement = (Reimbursement)row.DataBoundItem;
            //viewModel.Reimbursement.Remove(reimbursement);
            //DisplayReimbursments();
            //if(lvParticipants.SelectedItems.Count == 0)
            if (dgvReimbursements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a reimbursment!");
                return;
            }

            if (MessageBox.Show(
                "Are you sure?",
                "Delete participant",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                //ListViewItem listViewItem = lvParticipants.SelectedItems[0];
                DataGridViewRow dataGridViewRow = dgvReimbursements.SelectedRows[0];

                //Participant participant = (Participant)listViewItem.Tag;
                Reimbursement r = (Reimbursement)dataGridViewRow.Tag;

                // viewModel.Reimbursement.Remove(r);
                viewModel.DeleteReimbursment(r);
                DisplayReimbursments();
            }


        }

        private void buttonUpdateReimbursement_Click(object sender, EventArgs e)
        {
            //if (listViewReimbursement.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Choose a field");
            //    return;
            //}

            //EditFormReimbursement editForm = new EditFormReimbursement((Reimbursement)listViewReimbursement.SelectedItems[0].Tag);
            //if (editForm.ShowDialog() == DialogResult.OK)
            //    DisplayReimbursments();


            //if (listViewReimbursement.SelectedItems.Count == 0)
            //{
            //    MessageBox.Show("Choose a field!");
            //    return;
            //}

            //ListViewItem listViewItem = listViewReimbursement.SelectedItems[0];
            //Reimbursement r = (Reimbursement)listViewItem.Tag;


            //EditFormReimbursement editForm = new EditFormReimbursement(r);
            //if (editForm.ShowDialog() == DialogResult.OK)
            //{
            //    DisplayReimbursments();
            //}
            //if(lvParticipants.SelectedItems.Count == 0)
            if (dgvReimbursements.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a row!");
                return;
            }

            //ListViewItem listViewItem = lvParticipants.SelectedItems[0];
            DataGridViewRow dataGridViewRow = dgvReimbursements.SelectedRows[0];

            //Participant participant = (Participant)listViewItem.Tag;
            Reimbursement r = (Reimbursement)dataGridViewRow.Tag;

            EditFormReimbursement editForm = new EditFormReimbursement(r);

            if (editForm.ShowDialog() == DialogResult.OK)
                DisplayReimbursments();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReimbursement_Load(object sender, EventArgs e)
        {
           // dgvReimbursements.DataSource =viewModel.Reimbursement ;
            textBoxNameR.DataBindings.Add("Text",viewModel, "_name");
            dateTimeReimbusement.DataBindings.Add("Value", viewModel, "rDate");
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // int _currentReimbursementIndex = 0;
           // Initialize the font to be used for printing.
           Font font = new Font("Microsoft Sans Serif", 24);

            var pageSettings = e.PageSettings;

            // Initialize local variables that contain the bounds of the printing area rectangle.
            //var printAreaHeight = pageSettings.PaperSize.Height - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            //or
            var printAreaHeight = e.MarginBounds.Height;

            //var printAreaWidth = pageSettings.PaperSize.Width - pageSettings.Margins.Left - pageSettings.Margins.Right;
            //or
            var printAreaWidth = e.MarginBounds.Width;

            // Initialize local variables to hold margin values that will serve
            // as the X and Y coordinates for the upper left corner of the printing 
            // area rectangle.
            var marginLeft = pageSettings.Margins.Left;
            // X coordinate
            var marginTop = pageSettings.Margins.Top;
            // Y coordinate

            // If the user selected Landscape mode, swap the printing area height 
            // and width.
            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            // Instantiate the StringFormat class, which encapsulates text layout 
            // information (such as alignment and line spacing), display manipulations 
            // (such as ellipsis insertion and national digit substitution) and OpenType 
            // features. Use of StringFormat causes MeasureString and DrawString to use
            // only an integer number of lines when printing each page, ignoring partial
            // lines that would otherwise likely be printed if the number of lines per 
            // page do not divide up cleanly for each page (which is usually the case).
            // See further discussion in the SDK documentation about StringFormatFlags.
            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_currentReimbursementIndex < viewModel.Reimbursement.Count)
            {
                //Reset the horizontal drawing coordinate
                var currentX = marginLeft;

                //Draw the border of the cell
                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                //Draw the text in the cell
                /*e.Graphics.DrawString(
                    _participants[i].FirstName,
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);*/
                // By specifying a LayoutRectangle, we are forcing the text into a specific area, with automatic word wrapping and other features controllable through the StringFormat parameter
                e.Graphics.DrawString(
                    viewModel.Reimbursement[_currentReimbursementIndex].nameClient,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                //Update the horizontal drawing coordinate
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                    viewModel.Reimbursement[_currentReimbursementIndex].reimbursmentDATE.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                //e.Graphics.DrawString(
                //    _participants[_currentParticipantIndex].BirthDate.ToShortDateString(),
                //    font,
                //    Brushes.Black,
                //    currentX,
                //    currentY,
                //    fmt);

                //Update the participant index
                _currentReimbursementIndex++;
                //Update the vertifcal drawing coordinate
                currentY += rowHeight;

                // HasMorePages tells the printing module whether another PrintPage event should be fired.
                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _currentReimbursementIndex = 0;
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        //public void AddReimbursment(Reimbursement re)
        //{
        //    string query = "INSERT INTO Reimbursment(Name, Reimbursment_date) VALUES(@name, @date); SELECT last_insert_rowid();";
        //    using (SqliteConnection connection = new SqliteConnection(connectionString))
        //    {
        //        SqliteCommand command = new SqliteCommand(query, connection);
        //        command.Parameters.AddWithValue("@name", viewModel.Namereimbursment);
        //        command.Parameters.AddWithValue("@date", viewModel.rDate);
        //        connection.Open();
        //        long Id= (long)command.ExecuteScalar();
                 

        //    }
        //}

        public void AddReimbursmentDatabase(Reimbursement r)
        {
            string query = "INSERT INTO Reimbursments(Id,Name,ReimbursmentDate) VALUES( @id, @name, @reimbursmentDate); SELECT last_insert_rowid();";
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                SqliteCommand command = new SqliteCommand(query, connection);
                //command.Parameters.AddWithValue("@id", r.i);
                command.Parameters.AddWithValue("@name", r.nameClient);
                command.Parameters.AddWithValue("@reimbursmentDate", r.reimbursmentDATE);
                
                long id = (long)command.ExecuteScalar();
                r.Id = id;
                viewModel.Reimbursement.Add(r);


            }


        }
    }
}
