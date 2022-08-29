
namespace PROIECT_WAP_VARIANTA2
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.labelName = new System.Windows.Forms.Label();
            this.labelCNP = new System.Windows.Forms.Label();
            this.labelPhoneNumberLabel = new System.Windows.Forms.Label();
            this.labelMaritalStatus = new System.Windows.Forms.Label();
            this.labelNoKids = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxphoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxMaritalStatus = new System.Windows.Forms.TextBox();
            this.textBoxnoKids = new System.Windows.Forms.TextBox();
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.listViewClients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderClientName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider7 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNoKids = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserialize = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTextFileClientForm = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripStatusLabelClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClientName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNoKids)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.MistyRose;
            this.labelName.Location = new System.Drawing.Point(21, 51);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelCNP
            // 
            this.labelCNP.AutoSize = true;
            this.labelCNP.BackColor = System.Drawing.Color.MistyRose;
            this.labelCNP.Location = new System.Drawing.Point(24, 84);
            this.labelCNP.Name = "labelCNP";
            this.labelCNP.Size = new System.Drawing.Size(40, 17);
            this.labelCNP.TabIndex = 1;
            this.labelCNP.Text = "CNP:";
            this.labelCNP.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPhoneNumberLabel
            // 
            this.labelPhoneNumberLabel.AutoSize = true;
            this.labelPhoneNumberLabel.BackColor = System.Drawing.Color.MistyRose;
            this.labelPhoneNumberLabel.Location = new System.Drawing.Point(24, 115);
            this.labelPhoneNumberLabel.Name = "labelPhoneNumberLabel";
            this.labelPhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.labelPhoneNumberLabel.TabIndex = 2;
            this.labelPhoneNumberLabel.Text = "Phone Number";
            this.labelPhoneNumberLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelMaritalStatus
            // 
            this.labelMaritalStatus.AutoSize = true;
            this.labelMaritalStatus.BackColor = System.Drawing.Color.MistyRose;
            this.labelMaritalStatus.Location = new System.Drawing.Point(24, 145);
            this.labelMaritalStatus.Name = "labelMaritalStatus";
            this.labelMaritalStatus.Size = new System.Drawing.Size(92, 17);
            this.labelMaritalStatus.TabIndex = 3;
            this.labelMaritalStatus.Text = "Marital status";
            // 
            // labelNoKids
            // 
            this.labelNoKids.AutoSize = true;
            this.labelNoKids.BackColor = System.Drawing.Color.MistyRose;
            this.labelNoKids.Location = new System.Drawing.Point(24, 174);
            this.labelNoKids.Name = "labelNoKids";
            this.labelNoKids.Size = new System.Drawing.Size(103, 17);
            this.labelNoKids.TabIndex = 4;
            this.labelNoKids.Text = "Number of kids";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 51);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(351, 22);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.VisibleChanged += new System.EventHandler(this.textBoxName_VisibleChanged);
            this.textBoxName.MouseLeave += new System.EventHandler(this.textBoxName_MouseLeave);
            this.textBoxName.MouseHover += new System.EventHandler(this.textBoxName_MouseHover);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            this.textBoxName.Validated += new System.EventHandler(this.textBoxName_Validated);
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(76, 81);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(351, 22);
            this.textBoxCNP.TabIndex = 6;
            this.textBoxCNP.MouseHover += new System.EventHandler(this.textBoxCNP_MouseHover);
            // 
            // textBoxphoneNumber
            // 
            this.textBoxphoneNumber.Location = new System.Drawing.Point(133, 115);
            this.textBoxphoneNumber.Name = "textBoxphoneNumber";
            this.textBoxphoneNumber.Size = new System.Drawing.Size(294, 22);
            this.textBoxphoneNumber.TabIndex = 7;
            this.textBoxphoneNumber.TextChanged += new System.EventHandler(this.textBoxphoneNumber_TextChanged);
            this.textBoxphoneNumber.MouseLeave += new System.EventHandler(this.textBoxphoneNumber_MouseLeave);
            this.textBoxphoneNumber.MouseHover += new System.EventHandler(this.textBoxphoneNumber_MouseHover);
            // 
            // textBoxMaritalStatus
            // 
            this.textBoxMaritalStatus.Location = new System.Drawing.Point(134, 143);
            this.textBoxMaritalStatus.Name = "textBoxMaritalStatus";
            this.textBoxMaritalStatus.Size = new System.Drawing.Size(293, 22);
            this.textBoxMaritalStatus.TabIndex = 8;
            this.textBoxMaritalStatus.MouseLeave += new System.EventHandler(this.textBoxMaritalStatus_MouseLeave);
            this.textBoxMaritalStatus.MouseHover += new System.EventHandler(this.textBoxMaritalStatus_MouseHover);
            // 
            // textBoxnoKids
            // 
            this.textBoxnoKids.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxnoKids.Location = new System.Drawing.Point(133, 174);
            this.textBoxnoKids.Name = "textBoxnoKids";
            this.textBoxnoKids.Size = new System.Drawing.Size(294, 22);
            this.textBoxnoKids.TabIndex = 9;
            this.textBoxnoKids.MouseLeave += new System.EventHandler(this.textBoxnoKids_MouseLeave);
            this.textBoxnoKids.MouseHover += new System.EventHandler(this.textBoxnoKids_MouseHover);
            this.textBoxnoKids.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxnoKids_Validating);
            this.textBoxnoKids.Validated += new System.EventHandler(this.textBoxnoKids_Validated);
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAddNewClient.Location = new System.Drawing.Point(12, 212);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(115, 29);
            this.buttonAddNewClient.TabIndex = 10;
            this.buttonAddNewClient.Text = "Add new client";
            this.buttonAddNewClient.UseVisualStyleBackColor = false;
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddNewClient_Click);
            this.buttonAddNewClient.MouseLeave += new System.EventHandler(this.buttonAddNewClient_MouseLeave);
            this.buttonAddNewClient.MouseHover += new System.EventHandler(this.buttonAddNewClient_MouseHover);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MistyRose;
            this.buttonDelete.Location = new System.Drawing.Point(169, 212);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(110, 28);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Delete client";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonDelete_MouseLeave);
            this.buttonDelete.MouseHover += new System.EventHandler(this.buttonDelete_MouseHover);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MistyRose;
            this.btnEdit.Location = new System.Drawing.Point(320, 211);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(107, 29);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEdit_MouseMove);
            // 
            // listViewClients
            // 
            this.listViewClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClients.BackColor = System.Drawing.Color.MistyRose;
            this.listViewClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewClients.GridLines = true;
            this.listViewClients.HideSelection = false;
            this.listViewClients.Location = new System.Drawing.Point(12, 247);
            this.listViewClients.Name = "listViewClients";
            this.listViewClients.Size = new System.Drawing.Size(415, 130);
            this.listViewClients.TabIndex = 13;
            this.listViewClients.UseCompatibleStateImageBehavior = false;
            this.listViewClients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CNP";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone number";
            this.columnHeader3.Width = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProviderClientName
            // 
            this.errorProviderClientName.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            this.errorProvider7.ContainerControl = this;
            // 
            // errorProviderNoKids
            // 
            this.errorProviderNoKids.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationToolStripMenuItem,
            this.btnTextFileClientForm,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(443, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // serializationToolStripMenuItem
            // 
            this.serializationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeBinary,
            this.btnDeserialize});
            this.serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            this.serializationToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.serializationToolStripMenuItem.Text = "Binary Serialization";
            this.serializationToolStripMenuItem.Click += new System.EventHandler(this.serializationToolStripMenuItem_Click);
            // 
            // btnSerializeBinary
            // 
            this.btnSerializeBinary.Name = "btnSerializeBinary";
            this.btnSerializeBinary.Size = new System.Drawing.Size(224, 26);
            this.btnSerializeBinary.Text = "Serialize";
            this.btnSerializeBinary.Click += new System.EventHandler(this.serializedToolStripMenuItem_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(224, 26);
            this.btnDeserialize.Text = "Desearlize";
            this.btnDeserialize.Click += new System.EventHandler(this.desearlizedToolStripMenuItem_Click);
            // 
            // btnTextFileClientForm
            // 
            this.btnTextFileClientForm.Name = "btnTextFileClientForm";
            this.btnTextFileClientForm.Size = new System.Drawing.Size(150, 24);
            this.btnTextFileClientForm.Text = "Export as a text file";
            this.btnTextFileClientForm.Click += new System.EventHandler(this.btnTextFileClientForm_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripStatusLabelClient,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(443, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StripStatusLabelClient
            // 
            this.StripStatusLabelClient.Name = "StripStatusLabelClient";
            this.StripStatusLabelClient.Size = new System.Drawing.Size(0, 16);
            this.StripStatusLabelClient.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(443, 463);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewClients);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddNewClient);
            this.Controls.Add(this.textBoxnoKids);
            this.Controls.Add(this.textBoxMaritalStatus);
            this.Controls.Add(this.textBoxphoneNumber);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelNoKids);
            this.Controls.Add(this.labelMaritalStatus);
            this.Controls.Add(this.labelPhoneNumberLabel);
            this.Controls.Add(this.labelCNP);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClient_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClientName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNoKids)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCNP;
        private System.Windows.Forms.Label labelPhoneNumberLabel;
        private System.Windows.Forms.Label labelMaritalStatus;
        private System.Windows.Forms.Label labelNoKids;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxphoneNumber;
        private System.Windows.Forms.TextBox textBoxMaritalStatus;
        private System.Windows.Forms.TextBox textBoxnoKids;
        private System.Windows.Forms.Button buttonAddNewClient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView listViewClients;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProviderClientName;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.ErrorProvider errorProvider7;
        private System.Windows.Forms.ErrorProvider errorProviderNoKids;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeBinary;
        private System.Windows.Forms.ToolStripMenuItem btnDeserialize;
        private System.Windows.Forms.ToolStripMenuItem btnTextFileClientForm;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripStatusLabelClient;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

