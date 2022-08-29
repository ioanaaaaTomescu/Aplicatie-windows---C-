
namespace PROIECT_WAP_VARIANTA2
{
    partial class EditFormReimbursement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFormReimbursement));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimeReimbursemetEdit = new System.Windows.Forms.DateTimePicker();
            this.btnOKEditReimbursment = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 27);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // dateTimeReimbursemetEdit
            // 
            this.dateTimeReimbursemetEdit.Location = new System.Drawing.Point(112, 61);
            this.dateTimeReimbursemetEdit.Name = "dateTimeReimbursemetEdit";
            this.dateTimeReimbursemetEdit.Size = new System.Drawing.Size(231, 22);
            this.dateTimeReimbursemetEdit.TabIndex = 3;
            // 
            // btnOKEditReimbursment
            // 
            this.btnOKEditReimbursment.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKEditReimbursment.Location = new System.Drawing.Point(162, 104);
            this.btnOKEditReimbursment.Name = "btnOKEditReimbursment";
            this.btnOKEditReimbursment.Size = new System.Drawing.Size(75, 23);
            this.btnOKEditReimbursment.TabIndex = 4;
            this.btnOKEditReimbursment.Text = "OK";
            this.btnOKEditReimbursment.UseVisualStyleBackColor = true;
            this.btnOKEditReimbursment.Click += new System.EventHandler(this.btnOKEditReimbursment_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEdit.Location = new System.Drawing.Point(257, 104);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCancelEdit.TabIndex = 5;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            // 
            // EditFormReimbursement
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(355, 168);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnOKEditReimbursment);
            this.Controls.Add(this.dateTimeReimbursemetEdit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditFormReimbursement";
            this.Load += new System.EventHandler(this.EditFormReimbursement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.Label lbReimbursementDate;
        private System.Windows.Forms.TextBox textBoxNameReimburmsentEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerReimbursementEdit;
        private System.Windows.Forms.Button buttonOKReimbursementEdit;
        private System.Windows.Forms.Button btnCancelEditReimbursemtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimeReimbursemetEdit;
        private System.Windows.Forms.Button btnOKEditReimbursment;
        private System.Windows.Forms.Button btnCancelEdit;
    }
}