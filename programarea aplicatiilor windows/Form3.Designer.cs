
namespace PROIECT_WAP_VARIANTA2
{
    partial class FormCredit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredit));
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.labelAccountNumber = new System.Windows.Forms.Label();
            this.labelCNPCredit = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxCNPCredit = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.labelCreditId = new System.Windows.Forms.Label();
            this.textBoxCreditId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listViewCredits = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProviderClientCredit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmployeeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnBinarySerializationCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializeCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializeCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportAsATextFileCredit = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClientCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmployeeName)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.BackColor = System.Drawing.Color.MistyRose;
            this.labelClientName.Location = new System.Drawing.Point(28, 56);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(82, 17);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Client name";
            this.labelClientName.Click += new System.EventHandler(this.labelClientName_Click);
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.BackColor = System.Drawing.Color.MistyRose;
            this.labelEmployeeName.Location = new System.Drawing.Point(371, 61);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(109, 17);
            this.labelEmployeeName.TabIndex = 1;
            this.labelEmployeeName.Text = "Employee name";
            this.labelEmployeeName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelAccountNumber
            // 
            this.labelAccountNumber.AutoSize = true;
            this.labelAccountNumber.BackColor = System.Drawing.Color.MistyRose;
            this.labelAccountNumber.Location = new System.Drawing.Point(380, 87);
            this.labelAccountNumber.Name = "labelAccountNumber";
            this.labelAccountNumber.Size = new System.Drawing.Size(111, 17);
            this.labelAccountNumber.TabIndex = 2;
            this.labelAccountNumber.Text = "Account number";
            // 
            // labelCNPCredit
            // 
            this.labelCNPCredit.AutoSize = true;
            this.labelCNPCredit.BackColor = System.Drawing.Color.MistyRose;
            this.labelCNPCredit.Location = new System.Drawing.Point(28, 85);
            this.labelCNPCredit.Name = "labelCNPCredit";
            this.labelCNPCredit.Size = new System.Drawing.Size(36, 17);
            this.labelCNPCredit.TabIndex = 3;
            this.labelCNPCredit.Text = "CNP";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(128, 56);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(237, 22);
            this.textBoxClientName.TabIndex = 4;
            this.textBoxClientName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxClientName_Validating);
            this.textBoxClientName.Validated += new System.EventHandler(this.textBoxClientName_Validated);
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(503, 56);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(222, 22);
            this.textBoxEmployeeName.TabIndex = 5;
            this.textBoxEmployeeName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEmployeeName_Validating);
            this.textBoxEmployeeName.Validated += new System.EventHandler(this.textBoxEmployeeName_Validated);
            // 
            // textBoxCNPCredit
            // 
            this.textBoxCNPCredit.Location = new System.Drawing.Point(70, 82);
            this.textBoxCNPCredit.Name = "textBoxCNPCredit";
            this.textBoxCNPCredit.Size = new System.Drawing.Size(295, 22);
            this.textBoxCNPCredit.TabIndex = 6;
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(503, 87);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(220, 22);
            this.textBoxAccountNumber.TabIndex = 7;
            // 
            // labelCreditId
            // 
            this.labelCreditId.AutoSize = true;
            this.labelCreditId.Location = new System.Drawing.Point(28, 113);
            this.labelCreditId.Name = "labelCreditId";
            this.labelCreditId.Size = new System.Drawing.Size(60, 17);
            this.labelCreditId.TabIndex = 8;
            this.labelCreditId.Text = "Credit id";
            // 
            // textBoxCreditId
            // 
            this.textBoxCreditId.Location = new System.Drawing.Point(105, 110);
            this.textBoxCreditId.Name = "textBoxCreditId";
            this.textBoxCreditId.Size = new System.Drawing.Size(260, 22);
            this.textBoxCreditId.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(31, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add new credit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(167, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete credit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(285, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update credit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Location = new System.Drawing.Point(416, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "Go to reimbursment";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.Location = new System.Drawing.Point(578, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "Go to the first form";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listViewCredits
            // 
            this.listViewCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCredits.BackColor = System.Drawing.Color.MistyRose;
            this.listViewCredits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listViewCredits.BackgroundImage")));
            this.listViewCredits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.listViewCredits.GridLines = true;
            this.listViewCredits.HideSelection = false;
            this.listViewCredits.Location = new System.Drawing.Point(31, 180);
            this.listViewCredits.Name = "listViewCredits";
            this.listViewCredits.Size = new System.Drawing.Size(694, 149);
            this.listViewCredits.TabIndex = 16;
            this.listViewCredits.UseCompatibleStateImageBehavior = false;
            this.listViewCredits.View = System.Windows.Forms.View.Details;
            this.listViewCredits.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Client name";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Employee name";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CNP Client";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Credit id";
            this.columnHeader5.Width = 130;
            // 
            // errorProviderClientCredit
            // 
            this.errorProviderClientCredit.ContainerControl = this;
            // 
            // errorProviderEmployeeName
            // 
            this.errorProviderEmployeeName.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(750, 27);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBinarySerializationCredit,
            this.btnExportAsATextFileCredit,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.pageSetupToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // btnBinarySerializationCredit
            // 
            this.btnBinarySerializationCredit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializeCredit,
            this.btnDeserializeCredit});
            this.btnBinarySerializationCredit.Name = "btnBinarySerializationCredit";
            this.btnBinarySerializationCredit.Size = new System.Drawing.Size(227, 26);
            this.btnBinarySerializationCredit.Text = "Binary serialization";
            this.btnBinarySerializationCredit.Click += new System.EventHandler(this.binarySerializationToolStripMenuItem_Click);
            // 
            // btnSerializeCredit
            // 
            this.btnSerializeCredit.Name = "btnSerializeCredit";
            this.btnSerializeCredit.Size = new System.Drawing.Size(165, 26);
            this.btnSerializeCredit.Text = "Serialize";
            // 
            // btnDeserializeCredit
            // 
            this.btnDeserializeCredit.Name = "btnDeserializeCredit";
            this.btnDeserializeCredit.Size = new System.Drawing.Size(165, 26);
            this.btnDeserializeCredit.Text = "Deserialize";
            // 
            // btnExportAsATextFileCredit
            // 
            this.btnExportAsATextFileCredit.Name = "btnExportAsATextFileCredit";
            this.btnExportAsATextFileCredit.Size = new System.Drawing.Size(227, 26);
            this.btnExportAsATextFileCredit.Text = "Export as   a text file";
            this.btnExportAsATextFileCredit.Click += new System.EventHandler(this.btnExportAsATextFileCredit_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.printPreviewToolStripMenuItem.Text = "Print preview";
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.pageSetupToolStripMenuItem.Text = "Page setup";
            // 
            // FormCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(750, 345);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listViewCredits);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCreditId);
            this.Controls.Add(this.labelCreditId);
            this.Controls.Add(this.textBoxAccountNumber);
            this.Controls.Add(this.textBoxCNPCredit);
            this.Controls.Add(this.textBoxEmployeeName);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelCNPCredit);
            this.Controls.Add(this.labelAccountNumber);
            this.Controls.Add(this.labelEmployeeName);
            this.Controls.Add(this.labelClientName);
            this.Name = "FormCredit";
            this.Text = "Credit";
            this.Load += new System.EventHandler(this.FormCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClientCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmployeeName)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.Label labelAccountNumber;
        private System.Windows.Forms.Label labelCNPCredit;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxCNPCredit;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.Label labelCreditId;
        private System.Windows.Forms.TextBox textBoxCreditId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListView listViewCredits;
        private System.Windows.Forms.ErrorProvider errorProviderClientCredit;
        private System.Windows.Forms.ErrorProvider errorProviderEmployeeName;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem btnBinarySerializationCredit;
        private System.Windows.Forms.ToolStripMenuItem btnSerializeCredit;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializeCredit;
        private System.Windows.Forms.ToolStripMenuItem btnExportAsATextFileCredit;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
    }
}