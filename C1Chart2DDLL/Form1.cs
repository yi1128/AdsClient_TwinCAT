using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace C1Chart2DDLL
{
    public partial class C1ChartFormClass : Form
    {

        long ControlLoop = 0;

        float[] m_Data = new float[2];

        bool m_chkRunMode = false;
        bool m_chkAutoXAxisFit = false;
        double m_XAxisAutoRange = 10000.0;
        double m_ClearChartX = 50000.0;
        int m_DemoRunMode = 0;
        public int m_Mode = 0;
        
        ChartDataSeries cds1 = new ChartDataSeries();
        ChartDataSeries cds2 = new ChartDataSeries();
        ChartDataSeries cds3 = new ChartDataSeries();
        ChartDataSeries cds4 = new ChartDataSeries();
        ChartDataSeries cds5 = new ChartDataSeries();
        ChartDataSeries cds6 = new ChartDataSeries();

        public C1ChartFormClass()
        {
            
            InitializeComponent();
        }

        public void AddPoint(float x, float y1, float y2)
        {
            if (c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Length > m_ClearChartX) ClearChart();
            PointF point1 = new PointF(x, y1);
            PointF point2 = new PointF(x, y2);

            if (m_chkAutoXAxisFit)
            {
                c1Chart1.ChartArea.AxisX.Max = (double)x;
                c1Chart1.ChartArea.AxisX.Min = (double)x - m_XAxisAutoRange;
            }

            if(m_chkRunMode)
            {
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Add(point1);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Add(point2);
            }
            
        }

        public void SetMode(int mode)
        {
            m_chkRunMode = false;
            timer1.Stop();
            m_Mode = mode;
            
            if(mode == 0)
            {
                
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Clear();
                
                cds1.LineStyle.Color = Color.Red;
                cds1.LineStyle.Pattern = LinePatternEnum.Solid;
                cds1.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds1.LineStyle.Thickness = 1;
                cds2.LineStyle.Color = Color.Orange;
                cds2.LineStyle.Pattern = LinePatternEnum.Solid;
                cds2.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds2.LineStyle.Thickness = 1;
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds1);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds2);
                

            }

            else if(mode == 1)
            {
                
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Clear();

                cds1.LineStyle.Color = Color.Red;
                cds1.LineStyle.Pattern = LinePatternEnum.Solid;
                cds1.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds1.LineStyle.Thickness = 1;
                cds2.LineStyle.Color = Color.Orange;
                cds2.LineStyle.Pattern = LinePatternEnum.Solid;
                cds2.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds2.LineStyle.Thickness = 1;
                cds3.LineStyle.Color = Color.Violet;
                cds3.LineStyle.Pattern = LinePatternEnum.Solid;
                cds3.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds3.LineStyle.Thickness = 1;
                cds4.LineStyle.Color = Color.Green;
                cds4.LineStyle.Pattern = LinePatternEnum.Solid;
                cds4.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds4.LineStyle.Thickness = 1;
                cds5.LineStyle.Color = Color.Blue;
                cds5.LineStyle.Pattern = LinePatternEnum.Solid;
                cds5.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds5.LineStyle.Thickness = 1;
                cds6.LineStyle.Color = Color.Purple;
                cds6.LineStyle.Pattern = LinePatternEnum.Solid;
                cds6.SymbolStyle.Shape = SymbolShapeEnum.None;
                cds6.LineStyle.Thickness = 1;

                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds1);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds2);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds3);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds4);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds5);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(cds6);
            }
            ClearChart();
            m_chkRunMode = true;
        }

        public void SetLegend(int mode, string[] label)
        {
            if(mode == 0)
            {
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].Label = label[0];
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].Label = label[1];       
            }

            else if(mode == 1)
            {
  
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].Label = label[0];
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].Label = label[1];
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[2].Label = label[2];
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[3].Label = label[3];
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[4].Label = label[4];
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[5].Label = label[5];

            }

        }

        public void AddPoint3D(float x, float[] y1, float[] y2)
        {
            if (c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Length > m_ClearChartX) ClearChart();
            PointF point1 = new PointF(x, y1[0]);
            PointF point2 = new PointF(x, y2[0]);

            PointF point3 = new PointF(x, y1[1]);
            PointF point4 = new PointF(x, y2[1]);

            PointF point5 = new PointF(x, y1[2]);
            PointF point6 = new PointF(x, y2[2]);

            if (m_chkAutoXAxisFit)
            {
                c1Chart1.ChartArea.AxisX.Max = (double)x;
                c1Chart1.ChartArea.AxisX.Min = (double)x - m_XAxisAutoRange;
            }

            if(m_chkRunMode)
            {
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Add(point1);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Add(point2);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[2].PointData.Add(point3);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[3].PointData.Add(point4);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[4].PointData.Add(point5);
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[5].PointData.Add(point6);

            }
            
        }

        public void StartDemo()
        {
            ClearChart();
            string[] msg = new string[2];
            msg[0] = "Current Joint1";
            msg[1] = "Target Joint1";
            SetLegend(0, msg);
            m_DemoRunMode = 0;
            m_chkRunMode = true;
            timer1.Interval = 20;
            timer1.Start();
        }

        public void StartDemo3d()
        {
            ClearChart();
            string[] msg = new string[6];
            msg[0] = "Current Px";
            msg[1] = "Target Px";
            msg[2] = "Current Py";
            msg[3] = "Target Py";
            msg[4] = "Current Pz";
            msg[5] = "Target Pz";
            SetLegend(1, msg);
            m_DemoRunMode = 1;
            m_chkRunMode = true;
            timer1.Interval = 20;
            timer1.Start();
        }

        public void Stop()
        {
            timer1.Stop();
        }

        public void ClearChart()
        {
            if (m_Mode == 0)
            {
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Clear();
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Clear();

            }

            else if(m_Mode == 1)
            {
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Clear();
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Clear();
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[2].PointData.Clear();
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[3].PointData.Clear();
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[4].PointData.Clear();
                c1Chart1.ChartGroups.Group0.ChartData.SeriesList[5].PointData.Clear();
            }
            
        }


        private void btnXFit_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisX.AutoMax = true;
            c1Chart1.ChartArea.AxisX.AutoMin = true;

        }

        private void btnYFit_Click(object sender, EventArgs e)
        {
            
            c1Chart1.ChartArea.AxisY.AutoMax = true;
            c1Chart1.ChartArea.AxisY.AutoMin = true;
            c1Chart1.ChartArea.AxisY2.AutoMax = true;
            c1Chart1.ChartArea.AxisY2.AutoMin = true;
            c1Chart1.ChartArea.AxisY.AutoMax = false;
            c1Chart1.ChartArea.AxisY.AutoMin = false;
            c1Chart1.ChartArea.AxisY2.AutoMax = false;
            c1Chart1.ChartArea.AxisY2.AutoMin = false;
        }

        private void btnGetRangeXY_Click(object sender, EventArgs e)
        {
            tbXRangeMax.Text = c1Chart1.ChartArea.AxisX.Max.ToString();
            tbXRangeMin.Text = c1Chart1.ChartArea.AxisX.Min.ToString();
            tbY1RangeMax.Text = c1Chart1.ChartArea.AxisY.Max.ToString();
            tbY1RangeMin.Text = c1Chart1.ChartArea.AxisY.Min.ToString();
            tbY2RangeMax.Text = c1Chart1.ChartArea.AxisY2.Max.ToString();
            tbY2RangeMin.Text = c1Chart1.ChartArea.AxisY2.Min.ToString();

        }

        private void btnXRange_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisX.Max = double.Parse(tbXRangeMax.Text);
            c1Chart1.ChartArea.AxisX.Min = double.Parse(tbXRangeMin.Text);
        }

        private void btnMinusXAxis_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisX.Min = c1Chart1.ChartArea.AxisX.Min - double.Parse(tbAddXAxis.Text);
        }

        private void btnPlusXAxis_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisX.Max = c1Chart1.ChartArea.AxisX.Max + double.Parse(tbAddXAxis.Text);
        }

        private void btnYRange_Click(object sender, EventArgs e)
        {
            //m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisY.Max = double.Parse(tbY1RangeMax.Text);
            c1Chart1.ChartArea.AxisY.Min = double.Parse(tbY1RangeMin.Text);
            c1Chart1.ChartArea.AxisY2.Max = double.Parse(tbY2RangeMax.Text);
            c1Chart1.ChartArea.AxisY2.Min = double.Parse(tbY2RangeMin.Text);
        }

        private void btnMinusY1Axis_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisY.Min = c1Chart1.ChartArea.AxisY.Min - double.Parse(tbAddY1Axis.Text);
        }

        private void btnPlusY1Axis_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisY.Max = c1Chart1.ChartArea.AxisY.Max + double.Parse(tbAddY1Axis.Text);
        }

        private void btnMinusY2Axis_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisY2.Min = c1Chart1.ChartArea.AxisY2.Min - double.Parse(tbAddY2Axis.Text);
        }

        private void btnPlusY2Axis_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = false;
            c1Chart1.ChartArea.AxisY2.Max = c1Chart1.ChartArea.AxisY2.Max + double.Parse(tbAddY2Axis.Text);
        }

        private void btnClearChart_Click(object sender, EventArgs e)
        {
            ClearChart();
        }

        private void btnDemoRun_Click(object sender, EventArgs e)
        {
            SetMode(0);
            StartDemo();
        }


        private void btnDemoRun3D_Click(object sender, EventArgs e)
        {
            SetMode(1);
            StartDemo3d();
        }

        private void btnMeasureDataRun_Click(object sender, EventArgs e)
        {
            //m_chkRunMode = false;
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_chkRunMode)
            {
                PointF[] point = new PointF[6];
                float[] Data = new float[6];
                

                if(m_DemoRunMode == 0)
                {
                    if (ControlLoop > m_ClearChartX) ClearChart();

                    Data[0] = (float)(8.0 * Math.Sin((double)ControlLoop / 100.0));
                    Data[1] = (float)(8.0 * Math.Cos((double)ControlLoop / 100.0));

                    for (int i = 0; i < 2; i++ ) point[i] = new PointF(ControlLoop, Data[i]);


                    if (m_chkAutoXAxisFit)
                    {
                        c1Chart1.ChartArea.AxisX.Max = ControlLoop;
                        c1Chart1.ChartArea.AxisX.Min = (double)ControlLoop - m_XAxisAutoRange;
                    }

                    c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Add(point[0]);
                    c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Add(point[1]);

                    ControlLoop++;
                    if (ControlLoop > m_ClearChartX)
                    {
                        ControlLoop = 0;
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Clear();
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Clear();
                    }
                }

                else if(m_DemoRunMode == 1)
                {
                    if (ControlLoop > m_ClearChartX) ClearChart();

                    Data[0] = (float)(8.0 * Math.Sin((double)ControlLoop / 100.0));
                    Data[1] = (float)(8.0 * Math.Cos((double)ControlLoop / 100.0));
                    Data[2] = (float)(2.0 * Math.Sin((double)ControlLoop / 200.0));
                    Data[3] = (float)(2.0 * Math.Cos((double)ControlLoop / 200.0));
                    Data[4] = (float)(15.0 * Math.Sin((double)ControlLoop / 400.0));
                    Data[5] = (float)(15.0 * Math.Cos((double)ControlLoop / 400.0));

                    for (int i = 0; i < 6; i++)
                    {
                        point[i] = new PointF(ControlLoop, Data[i]);
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[i].PointData.Add(point[i]);
                    }
                    if (m_chkAutoXAxisFit)
                    {
                        c1Chart1.ChartArea.AxisX.Max = ControlLoop;
                        c1Chart1.ChartArea.AxisX.Min = (double)ControlLoop - m_XAxisAutoRange;
                    }

                    
                   

                    ControlLoop++;
                    if (ControlLoop > m_ClearChartX)
                    {
                        ControlLoop = 0;
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].PointData.Clear();
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[1].PointData.Clear();
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[2].PointData.Clear();
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[3].PointData.Clear();
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[4].PointData.Clear();
                        c1Chart1.ChartGroups.Group0.ChartData.SeriesList[5].PointData.Clear();
                    }

                }
                

                
            }

            else
            {

            }

            
            
        }

        private void btnAutoXAxisFit_Click(object sender, EventArgs e)
        {
            m_chkAutoXAxisFit = true;
            m_XAxisAutoRange = double.Parse(tbXAxisAutoRange.Text);
        }

        private void btnSetClearChartX_Click(object sender, EventArgs e)
        {
            m_ClearChartX = double.Parse(tbClearChartPointX.Text);
        }

        private void C1ChartFormClass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }


    }
}
