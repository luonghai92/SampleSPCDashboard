using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sample.Controls
{
    public partial class XBar : UserControl
    {
        public XBar()
        {
            InitializeComponent();

        }
        DataTable _data;
        public DataTable data
        {
            get { return _data; }
            set
            {
                _data = value;
                double[] vals = data.AsEnumerable().Select(row => row.Field<double>("range_qty")).ToArray();
                double avg = vals.Average();
                double UCL = avg * 2.114;
                double LCL = avg * 0.076;
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    chart1.Series[0].Points.AddXY(i, vals[i]);
                }
                chart1.Series["AVG"].Points.AddXY(0, avg);
                chart1.Series["AVG"].Points.AddXY(data.Rows.Count, avg);

                chart1.Series["UCL"].Points.AddXY(0, UCL);
                chart1.Series["UCL"].Points.AddXY(data.Rows.Count, UCL);

                chart1.Series["LCL"].Points.AddXY(0, LCL);
                chart1.Series["LCL"].Points.AddXY(data.Rows.Count, LCL);


                for (int i = 0; i < data.Rows.Count; i++)
                {
                    chart2.Series[0].Points.AddXY(i, vals[i]);
                }
                chart2.Series["AVG"].Points.AddXY(0, avg);
                chart2.Series["AVG"].Points.AddXY(data.Rows.Count, avg);

                chart2.Series["UCL"].Points.AddXY(0, UCL);
                chart2.Series["UCL"].Points.AddXY(data.Rows.Count, UCL);

                chart2.Series["LCL"].Points.AddXY(0, LCL);
                chart2.Series["LCL"].Points.AddXY(data.Rows.Count, LCL);


            }
        }

        DataTable _histogramData = new DataTable();
        public DataTable histogramData
        {
            get { return _histogramData; }
            set
            {
                _histogramData = value;
                float[] vals = histogramData.AsEnumerable().Select(row => row.Field<float>("qty")).ToArray();
                double avg = vals.Average();
                double UCL = avg * 2.114;
                double LCL = avg * 0.076;
                CreateHistogramLayout(vals, 10);
            }
        }
        private void CreateHistogramLayout(float[] vals, float numSpace)
        {
            double LCL = vals.Min();
            double UCL = vals.Max();
            double range = UCL - LCL;
            double step = range / (numSpace - 1);
            double[] arr = new double[20];
            //chart3.ChartAreas[0].AxisX2.Minimum = LCL;
            //chart3.ChartAreas[0].AxisX2.Maximum = UCL;
            chart3.ChartAreas[0].AxisY2.Minimum = 0;
            chart3.ChartAreas[0].AxisY2.Maximum = 60;
            for (int i = 0; i < numSpace; i++)
            {
                arr[i] = LCL + step * i;
            }
            for (int i = 0; i < numSpace - 2; i++)
            {
                int count = vals.Where(x => x >= arr[i] && x <= arr[i + 1]).Count();
                Console.WriteLine(count);
                chart3.Series[0].Points.AddXY((int)arr[i], count);
            }
        }

    }
}
