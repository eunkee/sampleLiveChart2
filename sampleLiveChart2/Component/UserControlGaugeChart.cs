using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlGaugeChart : UserControl
    {
        private ObservableValue _percentValue1;
        private ObservableValue _percentValue2;
        private ObservableValue _percentValue3;

        public UserControlGaugeChart()
        {
            InitializeComponent();
        }

        public void SetDrawGaugeChart(List<CHART_GAUGE_PARAM> list)
        {
            panelDashboard1.Visible = true;
            panelDashboard3.Visible = true;

            if (list.Count == 2)
            {
                panelDashboard2.Visible = false;
                _percentValue1 = new ObservableValue { Value = list[0].Percent };
                _percentValue2 = new ObservableValue { Value = list[1].Percent };

                OnDrawSolidGauge(pieChartGauge1, list[0].SeriesName, _percentValue1, list[0].Paint);
                OnDrawSolidGauge(pieChartGauge3, list[1].SeriesName, _percentValue2, list[1].Paint);
            }
            else if (list.Count == 3)
            {
                panelDashboard2.Visible = true;
                _percentValue1 = new ObservableValue { Value = list[0].Percent };
                _percentValue2 = new ObservableValue { Value = list[1].Percent };
                _percentValue3 = new ObservableValue { Value = list[2].Percent };

                OnDrawSolidGauge(pieChartGauge1, list[0].SeriesName, _percentValue1, list[0].Paint);
                OnDrawSolidGauge(pieChartGauge2, list[1].SeriesName, _percentValue2, list[1].Paint);
                OnDrawSolidGauge(pieChartGauge3, list[2].SeriesName, _percentValue3, list[2].Paint);
            }
            else
            {
                // none
            }

            panelDashboard3.BringToFront();

            UserControlGaugeChart_SizeChanged(null, null);
        }

        public void UpdateDrawGaugeChart(List<CHART_GAUGE_PARAM> list)
        {
            if (list.Count == 2)
            {
                panelDashboard2.Visible = false;
                _percentValue1.Value = list[0].Percent;
                _percentValue2.Value = list[1].Percent;

                OnDrawSolidGauge(pieChartGauge1, list[0].SeriesName, _percentValue1, list[0].Paint);
                OnDrawSolidGauge(pieChartGauge3, list[1].SeriesName, _percentValue2, list[1].Paint);
            }
            else if (list.Count == 3)
            {
                panelDashboard2.Visible = true;
                _percentValue1.Value = list[0].Percent;
                _percentValue2.Value = list[1].Percent;
                _percentValue3.Value = list[2].Percent;

                OnDrawSolidGauge(pieChartGauge1, list[0].SeriesName, _percentValue1, list[0].Paint);
                OnDrawSolidGauge(pieChartGauge2, list[1].SeriesName, _percentValue2, list[1].Paint);
                OnDrawSolidGauge(pieChartGauge3, list[2].SeriesName, _percentValue3, list[2].Paint);
            }
            else
            {
                // none
            }

            UserControlGaugeChart_SizeChanged(null, null);
        }

        // 숫자표시 모드: 솔리드 게이지 그리기
        private void OnDrawSolidGauge(LiveChartsCore.SkiaSharpView.WinForms.PieChart controlName, string valueName, ObservableValue observableValue, SKColor gagueColor)
        {
            controlName.Series = new GaugeBuilder()
                .AddValue(observableValue, valueName, gagueColor, DEFINE.SK_FONT_COLOR)
                .WithBackground(new SolidColorPaint(DEFINE.SK_GAUGE_BACK_COLOR))
                .WithLabelsPosition(PolarLabelsPosition.ChartCenter)
                .WithLabelFormatter(point => $"{point.PrimaryValue:N2}%")
                .BuildSeries();

            controlName.TooltipPosition = TooltipPosition.Hidden;

            SetGagueInnerRadius(controlName);
        }

        // 내부 원 구현
        private void SetGagueInnerRadius(LiveChartsCore.SkiaSharpView.WinForms.PieChart controlName)
        {
            double innerRadius = Math.Min(controlName.Width, controlName.Height) / 2.1;

            foreach (ISeries item in controlName.Series)
            {
                if (item is PieSeries<ObservableValue> serise)
                {
                    serise.InnerRadius = innerRadius;
                    serise.DataLabelsSize = innerRadius / 2.8d;
                }
            }
        }

        private void UserControlGaugeChart_SizeChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                return;
            }
            
            this.panelDashboard1.Padding = new System.Windows.Forms.Padding(5);
            this.panelDashboard3.Padding = new System.Windows.Forms.Padding(5);

            int panelWidth;
            int panelHeight;

            int partCount = 3;
            if (!panelDashboard2.Visible)
            {
                partCount = 2;
            }

            if (this.Width > this.Height)
            {
                panelWidth = Convert.ToInt32(Math.Truncate((double)(this.Width / partCount)));
                panelHeight = this.Height;

                panelDashboard1.Dock = DockStyle.Left;
                panelDashboard2.Dock = DockStyle.Left;
            }
            else
            {
                panelWidth = this.Width;
                panelHeight = Convert.ToInt32(Math.Truncate((double)(this.Height / partCount)));

                panelDashboard1.Dock = DockStyle.Top;
                panelDashboard2.Dock = DockStyle.Top;
            }

            // 3개
            if (panelDashboard2.Visible)
            {
                panelDashboard2.Visible = true;

                // 순서가 3 사이즈에 영향
                panelDashboard2.BringToFront();

                // 너무 벌어질 경우 모아주기
                if (this.Width > this.Height)
                {
                    if (panelWidth > panelHeight)
                    {
                        int division = panelWidth - panelHeight;
                        if (division > 5)
                        {
                            this.panelDashboard1.Padding = new System.Windows.Forms.Padding(division, 5, 5, 5);
                            this.panelDashboard3.Padding = new System.Windows.Forms.Padding(5, 5, division, 5);
                        }
                    }
                }
                panelDashboard1.Size = new Size(panelWidth, panelHeight);
                panelDashboard2.Size = new Size(panelWidth, panelHeight);
            }
            else // 2개
            {
                panelDashboard2.Visible = false;

                // 너무 벌어질 경우 모아주기
                if (this.Width > this.Height)
                {
                    if (panelWidth > panelHeight)
                    {
                        int division = panelWidth - panelHeight;
                        if (division > 5)
                        {
                            this.panelDashboard1.Padding = new System.Windows.Forms.Padding(division, 5, 5, 5);
                            this.panelDashboard3.Padding = new System.Windows.Forms.Padding(5, 5, division, 5);
                        }
                    }
                }

                panelDashboard1.Size = new Size(panelWidth, panelHeight);
            }

            panelDashboard3.BringToFront();

            SetGagueInnerRadius(pieChartGauge1);
            SetGagueInnerRadius(pieChartGauge2);
            SetGagueInnerRadius(pieChartGauge3);
        }
    }
}