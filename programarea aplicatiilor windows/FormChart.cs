using ChartProject;
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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indicator2020 = 1;
            ChartValue[] data = new ChartValue[]
            {
                new ChartValue("10.05.2021",50),
                new ChartValue("11.05.2021", 20),
                new ChartValue("12.05.2021", 10),
                new ChartValue("13.05.2021",60),
                new ChartValue("14.05.2021",25),
                new ChartValue("15.05.2021",50),
                new ChartValue("16.05.2021",200),
                new ChartValue("17.05.2021",75),
                new ChartValue("18.05.2021",100),
                new ChartValue("19.05.2021",50)
            };

            chart1.Data = data;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
