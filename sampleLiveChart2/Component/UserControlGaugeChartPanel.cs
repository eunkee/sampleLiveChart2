using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlGaugeChartPanel : UserControl
    {
        private readonly UserControlGaugeChart userControlGaugeChart = new UserControlGaugeChart();
        private readonly UserControlChartNumberHorizontal userControlNumberBottom = new UserControlChartNumberHorizontal();
        private readonly UserControlChartNumberVertical userControlNumberSide = new UserControlChartNumberVertical();

        public UserControlGaugeChartPanel()
        {
            InitializeComponent();
        }

        private void UserControlGaugeChartPanel_Load(object sender, EventArgs e)
        {
            panelPieChart.Controls.Add(userControlGaugeChart);
            userControlGaugeChart.Dock = System.Windows.Forms.DockStyle.Fill;

            panelBottom.Controls.Add(userControlNumberBottom);
            userControlNumberBottom.Dock = System.Windows.Forms.DockStyle.Fill;

            panelSide.Controls.Add(userControlNumberSide);
            userControlNumberSide.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        public void SetDrawGaugeChart(List<CHART_GAUGE_PARAM> list, List<CHART_NUMBER_PARAM> list2)
        {
            if (userControlGaugeChart != null)
            {
                userControlGaugeChart.SetDrawGaugeChart(list);
            }

            if (userControlNumberBottom != null)
            {
                userControlNumberBottom.SetDrawData(list2, false);
            }

            if (userControlNumberSide != null)
            {
                userControlNumberSide.SetDrawData(list2, false);
            }
        }


        public void UpdateDrawGaugeChart(List<CHART_GAUGE_PARAM> list, List<CHART_NUMBER_PARAM> list2)
        {
            if (userControlGaugeChart != null)
            {
                userControlGaugeChart.UpdateDrawGaugeChart(list);
            }

            if (userControlNumberBottom != null)
            {
                userControlNumberBottom.SetDrawData(list2, false);
            }

            if (userControlNumberSide != null)
            {
                userControlNumberSide.SetDrawData(list2, false);
            }
        }

        private void UserControlGaugeChartPanel_SizeChanged(object sender, EventArgs e)
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