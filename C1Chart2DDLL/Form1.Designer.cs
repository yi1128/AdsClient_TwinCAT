namespace C1Chart2DDLL
{
    partial class C1ChartFormClass
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C1ChartFormClass));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.tbY2RangeMax = new System.Windows.Forms.TextBox();
            this.tbY1RangeMax = new System.Windows.Forms.TextBox();
            this.tbY2RangeMin = new System.Windows.Forms.TextBox();
            this.tbXRangeMax = new System.Windows.Forms.TextBox();
            this.tbAddY2Axis = new System.Windows.Forms.TextBox();
            this.tbAddY1Axis = new System.Windows.Forms.TextBox();
            this.tbAddXAxis = new System.Windows.Forms.TextBox();
            this.tbY1RangeMin = new System.Windows.Forms.TextBox();
            this.tbXRangeMin = new System.Windows.Forms.TextBox();
            this.btnPlusY2Axis = new System.Windows.Forms.Button();
            this.btnPlusY1Axis = new System.Windows.Forms.Button();
            this.btnMinusY2Axis = new System.Windows.Forms.Button();
            this.btnYRange = new System.Windows.Forms.Button();
            this.btnMinusY1Axis = new System.Windows.Forms.Button();
            this.btnPlusXAxis = new System.Windows.Forms.Button();
            this.btnMinusXAxis = new System.Windows.Forms.Button();
            this.btnXRange = new System.Windows.Forms.Button();
            this.btnYFit = new System.Windows.Forms.Button();
            this.btnGetRangeXY = new System.Windows.Forms.Button();
            this.btnXFit = new System.Windows.Forms.Button();
            this.btnClearChart = new System.Windows.Forms.Button();
            this.btnMeasureDataRun = new System.Windows.Forms.Button();
            this.btnDemoRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAutoXAxisFit = new System.Windows.Forms.Button();
            this.tbXAxisAutoRange = new System.Windows.Forms.TextBox();
            this.tbClearChartPointX = new System.Windows.Forms.TextBox();
            this.btnSetClearChartX = new System.Windows.Forms.Button();
            this.btnDemoRun3D = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.Location = new System.Drawing.Point(170, 12);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(1058, 610);
            this.c1Chart1.TabIndex = 0;
            // 
            // tbY2RangeMax
            // 
            this.tbY2RangeMax.Location = new System.Drawing.Point(90, 258);
            this.tbY2RangeMax.Name = "tbY2RangeMax";
            this.tbY2RangeMax.Size = new System.Drawing.Size(74, 21);
            this.tbY2RangeMax.TabIndex = 21;
            this.tbY2RangeMax.Text = "100";
            // 
            // tbY1RangeMax
            // 
            this.tbY1RangeMax.Location = new System.Drawing.Point(90, 204);
            this.tbY1RangeMax.Name = "tbY1RangeMax";
            this.tbY1RangeMax.Size = new System.Drawing.Size(74, 21);
            this.tbY1RangeMax.TabIndex = 22;
            this.tbY1RangeMax.Text = "100";
            // 
            // tbY2RangeMin
            // 
            this.tbY2RangeMin.Location = new System.Drawing.Point(12, 258);
            this.tbY2RangeMin.Name = "tbY2RangeMin";
            this.tbY2RangeMin.Size = new System.Drawing.Size(74, 21);
            this.tbY2RangeMin.TabIndex = 19;
            this.tbY2RangeMin.Text = "0";
            // 
            // tbXRangeMax
            // 
            this.tbXRangeMax.Location = new System.Drawing.Point(90, 122);
            this.tbXRangeMax.Name = "tbXRangeMax";
            this.tbXRangeMax.Size = new System.Drawing.Size(74, 21);
            this.tbXRangeMax.TabIndex = 20;
            this.tbXRangeMax.Text = "100";
            // 
            // tbAddY2Axis
            // 
            this.tbAddY2Axis.Location = new System.Drawing.Point(50, 284);
            this.tbAddY2Axis.Name = "tbAddY2Axis";
            this.tbAddY2Axis.Size = new System.Drawing.Size(76, 21);
            this.tbAddY2Axis.TabIndex = 26;
            this.tbAddY2Axis.Text = "1";
            // 
            // tbAddY1Axis
            // 
            this.tbAddY1Axis.Location = new System.Drawing.Point(50, 231);
            this.tbAddY1Axis.Name = "tbAddY1Axis";
            this.tbAddY1Axis.Size = new System.Drawing.Size(76, 21);
            this.tbAddY1Axis.TabIndex = 27;
            this.tbAddY1Axis.Text = "1";
            // 
            // tbAddXAxis
            // 
            this.tbAddXAxis.Location = new System.Drawing.Point(50, 148);
            this.tbAddXAxis.Name = "tbAddXAxis";
            this.tbAddXAxis.Size = new System.Drawing.Size(76, 21);
            this.tbAddXAxis.TabIndex = 25;
            this.tbAddXAxis.Text = "1";
            // 
            // tbY1RangeMin
            // 
            this.tbY1RangeMin.Location = new System.Drawing.Point(12, 204);
            this.tbY1RangeMin.Name = "tbY1RangeMin";
            this.tbY1RangeMin.Size = new System.Drawing.Size(74, 21);
            this.tbY1RangeMin.TabIndex = 23;
            this.tbY1RangeMin.Text = "0";
            // 
            // tbXRangeMin
            // 
            this.tbXRangeMin.Location = new System.Drawing.Point(12, 122);
            this.tbXRangeMin.Name = "tbXRangeMin";
            this.tbXRangeMin.Size = new System.Drawing.Size(74, 21);
            this.tbXRangeMin.TabIndex = 24;
            this.tbXRangeMin.Text = "0";
            // 
            // btnPlusY2Axis
            // 
            this.btnPlusY2Axis.Location = new System.Drawing.Point(132, 283);
            this.btnPlusY2Axis.Name = "btnPlusY2Axis";
            this.btnPlusY2Axis.Size = new System.Drawing.Size(32, 23);
            this.btnPlusY2Axis.TabIndex = 16;
            this.btnPlusY2Axis.Text = "(+)";
            this.btnPlusY2Axis.UseVisualStyleBackColor = true;
            this.btnPlusY2Axis.Click += new System.EventHandler(this.btnPlusY2Axis_Click);
            // 
            // btnPlusY1Axis
            // 
            this.btnPlusY1Axis.Location = new System.Drawing.Point(132, 230);
            this.btnPlusY1Axis.Name = "btnPlusY1Axis";
            this.btnPlusY1Axis.Size = new System.Drawing.Size(32, 23);
            this.btnPlusY1Axis.TabIndex = 17;
            this.btnPlusY1Axis.Text = "(+)";
            this.btnPlusY1Axis.UseVisualStyleBackColor = true;
            this.btnPlusY1Axis.Click += new System.EventHandler(this.btnPlusY1Axis_Click);
            // 
            // btnMinusY2Axis
            // 
            this.btnMinusY2Axis.Location = new System.Drawing.Point(12, 283);
            this.btnMinusY2Axis.Name = "btnMinusY2Axis";
            this.btnMinusY2Axis.Size = new System.Drawing.Size(32, 23);
            this.btnMinusY2Axis.TabIndex = 7;
            this.btnMinusY2Axis.Text = "(-)";
            this.btnMinusY2Axis.UseVisualStyleBackColor = true;
            this.btnMinusY2Axis.Click += new System.EventHandler(this.btnMinusY2Axis_Click);
            // 
            // btnYRange
            // 
            this.btnYRange.Location = new System.Drawing.Point(12, 174);
            this.btnYRange.Name = "btnYRange";
            this.btnYRange.Size = new System.Drawing.Size(152, 23);
            this.btnYRange.TabIndex = 8;
            this.btnYRange.Text = "Set Y-Axis Range";
            this.btnYRange.UseVisualStyleBackColor = true;
            this.btnYRange.Click += new System.EventHandler(this.btnYRange_Click);
            // 
            // btnMinusY1Axis
            // 
            this.btnMinusY1Axis.Location = new System.Drawing.Point(12, 230);
            this.btnMinusY1Axis.Name = "btnMinusY1Axis";
            this.btnMinusY1Axis.Size = new System.Drawing.Size(32, 23);
            this.btnMinusY1Axis.TabIndex = 6;
            this.btnMinusY1Axis.Text = "(-)";
            this.btnMinusY1Axis.UseVisualStyleBackColor = true;
            this.btnMinusY1Axis.Click += new System.EventHandler(this.btnMinusY1Axis_Click);
            // 
            // btnPlusXAxis
            // 
            this.btnPlusXAxis.Location = new System.Drawing.Point(132, 147);
            this.btnPlusXAxis.Name = "btnPlusXAxis";
            this.btnPlusXAxis.Size = new System.Drawing.Size(32, 23);
            this.btnPlusXAxis.TabIndex = 4;
            this.btnPlusXAxis.Text = "(+)";
            this.btnPlusXAxis.UseVisualStyleBackColor = true;
            this.btnPlusXAxis.Click += new System.EventHandler(this.btnPlusXAxis_Click);
            // 
            // btnMinusXAxis
            // 
            this.btnMinusXAxis.Location = new System.Drawing.Point(12, 147);
            this.btnMinusXAxis.Name = "btnMinusXAxis";
            this.btnMinusXAxis.Size = new System.Drawing.Size(32, 23);
            this.btnMinusXAxis.TabIndex = 5;
            this.btnMinusXAxis.Text = "(-)";
            this.btnMinusXAxis.UseVisualStyleBackColor = true;
            this.btnMinusXAxis.Click += new System.EventHandler(this.btnMinusXAxis_Click);
            // 
            // btnXRange
            // 
            this.btnXRange.Location = new System.Drawing.Point(12, 92);
            this.btnXRange.Name = "btnXRange";
            this.btnXRange.Size = new System.Drawing.Size(152, 23);
            this.btnXRange.TabIndex = 9;
            this.btnXRange.Text = "Set X-Axis Range";
            this.btnXRange.UseVisualStyleBackColor = true;
            this.btnXRange.Click += new System.EventHandler(this.btnXRange_Click);
            // 
            // btnYFit
            // 
            this.btnYFit.Location = new System.Drawing.Point(12, 38);
            this.btnYFit.Name = "btnYFit";
            this.btnYFit.Size = new System.Drawing.Size(152, 23);
            this.btnYFit.TabIndex = 13;
            this.btnYFit.Text = "Fit Y-Axis";
            this.btnYFit.UseVisualStyleBackColor = true;
            this.btnYFit.Click += new System.EventHandler(this.btnYFit_Click);
            // 
            // btnGetRangeXY
            // 
            this.btnGetRangeXY.Location = new System.Drawing.Point(12, 63);
            this.btnGetRangeXY.Name = "btnGetRangeXY";
            this.btnGetRangeXY.Size = new System.Drawing.Size(152, 23);
            this.btnGetRangeXY.TabIndex = 14;
            this.btnGetRangeXY.Text = "Get XY-Range";
            this.btnGetRangeXY.UseVisualStyleBackColor = true;
            this.btnGetRangeXY.Click += new System.EventHandler(this.btnGetRangeXY_Click);
            // 
            // btnXFit
            // 
            this.btnXFit.Location = new System.Drawing.Point(12, 12);
            this.btnXFit.Name = "btnXFit";
            this.btnXFit.Size = new System.Drawing.Size(152, 23);
            this.btnXFit.TabIndex = 12;
            this.btnXFit.Text = "Fit X-Axis";
            this.btnXFit.UseVisualStyleBackColor = true;
            this.btnXFit.Click += new System.EventHandler(this.btnXFit_Click);
            // 
            // btnClearChart
            // 
            this.btnClearChart.Location = new System.Drawing.Point(12, 312);
            this.btnClearChart.Name = "btnClearChart";
            this.btnClearChart.Size = new System.Drawing.Size(152, 23);
            this.btnClearChart.TabIndex = 10;
            this.btnClearChart.Text = "Clear Chart";
            this.btnClearChart.UseVisualStyleBackColor = true;
            this.btnClearChart.Click += new System.EventHandler(this.btnClearChart_Click);
            // 
            // btnMeasureDataRun
            // 
            this.btnMeasureDataRun.Location = new System.Drawing.Point(12, 395);
            this.btnMeasureDataRun.Name = "btnMeasureDataRun";
            this.btnMeasureDataRun.Size = new System.Drawing.Size(152, 23);
            this.btnMeasureDataRun.TabIndex = 11;
            this.btnMeasureDataRun.Text = "Measure Run";
            this.btnMeasureDataRun.UseVisualStyleBackColor = true;
            this.btnMeasureDataRun.Click += new System.EventHandler(this.btnMeasureDataRun_Click);
            // 
            // btnDemoRun
            // 
            this.btnDemoRun.Location = new System.Drawing.Point(12, 341);
            this.btnDemoRun.Name = "btnDemoRun";
            this.btnDemoRun.Size = new System.Drawing.Size(152, 23);
            this.btnDemoRun.TabIndex = 15;
            this.btnDemoRun.Text = "Demo Run";
            this.btnDemoRun.UseVisualStyleBackColor = true;
            this.btnDemoRun.Click += new System.EventHandler(this.btnDemoRun_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAutoXAxisFit
            // 
            this.btnAutoXAxisFit.Location = new System.Drawing.Point(12, 424);
            this.btnAutoXAxisFit.Name = "btnAutoXAxisFit";
            this.btnAutoXAxisFit.Size = new System.Drawing.Size(152, 23);
            this.btnAutoXAxisFit.TabIndex = 12;
            this.btnAutoXAxisFit.Text = "Auto X-Axis Fit";
            this.btnAutoXAxisFit.UseVisualStyleBackColor = true;
            this.btnAutoXAxisFit.Click += new System.EventHandler(this.btnAutoXAxisFit_Click);
            // 
            // tbXAxisAutoRange
            // 
            this.tbXAxisAutoRange.Location = new System.Drawing.Point(12, 453);
            this.tbXAxisAutoRange.Name = "tbXAxisAutoRange";
            this.tbXAxisAutoRange.Size = new System.Drawing.Size(152, 21);
            this.tbXAxisAutoRange.TabIndex = 20;
            this.tbXAxisAutoRange.Text = "10000";
            // 
            // tbClearChartPointX
            // 
            this.tbClearChartPointX.Location = new System.Drawing.Point(12, 509);
            this.tbClearChartPointX.Name = "tbClearChartPointX";
            this.tbClearChartPointX.Size = new System.Drawing.Size(152, 21);
            this.tbClearChartPointX.TabIndex = 20;
            this.tbClearChartPointX.Text = "50000";
            // 
            // btnSetClearChartX
            // 
            this.btnSetClearChartX.Location = new System.Drawing.Point(12, 480);
            this.btnSetClearChartX.Name = "btnSetClearChartX";
            this.btnSetClearChartX.Size = new System.Drawing.Size(152, 23);
            this.btnSetClearChartX.TabIndex = 12;
            this.btnSetClearChartX.Text = "X-Axis Clear Range";
            this.btnSetClearChartX.UseVisualStyleBackColor = true;
            this.btnSetClearChartX.Click += new System.EventHandler(this.btnSetClearChartX_Click);
            // 
            // btnDemoRun3D
            // 
            this.btnDemoRun3D.Location = new System.Drawing.Point(12, 366);
            this.btnDemoRun3D.Name = "btnDemoRun3D";
            this.btnDemoRun3D.Size = new System.Drawing.Size(152, 23);
            this.btnDemoRun3D.TabIndex = 15;
            this.btnDemoRun3D.Text = "Demo Run 3D";
            this.btnDemoRun3D.UseVisualStyleBackColor = true;
            this.btnDemoRun3D.Click += new System.EventHandler(this.btnDemoRun3D_Click);
            // 
            // C1ChartFormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 604);
            this.Controls.Add(this.tbY2RangeMax);
            this.Controls.Add(this.tbY1RangeMax);
            this.Controls.Add(this.tbY2RangeMin);
            this.Controls.Add(this.tbClearChartPointX);
            this.Controls.Add(this.tbXAxisAutoRange);
            this.Controls.Add(this.tbXRangeMax);
            this.Controls.Add(this.tbAddY2Axis);
            this.Controls.Add(this.tbAddY1Axis);
            this.Controls.Add(this.tbAddXAxis);
            this.Controls.Add(this.tbY1RangeMin);
            this.Controls.Add(this.tbXRangeMin);
            this.Controls.Add(this.btnPlusY2Axis);
            this.Controls.Add(this.btnPlusY1Axis);
            this.Controls.Add(this.btnMinusY2Axis);
            this.Controls.Add(this.btnYRange);
            this.Controls.Add(this.btnMinusY1Axis);
            this.Controls.Add(this.btnPlusXAxis);
            this.Controls.Add(this.btnMinusXAxis);
            this.Controls.Add(this.btnXRange);
            this.Controls.Add(this.btnYFit);
            this.Controls.Add(this.btnGetRangeXY);
            this.Controls.Add(this.btnSetClearChartX);
            this.Controls.Add(this.btnAutoXAxisFit);
            this.Controls.Add(this.btnXFit);
            this.Controls.Add(this.btnClearChart);
            this.Controls.Add(this.btnMeasureDataRun);
            this.Controls.Add(this.btnDemoRun3D);
            this.Controls.Add(this.btnDemoRun);
            this.Controls.Add(this.c1Chart1);
            this.Name = "C1ChartFormClass";
            this.Text = "2D Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.C1ChartFormClass_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Chart.C1Chart c1Chart1;
        private System.Windows.Forms.TextBox tbY2RangeMax;
        private System.Windows.Forms.TextBox tbY1RangeMax;
        private System.Windows.Forms.TextBox tbY2RangeMin;
        private System.Windows.Forms.TextBox tbXRangeMax;
        private System.Windows.Forms.TextBox tbAddY2Axis;
        private System.Windows.Forms.TextBox tbAddY1Axis;
        private System.Windows.Forms.TextBox tbAddXAxis;
        private System.Windows.Forms.TextBox tbY1RangeMin;
        private System.Windows.Forms.TextBox tbXRangeMin;
        private System.Windows.Forms.Button btnPlusY2Axis;
        private System.Windows.Forms.Button btnPlusY1Axis;
        private System.Windows.Forms.Button btnMinusY2Axis;
        private System.Windows.Forms.Button btnYRange;
        private System.Windows.Forms.Button btnMinusY1Axis;
        private System.Windows.Forms.Button btnPlusXAxis;
        private System.Windows.Forms.Button btnMinusXAxis;
        private System.Windows.Forms.Button btnXRange;
        private System.Windows.Forms.Button btnYFit;
        private System.Windows.Forms.Button btnGetRangeXY;
        private System.Windows.Forms.Button btnXFit;
        private System.Windows.Forms.Button btnClearChart;
        private System.Windows.Forms.Button btnMeasureDataRun;
        private System.Windows.Forms.Button btnDemoRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAutoXAxisFit;
        private System.Windows.Forms.TextBox tbXAxisAutoRange;
        private System.Windows.Forms.TextBox tbClearChartPointX;
        private System.Windows.Forms.Button btnSetClearChartX;
        private System.Windows.Forms.Button btnDemoRun3D;
    }
}

