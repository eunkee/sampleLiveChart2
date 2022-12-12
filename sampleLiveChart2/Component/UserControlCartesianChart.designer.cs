namespace sampleLiveChart2
{
    partial class UserControlCartesianChart
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
            this.components = new System.ComponentModel.Container();
            this.PanelTemperature3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelTemperature2 = new System.Windows.Forms.Panel();
            this.pictureBoxButtonEndTimeDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonEndTimeUp = new System.Windows.Forms.PictureBox();
            this.PanelTemperature1 = new System.Windows.Forms.Panel();
            this.pictureBoxButtonStartTimeDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxButtonStartTimeUp = new System.Windows.Forms.PictureBox();
            this.labelTitleDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.PanelTemperature4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelTemperatureGraphCondition = new System.Windows.Forms.Label();
            this.LabelSearchConditionTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            this.rjDropdownMenu1 = new sampleLiveChart2.RJDropdownMenu(this.components);
            this.ChartClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rjButtonRadioCustom = new sampleLiveChart2.RJButton();
            this.rjButtonRadioMonth = new sampleLiveChart2.RJButton();
            this.rjButtonRadioWeek = new sampleLiveChart2.RJButton();
            this.rjButtonRadioToday = new sampleLiveChart2.RJButton();
            this.ButtonTemperatureClear = new sampleLiveChart2.RJButton();
            this.ButtonTemperatureSet = new sampleLiveChart2.RJButton();
            this.rjDateTimeChangerEnd = new sampleLiveChart2.RJDateTimeChanger();
            this.rjDatePickerEnd = new sampleLiveChart2.RJDatePicker();
            this.rjDateTimeChangerStart = new sampleLiveChart2.RJDateTimeChanger();
            this.rjDatePickerStart = new sampleLiveChart2.RJDatePicker();
            this.PanelTemperature3.SuspendLayout();
            this.PanelTemperature2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonEndTimeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonEndTimeUp)).BeginInit();
            this.PanelTemperature1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonStartTimeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonStartTimeUp)).BeginInit();
            this.panel1.SuspendLayout();
            this.PanelTemperature4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rjDropdownMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTemperature3
            // 
            this.PanelTemperature3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.PanelTemperature3.Controls.Add(this.ButtonTemperatureClear);
            this.PanelTemperature3.Controls.Add(this.ButtonTemperatureSet);
            this.PanelTemperature3.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTemperature3.Location = new System.Drawing.Point(560, 5);
            this.PanelTemperature3.Name = "PanelTemperature3";
            this.PanelTemperature3.Size = new System.Drawing.Size(168, 57);
            this.PanelTemperature3.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.label5.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(1, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "  ~ ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTemperature2
            // 
            this.PanelTemperature2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.PanelTemperature2.Controls.Add(this.pictureBoxButtonEndTimeDown);
            this.PanelTemperature2.Controls.Add(this.pictureBoxButtonEndTimeUp);
            this.PanelTemperature2.Controls.Add(this.label5);
            this.PanelTemperature2.Controls.Add(this.rjDateTimeChangerEnd);
            this.PanelTemperature2.Controls.Add(this.rjDatePickerEnd);
            this.PanelTemperature2.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTemperature2.Location = new System.Drawing.Point(286, 5);
            this.PanelTemperature2.Name = "PanelTemperature2";
            this.PanelTemperature2.Size = new System.Drawing.Size(274, 57);
            this.PanelTemperature2.TabIndex = 44;
            // 
            // pictureBoxButtonEndTimeDown
            // 
            this.pictureBoxButtonEndTimeDown.BackgroundImage = global::sampleLiveChart2.Properties.Resources.contens_arrow_dwon;
            this.pictureBoxButtonEndTimeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonEndTimeDown.Location = new System.Drawing.Point(237, 27);
            this.pictureBoxButtonEndTimeDown.Name = "pictureBoxButtonEndTimeDown";
            this.pictureBoxButtonEndTimeDown.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxButtonEndTimeDown.TabIndex = 39;
            this.pictureBoxButtonEndTimeDown.TabStop = false;
            this.pictureBoxButtonEndTimeDown.Click += new System.EventHandler(this.PictureBoxButtonEndTimeDown_Click);
            // 
            // pictureBoxButtonEndTimeUp
            // 
            this.pictureBoxButtonEndTimeUp.BackgroundImage = global::sampleLiveChart2.Properties.Resources.contens_arrow_up;
            this.pictureBoxButtonEndTimeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonEndTimeUp.Location = new System.Drawing.Point(237, 10);
            this.pictureBoxButtonEndTimeUp.Name = "pictureBoxButtonEndTimeUp";
            this.pictureBoxButtonEndTimeUp.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxButtonEndTimeUp.TabIndex = 38;
            this.pictureBoxButtonEndTimeUp.TabStop = false;
            this.pictureBoxButtonEndTimeUp.Click += new System.EventHandler(this.PictureBoxButtonEndTimeUp_Click);
            // 
            // PanelTemperature1
            // 
            this.PanelTemperature1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.PanelTemperature1.Controls.Add(this.pictureBoxButtonStartTimeDown);
            this.PanelTemperature1.Controls.Add(this.pictureBoxButtonStartTimeUp);
            this.PanelTemperature1.Controls.Add(this.labelTitleDate);
            this.PanelTemperature1.Controls.Add(this.rjDateTimeChangerStart);
            this.PanelTemperature1.Controls.Add(this.rjDatePickerStart);
            this.PanelTemperature1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelTemperature1.Location = new System.Drawing.Point(0, 5);
            this.PanelTemperature1.Name = "PanelTemperature1";
            this.PanelTemperature1.Size = new System.Drawing.Size(286, 57);
            this.PanelTemperature1.TabIndex = 43;
            // 
            // pictureBoxButtonStartTimeDown
            // 
            this.pictureBoxButtonStartTimeDown.BackgroundImage = global::sampleLiveChart2.Properties.Resources.contens_arrow_dwon;
            this.pictureBoxButtonStartTimeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonStartTimeDown.Location = new System.Drawing.Point(263, 27);
            this.pictureBoxButtonStartTimeDown.Name = "pictureBoxButtonStartTimeDown";
            this.pictureBoxButtonStartTimeDown.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxButtonStartTimeDown.TabIndex = 41;
            this.pictureBoxButtonStartTimeDown.TabStop = false;
            this.pictureBoxButtonStartTimeDown.Click += new System.EventHandler(this.PictureBoxButtonStartTimeDown_Click);
            // 
            // pictureBoxButtonStartTimeUp
            // 
            this.pictureBoxButtonStartTimeUp.BackgroundImage = global::sampleLiveChart2.Properties.Resources.contens_arrow_up;
            this.pictureBoxButtonStartTimeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxButtonStartTimeUp.Location = new System.Drawing.Point(263, 10);
            this.pictureBoxButtonStartTimeUp.Name = "pictureBoxButtonStartTimeUp";
            this.pictureBoxButtonStartTimeUp.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxButtonStartTimeUp.TabIndex = 40;
            this.pictureBoxButtonStartTimeUp.TabStop = false;
            this.pictureBoxButtonStartTimeUp.Click += new System.EventHandler(this.PictureBoxButtonStartTimeUp_Click);
            // 
            // labelTitleDate
            // 
            this.labelTitleDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.labelTitleDate.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F);
            this.labelTitleDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.labelTitleDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTitleDate.Location = new System.Drawing.Point(3, 16);
            this.labelTitleDate.Name = "labelTitleDate";
            this.labelTitleDate.Size = new System.Drawing.Size(51, 21);
            this.labelTitleDate.TabIndex = 30;
            this.labelTitleDate.Text = "Date";
            this.labelTitleDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.PanelTemperature3);
            this.panel1.Controls.Add(this.PanelTemperature2);
            this.panel1.Controls.Add(this.PanelTemperature1);
            this.panel1.Controls.Add(this.panelLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1104, 63);
            this.panel1.TabIndex = 32;
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(66)))));
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLine.Location = new System.Drawing.Point(0, 62);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(1104, 1);
            this.panelLine.TabIndex = 61;
            // 
            // PanelTemperature4
            // 
            this.PanelTemperature4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.PanelTemperature4.Controls.Add(this.rjButtonRadioCustom);
            this.PanelTemperature4.Controls.Add(this.rjButtonRadioMonth);
            this.PanelTemperature4.Controls.Add(this.rjButtonRadioWeek);
            this.PanelTemperature4.Controls.Add(this.rjButtonRadioToday);
            this.PanelTemperature4.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelTemperature4.Location = new System.Drawing.Point(796, 0);
            this.PanelTemperature4.Name = "PanelTemperature4";
            this.PanelTemperature4.Size = new System.Drawing.Size(308, 32);
            this.PanelTemperature4.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.panel2.Controls.Add(this.LabelTemperatureGraphCondition);
            this.panel2.Controls.Add(this.PanelTemperature4);
            this.panel2.Controls.Add(this.LabelSearchConditionTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 32);
            this.panel2.TabIndex = 33;
            // 
            // LabelTemperatureGraphCondition
            // 
            this.LabelTemperatureGraphCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.LabelTemperatureGraphCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTemperatureGraphCondition.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            this.LabelTemperatureGraphCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.LabelTemperatureGraphCondition.Location = new System.Drawing.Point(91, 0);
            this.LabelTemperatureGraphCondition.Name = "LabelTemperatureGraphCondition";
            this.LabelTemperatureGraphCondition.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.LabelTemperatureGraphCondition.Size = new System.Drawing.Size(705, 32);
            this.LabelTemperatureGraphCondition.TabIndex = 54;
            this.LabelTemperatureGraphCondition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelSearchConditionTitle
            // 
            this.LabelSearchConditionTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.LabelSearchConditionTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelSearchConditionTitle.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            this.LabelSearchConditionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.LabelSearchConditionTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelSearchConditionTitle.Name = "LabelSearchConditionTitle";
            this.LabelSearchConditionTitle.Padding = new System.Windows.Forms.Padding(15, 8, 0, 0);
            this.LabelSearchConditionTitle.Size = new System.Drawing.Size(91, 32);
            this.LabelSearchConditionTitle.TabIndex = 51;
            this.LabelSearchConditionTitle.Text = "Condition:";
            this.LabelSearchConditionTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 321);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 10);
            this.panel3.Size = new System.Drawing.Size(1104, 24);
            this.panel3.TabIndex = 36;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.cartesianChart1.ContextMenuStrip = this.rjDropdownMenu1;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(0, 95);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.cartesianChart1.Size = new System.Drawing.Size(1104, 226);
            this.cartesianChart1.TabIndex = 34;
            // 
            // rjDropdownMenu1
            // 
            this.rjDropdownMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDropdownMenu1.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rjDropdownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChartClearToolStripMenuItem,
            this.ZoomClearToolStripMenuItem});
            this.rjDropdownMenu1.Name = "rjDropdownMenu1";
            this.rjDropdownMenu1.Size = new System.Drawing.Size(173, 60);
            // 
            // ChartClearToolStripMenuItem
            // 
            this.ChartClearToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.ChartClearToolStripMenuItem.Name = "ChartClearToolStripMenuItem";
            this.ChartClearToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.ChartClearToolStripMenuItem.Text = "Chart Clear";
            this.ChartClearToolStripMenuItem.Click += new System.EventHandler(this.ChartClearToolStripMenuItem_Click);
            // 
            // ZoomClearToolStripMenuItem
            // 
            this.ZoomClearToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.ZoomClearToolStripMenuItem.Name = "ZoomClearToolStripMenuItem";
            this.ZoomClearToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.ZoomClearToolStripMenuItem.Text = "Zoom Clear";
            this.ZoomClearToolStripMenuItem.Click += new System.EventHandler(this.ZoomClearToolStripMenuItem_Click);
            // 
            // rjButtonRadioCustom
            // 
            this.rjButtonRadioCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioCustom.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioCustom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioCustom.BorderRadius = 13;
            this.rjButtonRadioCustom.BorderSize = 1;
            this.rjButtonRadioCustom.FlatAppearance.BorderSize = 0;
            this.rjButtonRadioCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonRadioCustom.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            this.rjButtonRadioCustom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioCustom.IsRadioDesign = false;
            this.rjButtonRadioCustom.Location = new System.Drawing.Point(220, 3);
            this.rjButtonRadioCustom.Name = "rjButtonRadioCustom";
            this.rjButtonRadioCustom.Size = new System.Drawing.Size(69, 25);
            this.rjButtonRadioCustom.TabIndex = 63;
            this.rjButtonRadioCustom.Text = "Custom";
            this.rjButtonRadioCustom.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioCustom.UseVisualStyleBackColor = false;
            this.rjButtonRadioCustom.Click += new System.EventHandler(this.RjButtonRadioCustom_Click);
            // 
            // rjButtonRadioMonth
            // 
            this.rjButtonRadioMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioMonth.BorderRadius = 13;
            this.rjButtonRadioMonth.BorderSize = 1;
            this.rjButtonRadioMonth.FlatAppearance.BorderSize = 0;
            this.rjButtonRadioMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonRadioMonth.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            this.rjButtonRadioMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioMonth.IsRadioDesign = false;
            this.rjButtonRadioMonth.Location = new System.Drawing.Point(148, 3);
            this.rjButtonRadioMonth.Name = "rjButtonRadioMonth";
            this.rjButtonRadioMonth.Size = new System.Drawing.Size(69, 25);
            this.rjButtonRadioMonth.TabIndex = 62;
            this.rjButtonRadioMonth.Text = "Month";
            this.rjButtonRadioMonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioMonth.UseVisualStyleBackColor = false;
            this.rjButtonRadioMonth.Click += new System.EventHandler(this.RjButtonRadioMonth_Click);
            // 
            // rjButtonRadioWeek
            // 
            this.rjButtonRadioWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioWeek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioWeek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioWeek.BorderRadius = 13;
            this.rjButtonRadioWeek.BorderSize = 1;
            this.rjButtonRadioWeek.FlatAppearance.BorderSize = 0;
            this.rjButtonRadioWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonRadioWeek.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            this.rjButtonRadioWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioWeek.IsRadioDesign = false;
            this.rjButtonRadioWeek.Location = new System.Drawing.Point(76, 3);
            this.rjButtonRadioWeek.Name = "rjButtonRadioWeek";
            this.rjButtonRadioWeek.Size = new System.Drawing.Size(69, 25);
            this.rjButtonRadioWeek.TabIndex = 61;
            this.rjButtonRadioWeek.Text = "1 Week";
            this.rjButtonRadioWeek.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioWeek.UseVisualStyleBackColor = false;
            this.rjButtonRadioWeek.Click += new System.EventHandler(this.RjButtonRadioWeek_Click);
            // 
            // rjButtonRadioToday
            // 
            this.rjButtonRadioToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioToday.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjButtonRadioToday.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioToday.BorderRadius = 13;
            this.rjButtonRadioToday.BorderSize = 1;
            this.rjButtonRadioToday.FlatAppearance.BorderSize = 0;
            this.rjButtonRadioToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonRadioToday.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            this.rjButtonRadioToday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioToday.IsRadioDesign = false;
            this.rjButtonRadioToday.Location = new System.Drawing.Point(4, 3);
            this.rjButtonRadioToday.Name = "rjButtonRadioToday";
            this.rjButtonRadioToday.Size = new System.Drawing.Size(69, 25);
            this.rjButtonRadioToday.TabIndex = 60;
            this.rjButtonRadioToday.Text = "Today";
            this.rjButtonRadioToday.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.rjButtonRadioToday.UseVisualStyleBackColor = false;
            this.rjButtonRadioToday.Click += new System.EventHandler(this.RjButtonRadioToday_Click);
            // 
            // ButtonTemperatureClear
            // 
            this.ButtonTemperatureClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.ButtonTemperatureClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.ButtonTemperatureClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.ButtonTemperatureClear.BorderRadius = 10;
            this.ButtonTemperatureClear.BorderSize = 1;
            this.ButtonTemperatureClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.ButtonTemperatureClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ButtonTemperatureClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ButtonTemperatureClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTemperatureClear.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 11.25F);
            this.ButtonTemperatureClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.ButtonTemperatureClear.IsRadioDesign = false;
            this.ButtonTemperatureClear.Location = new System.Drawing.Point(88, 10);
            this.ButtonTemperatureClear.Name = "ButtonTemperatureClear";
            this.ButtonTemperatureClear.Size = new System.Drawing.Size(73, 34);
            this.ButtonTemperatureClear.TabIndex = 46;
            this.ButtonTemperatureClear.Text = "Clear";
            this.ButtonTemperatureClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.ButtonTemperatureClear.UseVisualStyleBackColor = false;
            this.ButtonTemperatureClear.Click += new System.EventHandler(this.ButtonTemperatureClear_Click);
            // 
            // ButtonTemperatureSet
            // 
            this.ButtonTemperatureSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.ButtonTemperatureSet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.ButtonTemperatureSet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.ButtonTemperatureSet.BorderRadius = 10;
            this.ButtonTemperatureSet.BorderSize = 0;
            this.ButtonTemperatureSet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.ButtonTemperatureSet.FlatAppearance.BorderSize = 0;
            this.ButtonTemperatureSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.ButtonTemperatureSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(79)))), ((int)(((byte)(94)))));
            this.ButtonTemperatureSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTemperatureSet.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 11.25F);
            this.ButtonTemperatureSet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.ButtonTemperatureSet.IsRadioDesign = false;
            this.ButtonTemperatureSet.Location = new System.Drawing.Point(6, 10);
            this.ButtonTemperatureSet.Name = "ButtonTemperatureSet";
            this.ButtonTemperatureSet.Size = new System.Drawing.Size(73, 34);
            this.ButtonTemperatureSet.TabIndex = 45;
            this.ButtonTemperatureSet.Text = "Set";
            this.ButtonTemperatureSet.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(133)))), ((int)(((byte)(161)))));
            this.ButtonTemperatureSet.UseVisualStyleBackColor = false;
            this.ButtonTemperatureSet.Click += new System.EventHandler(this.ButtonTemperatureSet_Click);
            // 
            // rjDateTimeChangerEnd
            // 
            this.rjDateTimeChangerEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(112)))));
            this.rjDateTimeChangerEnd.BorderSize = 1;
            this.rjDateTimeChangerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjDateTimeChangerEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDateTimeChangerEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDateTimeChangerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDateTimeChangerEnd.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDateTimeChangerEnd.CustomFormat = "HH:mm:ss";
            this.rjDateTimeChangerEnd.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F);
            this.rjDateTimeChangerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDateTimeChangerEnd.Location = new System.Drawing.Point(154, 10);
            this.rjDateTimeChangerEnd.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDateTimeChangerEnd.Name = "rjDateTimeChangerEnd";
            this.rjDateTimeChangerEnd.ShowUpDown = true;
            this.rjDateTimeChangerEnd.Size = new System.Drawing.Size(102, 35);
            this.rjDateTimeChangerEnd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjDateTimeChangerEnd.TabIndex = 29;
            this.rjDateTimeChangerEnd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            // 
            // rjDatePickerEnd
            // 
            this.rjDatePickerEnd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(112)))));
            this.rjDatePickerEnd.BorderSize = 1;
            this.rjDatePickerEnd.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjDatePickerEnd.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDatePickerEnd.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDatePickerEnd.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDatePickerEnd.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDatePickerEnd.CustomFormat = "yyyy-MM-dd";
            this.rjDatePickerEnd.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F);
            this.rjDatePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDatePickerEnd.Location = new System.Drawing.Point(31, 10);
            this.rjDatePickerEnd.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePickerEnd.Name = "rjDatePickerEnd";
            this.rjDatePickerEnd.Size = new System.Drawing.Size(117, 35);
            this.rjDatePickerEnd.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjDatePickerEnd.TabIndex = 28;
            this.rjDatePickerEnd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            // 
            // rjDateTimeChangerStart
            // 
            this.rjDateTimeChangerStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(112)))));
            this.rjDateTimeChangerStart.BorderSize = 1;
            this.rjDateTimeChangerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjDateTimeChangerStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDateTimeChangerStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDateTimeChangerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDateTimeChangerStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDateTimeChangerStart.CustomFormat = "HH:mm:ss";
            this.rjDateTimeChangerStart.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F);
            this.rjDateTimeChangerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDateTimeChangerStart.Location = new System.Drawing.Point(180, 10);
            this.rjDateTimeChangerStart.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDateTimeChangerStart.Name = "rjDateTimeChangerStart";
            this.rjDateTimeChangerStart.ShowUpDown = true;
            this.rjDateTimeChangerStart.Size = new System.Drawing.Size(102, 35);
            this.rjDateTimeChangerStart.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjDateTimeChangerStart.TabIndex = 27;
            this.rjDateTimeChangerStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            // 
            // rjDatePickerStart
            // 
            this.rjDatePickerStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(87)))), ((int)(((byte)(112)))));
            this.rjDatePickerStart.BorderSize = 1;
            this.rjDatePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjDatePickerStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDatePickerStart.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.rjDatePickerStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDatePickerStart.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(190)))), ((int)(((byte)(202)))));
            this.rjDatePickerStart.CustomFormat = "yyyy-MM-dd";
            this.rjDatePickerStart.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F);
            this.rjDatePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rjDatePickerStart.Location = new System.Drawing.Point(57, 10);
            this.rjDatePickerStart.MinimumSize = new System.Drawing.Size(4, 35);
            this.rjDatePickerStart.Name = "rjDatePickerStart";
            this.rjDatePickerStart.Size = new System.Drawing.Size(117, 35);
            this.rjDatePickerStart.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.rjDatePickerStart.TabIndex = 26;
            this.rjDatePickerStart.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            // 
            // UserControlCartesianChart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Noto Sans CJK KR Regular", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlCartesianChart";
            this.Size = new System.Drawing.Size(1104, 345);
            this.Load += new System.EventHandler(this.UserControlGraphTemperature_Load);
            this.SizeChanged += new System.EventHandler(this.UserControlGraphTemperature_SizeChanged);
            this.PanelTemperature3.ResumeLayout(false);
            this.PanelTemperature2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonEndTimeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonEndTimeUp)).EndInit();
            this.PanelTemperature1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonStartTimeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxButtonStartTimeUp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PanelTemperature4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.rjDropdownMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTemperature3;
        private RJButton ButtonTemperatureClear;
        private RJButton ButtonTemperatureSet;
        private System.Windows.Forms.Label label5;
        private RJDateTimeChanger rjDateTimeChangerEnd;
        private RJDatePicker rjDatePickerEnd;
        private System.Windows.Forms.Panel PanelTemperature2;
        private RJDateTimeChanger rjDateTimeChangerStart;
        private RJDatePicker rjDatePickerStart;
        private System.Windows.Forms.Panel PanelTemperature1;
        private System.Windows.Forms.Label labelTitleDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelTemperature4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LabelSearchConditionTitle;
        private System.Windows.Forms.Label LabelTemperatureGraphCondition;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel panel3;
        private RJDropdownMenu rjDropdownMenu1;
        private System.Windows.Forms.ToolStripMenuItem ChartClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomClearToolStripMenuItem;
        private RJButton rjButtonRadioToday;
        private RJButton rjButtonRadioCustom;
        private RJButton rjButtonRadioMonth;
        private RJButton rjButtonRadioWeek;
        private System.Windows.Forms.PictureBox pictureBoxButtonEndTimeDown;
        private System.Windows.Forms.PictureBox pictureBoxButtonEndTimeUp;
        private System.Windows.Forms.PictureBox pictureBoxButtonStartTimeDown;
        private System.Windows.Forms.PictureBox pictureBoxButtonStartTimeUp;
        private System.Windows.Forms.Panel panelLine;
    }
}
