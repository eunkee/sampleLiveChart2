using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlPieChartPanel : UserControl
    {
        private readonly UserControlPieChart userControlPieChart = new UserControlPieChart();
        private readonly UserControlChartNumberHorizontal userControlNumberBottom = new UserControlChartNumberHorizontal();
        private readonly UserControlChartNumberVertical userControlNumberSide = new UserControlChartNumberVertical();

        public UserControlPieChartPanel()
        {
            InitializeComponent();
        }

        private void UserControlPieChartPanel_Load(object sender, EventArgs e)
        {
            panelPieChart.Controls.Add(userControlPieChart);
            userControlPieChart.Dock = System.Windows.Forms.DockStyle.Fill;

            panelBottom.Controls.Add(userControlNumberBottom);
            userControlNumberBottom.Dock = System.Windows.Forms.DockStyle.Fill;

            panelSide.Controls.Add(userControlNumberSide);
            userControlNumberSide.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public void SetDrawPieChart(List<CHART_PIE_PARAM> list, List<CHART_NUMBER_PARAM> list2, string title)
        {
            if (userControlPieChart != null)
            {
                userControlPieChart.SetDrawPieChart(list, title);
            }

            if (userControlNumberBottom != null)
            {
                userControlNumberBottom.SetDrawData(list2, true);
            }

            if (userControlNumberSide != null)
            {
                userControlNumberSide.SetDrawData(list2, true);
            }
        }


        public void UpdateValuePieChart(List<CHART_PIE_PARAM> list, List<CHART_NUMBER_PARAM> list2)
        {
            if (userControlPieChart != null)
            {
                userControlPieChart.UpdateValuePieChart(list);
            }

            if (userControlNumberBottom != null)
            {
                userControlNumberBottom.SetDrawData(list2, true);
            }

            if (userControlNumberSide != null)
            {
                userControlNumberSide.SetDrawData(list2, true);
            }
        }

        private void UserControlPieChartPanel_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > this.Height)
            {
                panelBottom.Visible = false;
                panelSide.Visible = true;
            }
            else
            {
                panelBottom.Visible = true;
                panelSide.Visible = false;
            }
            panelPieChart.BringToFront();
        }
    }
}