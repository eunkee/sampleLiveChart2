namespace sampleLiveChart2
{
    partial class UserControlChartNumberVertical
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
            this.panelCase1 = new System.Windows.Forms.Panel();
            this.panelCase2 = new System.Windows.Forms.Panel();
            this.panelCase3 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelData1 = new System.Windows.Forms.Label();
            this.labelCase1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelData2 = new System.Windows.Forms.Label();
            this.labelCase2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelData3 = new System.Windows.Forms.Label();
            this.labelCase3 = new System.Windows.Forms.Label();
            this.autoScaleLabelTitle3 = new sampleLiveChart2.AutoScaleLabel();
            this.autoScaleLabelTitle2 = new sampleLiveChart2.AutoScaleLabel();
            this.autoScaleLabelTitle1 = new sampleLiveChart2.AutoScaleLabel();
            this.panelCase1.SuspendLayout();
            this.panelCase2.SuspendLayout();
            this.panelCase3.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCase1
            // 
            this.panelCase1.Controls.Add(this.tableLayoutPanel1);
            this.panelCase1.Controls.Add(this.autoScaleLabelTitle1);
            this.panelCase1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCase1.Location = new System.Drawing.Point(5, 20);
            this.panelCase1.Name = "panelCase1";
            this.panelCase1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.panelCase1.Size = new System.Drawing.Size(115, 100);
            this.panelCase1.TabIndex = 9;
            // 
            // panelCase2
            // 
            this.panelCase2.Controls.Add(this.tableLayoutPanel2);
            this.panelCase2.Controls.Add(this.autoScaleLabelTitle2);
            this.panelCase2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCase2.Location = new System.Drawing.Point(5, 120);
            this.panelCase2.Name = "panelCase2";
            this.panelCase2.Size = new System.Drawing.Size(115, 100);
            this.panelCase2.TabIndex = 14;
            // 
            // panelCase3
            // 
            this.panelCase3.Controls.Add(this.tableLayoutPanel3);
            this.panelCase3.Controls.Add(this.autoScaleLabelTitle3);
            this.panelCase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCase3.Location = new System.Drawing.Point(5, 220);
            this.panelCase3.Name = "panelCase3";
            this.panelCase3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelCase3.Size = new System.Drawing.Size(115, 100);
            this.panelCase3.TabIndex = 15;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.panelMain.Controls.Add(this.panelCase3);
            this.panelMain.Controls.Add(this.panelCase2);
            this.panelMain.Controls.Add(this.panelCase1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(5, 20, 5, 20);
            this.panelMain.Size = new System.Drawing.Size(125, 340);
            this.panelMain.TabIndex = 16;
            this.panelMain.SizeChanged += new System.EventHandler(this.Panel4_SizeChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Controls.Add(this.labelData1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCase1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(115, 66);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // labelData1
            // 
            this.labelData1.AutoSize = true;
            this.labelData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelData1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 15.25F);
            this.labelData1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.labelData1.Location = new System.Drawing.Point(0, 0);
            this.labelData1.Margin = new System.Windows.Forms.Padding(0);
            this.labelData1.Name = "labelData1";
            this.labelData1.Size = new System.Drawing.Size(72, 66);
            this.labelData1.TabIndex = 13;
            this.labelData1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCase1
            // 
            this.labelCase1.AutoSize = true;
            this.labelCase1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCase1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F);
            this.labelCase1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.labelCase1.Location = new System.Drawing.Point(72, 0);
            this.labelCase1.Margin = new System.Windows.Forms.Padding(0);
            this.labelCase1.Name = "labelCase1";
            this.labelCase1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelCase1.Size = new System.Drawing.Size(43, 66);
            this.labelCase1.TabIndex = 12;
            this.labelCase1.Text = "Cases";
            this.labelCase1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Controls.Add(this.labelData2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelCase2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(115, 71);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // labelData2
            // 
            this.labelData2.AutoSize = true;
            this.labelData2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelData2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 15.25F);
            this.labelData2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.labelData2.Location = new System.Drawing.Point(0, 0);
            this.labelData2.Margin = new System.Windows.Forms.Padding(0);
            this.labelData2.Name = "labelData2";
            this.labelData2.Size = new System.Drawing.Size(72, 71);
            this.labelData2.TabIndex = 13;
            this.labelData2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCase2
            // 
            this.labelCase2.AutoSize = true;
            this.labelCase2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCase2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F);
            this.labelCase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.labelCase2.Location = new System.Drawing.Point(72, 0);
            this.labelCase2.Margin = new System.Windows.Forms.Padding(0);
            this.labelCase2.Name = "labelCase2";
            this.labelCase2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelCase2.Size = new System.Drawing.Size(43, 71);
            this.labelCase2.TabIndex = 12;
            this.labelCase2.Text = "Cases";
            this.labelCase2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.Controls.Add(this.labelData3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelCase3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 34);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(115, 66);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // labelData3
            // 
            this.labelData3.AutoSize = true;
            this.labelData3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelData3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 15.25F);
            this.labelData3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.labelData3.Location = new System.Drawing.Point(0, 0);
            this.labelData3.Margin = new System.Windows.Forms.Padding(0);
            this.labelData3.Name = "labelData3";
            this.labelData3.Size = new System.Drawing.Size(72, 66);
            this.labelData3.TabIndex = 13;
            this.labelData3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCase3
            // 
            this.labelCase3.AutoSize = true;
            this.labelCase3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCase3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.75F);
            this.labelCase3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.labelCase3.Location = new System.Drawing.Point(72, 0);
            this.labelCase3.Margin = new System.Windows.Forms.Padding(0);
            this.labelCase3.Name = "labelCase3";
            this.labelCase3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.labelCase3.Size = new System.Drawing.Size(43, 66);
            this.labelCase3.TabIndex = 12;
            this.labelCase3.Text = "Cases";
            this.labelCase3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // autoScaleLabelTitle3
            // 
            this.autoScaleLabelTitle3.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoScaleLabelTitle3.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12.25F);
            this.autoScaleLabelTitle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.autoScaleLabelTitle3.Location = new System.Drawing.Point(0, 5);
            this.autoScaleLabelTitle3.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.autoScaleLabelTitle3.Name = "autoScaleLabelTitle3";
            this.autoScaleLabelTitle3.Size = new System.Drawing.Size(115, 29);
            this.autoScaleLabelTitle3.TabIndex = 12;
            this.autoScaleLabelTitle3.Text = " ";
            // 
            // autoScaleLabelTitle2
            // 
            this.autoScaleLabelTitle2.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoScaleLabelTitle2.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12.25F);
            this.autoScaleLabelTitle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.autoScaleLabelTitle2.Location = new System.Drawing.Point(0, 0);
            this.autoScaleLabelTitle2.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.autoScaleLabelTitle2.Name = "autoScaleLabelTitle2";
            this.autoScaleLabelTitle2.Size = new System.Drawing.Size(115, 29);
            this.autoScaleLabelTitle2.TabIndex = 12;
            this.autoScaleLabelTitle2.Text = " ";
            // 
            // autoScaleLabelTitle1
            // 
            this.autoScaleLabelTitle1.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoScaleLabelTitle1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12.25F);
            this.autoScaleLabelTitle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(90)))), ((int)(((byte)(108)))));
            this.autoScaleLabelTitle1.Location = new System.Drawing.Point(0, 0);
            this.autoScaleLabelTitle1.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.autoScaleLabelTitle1.Name = "autoScaleLabelTitle1";
            this.autoScaleLabelTitle1.Size = new System.Drawing.Size(115, 29);
            this.autoScaleLabelTitle1.TabIndex = 10;
            this.autoScaleLabelTitle1.Text = " ";
            // 
            // UserControlChartNumberVertical
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(3, 13, 3, 13);
            this.Name = "UserControlChartNumberVertical";
            this.Size = new System.Drawing.Size(125, 340);
            this.panelCase1.ResumeLayout(false);
            this.panelCase2.ResumeLayout(false);
            this.panelCase3.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCase1;
        private System.Windows.Forms.Panel panelCase2;
        private System.Windows.Forms.Panel panelCase3;
        private System.Windows.Forms.Panel panelMain;
        private AutoScaleLabel autoScaleLabelTitle1;
        private AutoScaleLabel autoScaleLabelTitle2;
        private AutoScaleLabel autoScaleLabelTitle3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelData1;
        private System.Windows.Forms.Label labelCase1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelData2;
        private System.Windows.Forms.Label labelCase2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelData3;
        private System.Windows.Forms.Label labelCase3;
    }
}
