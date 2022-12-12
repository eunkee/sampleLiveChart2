namespace sampleLiveChart2
{
    partial class UserControlGaugeChart
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelDashboard3 = new System.Windows.Forms.Panel();
            this.pieChartGauge3 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.panelDashboard2 = new System.Windows.Forms.Panel();
            this.pieChartGauge2 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.panelDashboard1 = new System.Windows.Forms.Panel();
            this.pieChartGauge1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            this.panelDashboard3.SuspendLayout();
            this.panelDashboard2.SuspendLayout();
            this.panelDashboard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDashboard3
            // 
            this.panelDashboard3.Controls.Add(this.pieChartGauge3);
            this.panelDashboard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard3.Location = new System.Drawing.Point(426, 0);
            this.panelDashboard3.Name = "panelDashboard3";
            this.panelDashboard3.Padding = new System.Windows.Forms.Padding(5);
            this.panelDashboard3.Size = new System.Drawing.Size(200, 279);
            this.panelDashboard3.TabIndex = 24;
            this.panelDashboard3.Visible = false;
            // 
            // pieChartGauge3
            // 
            this.pieChartGauge3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.pieChartGauge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartGauge3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.pieChartGauge3.InitialRotation = -90D;
            this.pieChartGauge3.IsClockwise = true;
            this.pieChartGauge3.Location = new System.Drawing.Point(5, 5);
            this.pieChartGauge3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.pieChartGauge3.MaxAngle = 360D;
            this.pieChartGauge3.Name = "pieChartGauge3";
            this.pieChartGauge3.Size = new System.Drawing.Size(190, 269);
            this.pieChartGauge3.TabIndex = 20;
            this.pieChartGauge3.Total = 100D;
            // 
            // panelDashboard2
            // 
            this.panelDashboard2.Controls.Add(this.pieChartGauge2);
            this.panelDashboard2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashboard2.Location = new System.Drawing.Point(212, 0);
            this.panelDashboard2.Name = "panelDashboard2";
            this.panelDashboard2.Padding = new System.Windows.Forms.Padding(5);
            this.panelDashboard2.Size = new System.Drawing.Size(214, 279);
            this.panelDashboard2.TabIndex = 23;
            this.panelDashboard2.Visible = false;
            // 
            // pieChartGauge2
            // 
            this.pieChartGauge2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.pieChartGauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartGauge2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.pieChartGauge2.InitialRotation = -90D;
            this.pieChartGauge2.IsClockwise = true;
            this.pieChartGauge2.Location = new System.Drawing.Point(5, 5);
            this.pieChartGauge2.Margin = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.pieChartGauge2.MaxAngle = 360D;
            this.pieChartGauge2.Name = "pieChartGauge2";
            this.pieChartGauge2.Size = new System.Drawing.Size(204, 269);
            this.pieChartGauge2.TabIndex = 19;
            this.pieChartGauge2.Total = 100D;
            // 
            // panelDashboard1
            // 
            this.panelDashboard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.panelDashboard1.Controls.Add(this.pieChartGauge1);
            this.panelDashboard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDashboard1.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard1.Name = "panelDashboard1";
            this.panelDashboard1.Padding = new System.Windows.Forms.Padding(5);
            this.panelDashboard1.Size = new System.Drawing.Size(212, 279);
            this.panelDashboard1.TabIndex = 22;
            this.panelDashboard1.Visible = false;
            // 
            // pieChartGauge1
            // 
            this.pieChartGauge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.pieChartGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartGauge1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.pieChartGauge1.InitialRotation = -90D;
            this.pieChartGauge1.IsClockwise = true;
            this.pieChartGauge1.Location = new System.Drawing.Point(5, 5);
            this.pieChartGauge1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.pieChartGauge1.MaxAngle = 360D;
            this.pieChartGauge1.Name = "pieChartGauge1";
            this.pieChartGauge1.Size = new System.Drawing.Size(202, 269);
            this.pieChartGauge1.TabIndex = 18;
            this.pieChartGauge1.Total = 100D;
            // 
            // UserControlGaugeChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panelDashboard3);
            this.Controls.Add(this.panelDashboard2);
            this.Controls.Add(this.panelDashboard1);
            this.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.Name = "UserControlGaugeChart";
            this.Size = new System.Drawing.Size(626, 279);
            this.SizeChanged += new System.EventHandler(this.UserControlGaugeChart_SizeChanged);
            this.panelDashboard3.ResumeLayout(false);
            this.panelDashboard2.ResumeLayout(false);
            this.panelDashboard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDashboard3;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChartGauge3;
        private System.Windows.Forms.Panel panelDashboard2;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChartGauge2;
        private System.Windows.Forms.Panel panelDashboard1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChartGauge1;
    }
}
