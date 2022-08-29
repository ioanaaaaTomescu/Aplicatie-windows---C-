
namespace PROIECT_WAP_VARIANTA2
{
    partial class EditFormCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormCredits));
            this.lbNameClient = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbCNPClient = new System.Windows.Forms.Label();
            this.lbCreditID = new System.Windows.Forms.Label();
            this.textBoxClientNameEdit = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeNameEdit = new System.Windows.Forms.TextBox();
            this.textBoxCNPClientEdit = new System.Windows.Forms.TextBox();
            this.textBoxCreditIDEdit = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNameClient
            // 
            this.lbNameClient.AutoSize = true;
            this.lbNameClient.BackColor = System.Drawing.Color.MistyRose;
            this.lbNameClient.Location = new System.Drawing.Point(31, 33);
            this.lbNameClient.Name = "lbNameClient";
            this.lbNameClient.Size = new System.Drawing.Size(82, 17);
            this.lbNameClient.TabIndex = 0;
            this.lbNameClient.Text = "Client name";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.BackColor = System.Drawing.Color.MistyRose;
            this.lbEmployeeName.Location = new System.Drawing.Point(31, 75);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(109, 17);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "Employee name";
            // 
            // lbCNPClient
            // 
            this.lbCNPClient.AutoSize = true;
            this.lbCNPClient.BackColor = System.Drawing.Color.MistyRose;
            this.lbCNPClient.Location = new System.Drawing.Point(31, 116);
            this.lbCNPClient.Name = "lbCNPClient";
            this.lbCNPClient.Size = new System.Drawing.Size(73, 17);
            this.lbCNPClient.TabIndex = 2;
            this.lbCNPClient.Text = "CNP client";
            // 
            // lbCreditID
            // 
            this.lbCreditID.AutoSize = true;
            this.lbCreditID.BackColor = System.Drawing.Color.MistyRose;
            this.lbCreditID.Location = new System.Drawing.Point(31, 158);
            this.lbCreditID.Name = "lbCreditID";
            this.lbCreditID.Size = new System.Drawing.Size(62, 17);
            this.lbCreditID.TabIndex = 3;
            this.lbCreditID.Text = "Credit ID";
            // 
            // textBoxClientNameEdit
            // 
            this.textBoxClientNameEdit.Location = new System.Drawing.Point(119, 33);
            this.textBoxClientNameEdit.Name = "textBoxClientNameEdit";
            this.textBoxClientNameEdit.Size = new System.Drawing.Size(154, 22);
            this.textBoxClientNameEdit.TabIndex = 4;
            // 
            // textBoxEmployeeNameEdit
            // 
            this.textBoxEmployeeNameEdit.Location = new System.Drawing.Point(146, 75);
            this.textBoxEmployeeNameEdit.Name = "textBoxEmployeeNameEdit";
            this.textBoxEmployeeNameEdit.Size = new System.Drawing.Size(127, 22);
            this.textBoxEmployeeNameEdit.TabIndex = 5;
            // 
            // textBoxCNPClientEdit
            // 
            this.textBoxCNPClientEdit.Location = new System.Drawing.Point(110, 116);
            this.textBoxCNPClientEdit.Name = "textBoxCNPClientEdit";
            this.textBoxCNPClientEdit.Size = new System.Drawing.Size(163, 22);
            this.textBoxCNPClientEdit.TabIndex = 6;
            // 
            // textBoxCreditIDEdit
            // 
            this.textBoxCreditIDEdit.Location = new System.Drawing.Point(119, 155);
            this.textBoxCreditIDEdit.Name = "textBoxCreditIDEdit";
            this.textBoxCreditIDEdit.Size = new System.Drawing.Size(154, 22);
            this.textBoxCreditIDEdit.TabIndex = 7;
            // 
            // btnOK
            // 
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(38, 197);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EditFormCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(311, 244);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.textBoxCreditIDEdit);
            this.Controls.Add(this.textBoxCNPClientEdit);
            this.Controls.Add(this.textBoxEmployeeNameEdit);
            this.Controls.Add(this.textBoxClientNameEdit);
            this.Controls.Add(this.lbCreditID);
            this.Controls.Add(this.lbCNPClient);
            this.Controls.Add(this.lbEmployeeName);
            this.Controls.Add(this.lbNameClient);
            this.Name = "EditFormCredits";
            this.Text = "EditFormCredits";
            this.Load += new System.EventHandler(this.EditFormCredits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameClient;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbCNPClient;
        private System.Windows.Forms.Label lbCreditID;
        private System.Windows.Forms.TextBox textBoxClientNameEdit;
        private System.Windows.Forms.TextBox textBoxEmployeeNameEdit;
        private System.Windows.Forms.TextBox textBoxCNPClientEdit;
        private System.Windows.Forms.TextBox textBoxCreditIDEdit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}