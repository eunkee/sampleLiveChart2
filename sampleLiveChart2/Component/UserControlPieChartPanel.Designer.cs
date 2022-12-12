namespace sampleLiveChart2
{
    partial class UserControlPieChartPanel
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
            this.panelPieChart = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelPieChart
            // 
            this.panelPieChart.AutoScroll = true;
            this.panelPieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPieChart.Location = new System.Drawing.Point(170, 0);
            this.panelPieChart.Name = "panelPieChart";
            this.panelPieChart.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelPieChart.Size = new System.Drawing.Size(697, 636);
            this.panelPieChart.TabIndex = 26;
            // 
            // panelBottom
            // 
            this.panelBottom.AutoScroll = true;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 636);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Padding = new System.Windows.Forms.Padding(20, 20, 20, 15);
            this.panelBottom.Size = new System.Drawing.Size(867, 130);
            this.panelBottom.TabIndex = 27;
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Padding = new System.Windows.Forms.Padding(20, 15, 20, 20);
            this.panelSide.Size = new System.Drawing.Size(170, 636);
            this.panelSide.TabIndex = 28;
            // 
            // UserControlPieChartPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panelPieChart);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelBottom);
            this.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.Name = "UserControlPieChartPanel";
            this.Size = new System.Drawing.Size(867, 766);
            this.Load += new System.EventHandler(this.UserControlPieChartPanel_Load);
            this.SizeChanged += new System.EventHandler(this.UserControlPieChartPanel_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPieChart;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelSide;
    }
}
