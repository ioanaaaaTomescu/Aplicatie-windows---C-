
namespace PROIECT_WAP_VARIANTA2
{
    partial class FormChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChart));
            this.numericTextBox1 = new ChartProject.NumericTextBox();
            this.chart1 = new PROIECT_WAP_VARIANTA2.Chart();
            this.buttonChart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.Location = new System.Drawing.Point(532, 332);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(40, 22);
            this.numericTextBox1.TabIndex = 1;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.MistyRose;
            this.chart1.Location = new System.Drawing.Point(146, 85);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(308, 213);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // buttonChart
            // 
            this.buttonChart.BackColor = System.Drawing.Color.MistyRose;
            this.buttonChart.Location = new System.Drawing.Point(36, 331);
            this.buttonChart.Name = "buttonChart";
            this.buttonChart.Size = new System.Drawing.Size(129, 23);
            this.buttonChart.TabIndex = 2;
            this.buttonChart.Text = "Update Chart";
            this.buttonChart.UseVisualStyleBackColor = false;
            this.buttonChart.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(110, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "The decrease or increase in the currency in the last 10 days";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(596, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonChart);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.chart1);
            this.Name = "FormChart";
            this.Text = "FormChart";
            this.Load += new System.EventHandler(this.FormChart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chart chart1;
        private ChartProject.NumericTextBox numericTextBox1;
        private System.Windows.Forms.Button buttonChart;
        private System.Windows.Forms.Label label2;
    }
}