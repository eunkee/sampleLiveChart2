using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlBarChart : UserControl
    {
        private string _title = string.Empty;

        public UserControlBarChart()
        {
            InitializeComponent();
        }

        public void SetDrawBarChart(List<CHART_GAUGE_PARAM> list, string title)
        {
            _title = title;
            ISeries[] seriesArray = new ISeries[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                CHART_GAUGE_PARAM data = list[i];

                seriesArray[i] = new ColumnSeries<double>
                {
                    Name = data.SeriesName,
                    Values = new[] { data.Percent },
                    //DataLabelsPaint = DEFINE.SK_FONTCOLOR,
                    TooltipLabelFormatter = p => $"{data.SeriesName} {data.Values} ({data.Percent}%)",
                    //DataLabelsFormatter = _ => "asdasd",//data.SeriesName,
                    Stroke = new SolidColorPaint
                    {
                        Color = DEFINE.SK_FONTCOLOR,
                        StrokeThickness = 1,
                        StrokeCap = SKStrokeCap.Round,
                    },
                    IsHoverable = false,
                    Fill = new LinearGradientPaint(new[] { data.Paint, DEFINE.SK_BACKGROUND }, new SKPoint(0.5f, 0), new SKPoint(0.5f, 1)),
                };
                //seriesArray[i].ChartPointPointerHover +=

            }

            barChart1.Series = seriesArray;

            Axis[] xaxes = new Axis[]
            {
               new Axis
               {
                   Labels = new string[] { title },
                   LabelsPaint = new SolidColorPaint(DEFINE.SK_FONTCOLOR),
               }
            };

            Axis[] yaxes = new Axis[]
            {
                new Axis
                {
                    Name = "percent",
                    NameTextSize = 12,
                    NamePaint =  new SolidColorPaint(DEFINE.SK_FONTCOLOR_SUB),
                    Labeler = value => value > 0 ? $"{value}%" : string.Empty,
                    TextSize = 12,
                    LabelsPaint = new SolidColorPaint(DEFINE.SK_FONTCOLOR),
                    UnitWidth = 5,
                    MinLimit = 0,
                    MaxLimit = 100,
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                    {
                        StrokeThickness = 2,
                        PathEffect = new DashEffect(new float[] { 3, 3 })
                    }
                }
            };


            barChart1.XAxes = xaxes;
            barChart1.YAxes = yaxes;

        }

        public void UpdateValuePieChart(List<CHART_GAUGE_PARAM> list)
        {
            if (barChart1.Series == null)
            {
                SetDrawBarChart(list, _title);
                return;
            }

            foreach (CHART_GAUGE_PARAM item in list)
            {
                foreach (ISeries series in barChart1.Series)
                {
                    if (item.SeriesName == series.Name)
                    {
                        series.Values = new[] { item.Values };
                        break;
                    }
                }
            }

        }

        private void barChart1_Load(object sender, EventArgs e)
        {
            // 툴팁 설정
            //barChart1.TooltipFont = new Font("Noto Sans CJK KR Regular", 9.25F);
            //barChart1.TooltipTextColor = DEFINE.LIGHT_COLOR;
            //barChart1.TooltipBackColor = DEFINE.BUTTON_BACKGROUND_COLOR;

            //barChart1.TooltipPosition = TooltipPosition.Center;

            //barChart1.TooltipPosition = TooltipPosition.Hidden;
        }
    }
}