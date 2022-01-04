using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1Chart2DDLL;
//using ChartFormClassDLL;

namespace DataGenerationProgram
{
    public partial class Form1 : Form
    {
        C1ChartFormClass m_Chart = new C1ChartFormClass();
        int cnt = 0;
        public Form1()
        {

            InitializeComponent();
        }

        private void btnaStart_Click(object sender, EventArgs e)
        {
            m_Chart.SetMode(0);
            m_Chart.Show();
            timer1.Interval = 30;
            timer1.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt ++;
            if (m_Chart.m_Mode == 0) m_Chart.AddPoint(cnt, cnt % 100, cnt % 23);
            else if (m_Chart.m_Mode == 1)
            {
                float[] y1 = new float[3];
                float[] y2 = new float[3];
                y1[0] = cnt % 20;
                y2[0] = cnt % 10;
                y1[1] = 20 + cnt % 10;
                y2[1] = 20 + cnt % 5;
                y1[2] = 40 + cnt % 21;
                y2[2] = 40 + cnt % 11;
                m_Chart.AddPoint3D(cnt, y1, y2);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 3) m_Chart.SetMode(0);
            else m_Chart.SetMode(1);
        }
    }
}
