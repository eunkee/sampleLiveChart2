using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlPieChart : UserControl
    {
        private string _title = string.Empty;

        public UserControlPieChart()
        {
            InitializeComponent();
        }

        public void SetDrawPieChart(List<CHART_PIE_PARAM> list, string title)
        {
            _title = title;
            ISeries[] seriesArray = new ISeries[list.Count];

            double innerRadius = Math.Min(pieChart1.Width, pieChart1.Height) / 3;

            for (int i = 0; i < list.Count; i++)
            {
                CHART_PIE_PARAM data = list[i];

                //Console.WriteLine($"{data.SeriesName}: {data.Values}");
                seriesArray[i] = new PieSeries<int>
                {
                    Name = data.SeriesName,
                    Values = new[] { data.Values },
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.ChartCenter,
                    DataLabelsPaint = new SolidColorPaint(DEFINE.SK_FONT_COLOR),
                    DataLabelsFormatter = _ => _title,
                    Stroke = null,
                    Fill = data.Paint,
                    Pushout = 0,
                    HoverPushout = 5,
                    Pivot = 5,
                    InnerRadius = innerRadius,
                    // 툴팁 레이블의 데이터 값의 길이 때문에 사이즈가 맞지 않는 이슈가 있어 데이터 부분을 제거할 것을 고려
                    // beta 516 버전에 사이즈는 수정되었으나 잔상이나 모션잔상에 버그가 있어 사용 보류
                    //TooltipLabelFormatter = p => $"{data.SeriesName} {p.PrimaryValue}({p.StackedValue.Share:P2})",
                    
                };
            }

            pieChart1.Series = seriesArray;

            PieChart1_SizeChanged(null, null);
        }

        public void UpdateValuePieChart(List<CHART_PIE_PARAM> list)
        {
            if (pieChart1.Series == null)
            {
                SetDrawPieChart(list, _title);
                return;
            }

            foreach (CHART_PIE_PARAM item in list)
            {
                foreach (ISeries series in pieChart1.Series)
                {
                    if (item.SeriesName == series.Name)
                    {
                        series.Values = new[] { item.Values };
                        break;
                    }
                }
            }

            PieChart1_SizeChanged(null, null);
        }

        private void PieChart1_Load(object sender, EventArgs e)
        {
            // 툴팁 설정
            //pieChart1.TooltipFont = new Font("Noto Sans CJK KR Regular", 9.25F);
            //pieChart1.TooltipTextColor = DEFINE.LIGHT_COLOR;
            //pieChart1.TooltipBackColor = DEFINE.BUTTON_BACKGROUND_COLOR;

            pieChart1.TooltipPosition = TooltipPosition.Hidden;
        }

        private void PieChart1_SizeChanged(object sender, EventArgs e)
        {
            double innerRadius = Math.Min(pieChart1.Width, pieChart1.Height) / 3;
            foreach (ISeries item in pieChart1.Series)
            {
                if (item is PieSeries<int> serise)
                {
                    serise.InnerRadius = innerRadius;
                    serise.DataLabelsSize = innerRadius / 5.5d;
                }
            }
        }
    }
}