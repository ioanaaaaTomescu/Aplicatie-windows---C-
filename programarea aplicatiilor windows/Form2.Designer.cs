
namespace PROIECT_WAP_VARIANTA2
{
    partial class FormReimbursement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReimbursement));
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameR = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimeReimbusement = new System.Windows.Forms.DateTimePicker();
            this.buttonAddReimbusment = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateReimbursement = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFileReimbursementForm = new System.Windows.Forms.ToolStripDropDownButton();
            this.binarySerializationReimbursementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeReimbursementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeBtnReimbursementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenReimbursementForm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderDateReimbursement = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvReimbursements = new System.Windows.Forms.DataGridView();
            this.nameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfReimbursment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateReimbursement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReimbursements)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.Color.MistyRose;
            this.Name.Location = new System.Drawing.Point(24, 63);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 17);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name ";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set interest rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose the reimbursement date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxNameR
            // 
            this.textBoxNameR.BackColor = System.Drawing.Color.MistyRose;
            this.textBoxNameR.Location = new System.Drawing.Point(72, 63);
            this.textBoxNameR.Name = "textBoxNameR";
            this.textBoxNameR.Size = new System.Drawing.Size(165, 22);
            this.textBoxNameR.TabIndex = 3;
            this.textBoxNameR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNameR_KeyDown);
            this.textBoxNameR.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNameR_Validating);
            this.textBoxNameR.Validated += new System.EventHandler(this.textBoxNameR_Validated);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.Location = new System.Drawing.Point(358, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 22);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimeReimbusement
            // 
            this.dateTimeReimbusement.CalendarForeColor = System.Drawing.Color.MistyRose;
            this.dateTimeReimbusement.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateTimeReimbusement.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dateTimeReimbusement.CalendarTitleForeColor = System.Drawing.Color.MistyRose;
            this.dateTimeReimbusement.CalendarTrailingForeColor = System.Drawing.Color.MistyRose;
            this.dateTimeReimbusement.Location = new System.Drawing.Point(240, 107);
            this.dateTimeReimbusement.Name = "dateTimeReimbusement";
            this.dateTimeReimbusement.Size = new System.Drawing.Size(244, 22);
            this.dateTimeReimbusement.TabIndex = 5;
            // 
            // buttonAddReimbusment
            // 
            this.buttonAddReimbusment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAddReimbusment.BackgroundImage")));
            this.buttonAddReimbusment.Location = new System.Drawing.Point(41, 147);
            this.buttonAddReimbusment.Name = "buttonAddReimbusment";
            this.buttonAddReimbusment.Size = new System.Drawing.Size(177, 33);
            this.buttonAddReimbusment.TabIndex = 6;
            this.buttonAddReimbusment.Text = "Add new reimbursement";
            this.buttonAddReimbusment.UseVisualStyleBackColor = true;
            this.buttonAddReimbusment.Click += new System.EventHandler(this.buttonAddReimbusment_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDelete.BackgroundImage")));
            this.buttonDelete.Location = new System.Drawing.Point(246, 147);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(223, 33);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete reimbursement";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdateReimbursement
            // 
            this.buttonUpdateReimbursement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdateReimbursement.BackgroundImage")));
            this.buttonUpdateReimbursement.Location = new System.Drawing.Point(27, 201);
            this.buttonUpdateReimbursement.Name = "buttonUpdateReimbursement";
            this.buttonUpdateReimbursement.Size = new System.Drawing.Size(442, 37);
            this.buttonUpdateReimbursement.TabIndex = 8;
            this.buttonUpdateReimbursement.Text = "Update/Change the reimbursement";
            this.buttonUpdateReimbursement.UseVisualStyleBackColor = true;
            this.buttonUpdateReimbursement.Click += new System.EventHandler(this.buttonUpdateReimbursement_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(27, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Serialize in binary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(166, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Deserialize in binary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(318, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Export as a text file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFileReimbursementForm});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 27);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFileReimbursementForm
            // 
            this.btnFileReimbursementForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFileReimbursementForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binarySerializationReimbursementForm,
            this.btnOpenReimbursementForm,
            this.btnCreateNewFile,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.btnFileReimbursementForm.Image = ((System.Drawing.Image)(resources.GetObject("btnFileReimbursementForm.Image")));
            this.btnFileReimbursementForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFileReimbursementForm.Name = "btnFileReimbursementForm";
            this.btnFileReimbursementForm.Size = new System.Drawing.Size(46, 24);
            this.btnFileReimbursementForm.Text = "File";
            // 
            // binarySerializationReimbursementForm
            // 
            this.binarySerializationReimbursementForm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeReimbursementForm,
            this.deserializeBtnReimbursementForm});
            this.binarySerializationReimbursementForm.Name = "binarySerializationReimbursementForm";
            this.binarySerializationReimbursementForm.Size = new System.Drawing.Size(232, 26);
            this.binarySerializationReimbursementForm.Text = "Binary Serialization";
            // 
            // btnSerializeReimbursementForm
            // 
            this.btnSerializeReimbursementForm.Name = "btnSerializeReimbursementForm";
            this.btnSerializeReimbursementForm.Size = new System.Drawing.Size(165, 26);
            this.btnSerializeReimbursementForm.Text = "Serialize";
            this.btnSerializeReimbursementForm.Click += new System.EventHandler(this.btnSerializeReimbursementForm_Click);
            // 
            // deserializeBtnReimbursementForm
            // 
            this.deserializeBtnReimbursementForm.Name = "deserializeBtnReimbursementForm";
            this.deserializeBtnReimbursementForm.Size = new System.Drawing.Size(165, 26);
            this.deserializeBtnReimbursementForm.Text = "Deserialize";
            // 
            // btnOpenReimbursementForm
            // 
            this.btnOpenReimbursementForm.Name = "btnOpenReimbursementForm";
            this.btnOpenReimbursementForm.Size = new System.Drawing.Size(232, 26);
            this.btnOpenReimbursementForm.Text = "Open";
            // 
            // btnCreateNewFile
            // 
            this.btnCreateNewFile.Name = "btnCreateNewFile";
            this.btnCreateNewFile.Size = new System.Drawing.Size(232, 26);
            this.btnCreateNewFile.Text = "Create a new text file";
            this.btnCreateNewFile.Click += new System.EventHandler(this.btnCreateNewFile_Click);
            // 
            // errorProviderDateReimbursement
            // 
            this.errorProviderDateReimbursement.ContainerControl = this;
            // 
            // dgvReimbursements
            // 
            this.dgvReimbursements.AllowUserToOrderColumns = true;
            this.dgvReimbursements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReimbursements.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvReimbursements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReimbursements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameClient,
            this.dateOfReimbursment});
            this.dgvReimbursements.GridColor = System.Drawing.Color.Red;
            this.dgvReimbursements.Location = new System.Drawing.Point(12, 303);
            this.dgvReimbursements.Name = "dgvReimbursements";
            this.dgvReimbursements.RowHeadersWidth = 51;
            this.dgvReimbursements.RowTemplate.Height = 24;
            this.dgvReimbursements.Size = new System.Drawing.Size(457, 150);
            this.dgvReimbursements.TabIndex = 14;
            this.dgvReimbursements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameClient
            // 
            this.nameClient.HeaderText = "Name";
            this.nameClient.MinimumWidth = 6;
            this.nameClient.Name = "nameClient";
            this.nameClient.Width = 150;
            // 
            // dateOfReimbursment
            // 
            this.dateOfReimbursment.HeaderText = "Date of reimbursement";
            this.dateOfReimbursment.MinimumWidth = 6;
            this.dateOfReimbursment.Name = "dateOfReimbursment";
            this.dateOfReimbursment.Width = 200;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            this.printPreviewToolStripMenuItem.Click += new System.EventHandler(this.printPreviewToolStripMenuItem_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(232, 26);
            this.pageSetupToolStripMenuItem.Text = "Page setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // FormReimbursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(498, 479);
            this.Controls.Add(this.dgvReimbursements);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUpdateReimbursement);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddReimbusment);
            this.Controls.Add(this.dateTimeReimbusement);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxNameR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
           // this.Name = "FormReimbursement";
            this.Text = "Reimbursement";
            this.Load += new System.EventHandler(this.FormReimbursement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDateReimbursement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReimbursements)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimeReimbusement;
        private System.Windows.Forms.Button buttonAddReimbusment;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdateReimbursement;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnFileReimbursementForm;
        private System.Windows.Forms.ToolStripMenuItem binarySerializationReimbursementForm;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeReimbursementForm;
        private System.Windows.Forms.ToolStripMenuItem deserializeBtnReimbursementForm;
        private System.Windows.Forms.ToolStripMenuItem btnOpenReimbursementForm;
        private System.Windows.Forms.ToolStripMenuItem btnCreateNewFile;
        private System.Windows.Forms.ErrorProvider errorProviderDateReimbursement;
        private System.Windows.Forms.DataGridView dgvReimbursements;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfReimbursment;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}