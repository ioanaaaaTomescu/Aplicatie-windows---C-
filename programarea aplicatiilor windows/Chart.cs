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
    public partial class Chart : Control
    {
        private ChartValue[] data1;
        public ChartValue[] Data { get { return data1; } set { data1 = value;
                Invalidate();
            } }
        public Chart()
        {
            InitializeComponent();

            Data = new ChartValue[]
            {
                new ChartValue("2000",100),
                new ChartValue("2001", 20),
                new ChartValue("2002", 100),
                new ChartValue("2003",40),
                new ChartValue("2004",100),
                new ChartValue("2005",200),
                new ChartValue("2006",150),
                new ChartValue("2007",10),
                new ChartValue("2008",30),
                new ChartValue("2009",200)
                

            };
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics graphics = pe.Graphics;
            Rectangle rectangle = pe.ClipRectangle;
            var barWidth = rectangle.Width / Data.Length;
            var maxBarHeight = rectangle.Height * 1.2;
            var maxValue = Data.Max(x => x.value);
            var scallingFactor = maxBarHeight / maxValue;
            var xCoordinate = rectangle.Height * 0.9;
            var yCoordinate = rectangle.Width / Data.Length;
            for (int i = 0; i < Data.Length; i++)
            {
                var barHeight = scallingFactor * Data[i].value;
                //graphics.FillRectangle(
                //    Brushes.Red,
                //    i * barWidth,
                //    (float)(rectangle.Height - barHeight),
                //    (float)(barWidth * 0.5),
                //    (float)barHeight
                //    );
                //Pen pen = new Pen(Color.Black);
                //graphics.DrawEllipse(pen ,10,
                //   200,
                //   20,
                //   20);
                graphics.FillCircle(Brushes.Purple, (float)(barWidth*i), (float)(rectangle.Height-barHeight), 10);
                graphics.DrawRectangle(Pens.Black, 0, 0, rectangle.Width - 1, rectangle.Height - 1);
              };
        }
    }
}
