using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using LiveChartsCore.Easing;
using LiveChartsCore.Kernel;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace sampleLiveChart2
{
    public partial class UserControlSimpleChart : UserControl
    {
        private ISeries[] _series;
        ObservableCollection<DateTimePoint> dateTimePoints = new ObservableCollection<DateTimePoint>();
        Axis[] _xaxes;
        Axis[] _yaxes;

        public UserControlSimpleChart()
        {
            InitializeComponent();
        }

        private void UserControlSimpleChart_Load(object sender, EventArgs e)
        {
            OnCartesianChart();
        }

        private void OnCartesianChart()
        {
            cartesianChart1.ZoomMode = ZoomAndPanMode.X;
            cartesianChart1.LegendPosition = LegendPosition.Bottom;

            dateTimePoints = new ObservableCollection<DateTimePoint>
            {
                new DateTimePoint(new DateTime(2021, 1, 1, 10, 0, 0), 23),
                new DateTimePoint(new DateTime(2021, 1, 1, 10, 1, 0), 36),
                new DateTimePoint(new DateTime(2021, 1, 1, 10, 5, 0), 25),
                new DateTimePoint(new DateTime(2021, 1, 1, 10, 21, 0), 33),
                new DateTimePoint(new DateTime(2021, 1, 1, 11, 1, 0), 25),
                new DateTimePoint(new DateTime(2021, 1, 1, 11, 9, 0), 38),
                new DateTimePoint(new DateTime(2021, 1, 1, 11, 20, 0), 36)
            };
            var values1 = new List<float>();

            var columnSeries1 = new ColumnSeries<float>
            {
                Values = values1,
                Stroke = null,
                Padding = 2
            };

            columnSeries1.PointMeasured += OnPointMeasured;

            var lineSeries1 = new LineSeries<DateTimePoint>
            {
                Name = "Data1",
                TooltipLabelFormatter = (chartPoint) =>
                     $"{new DateTime((long)chartPoint.SecondaryValue):yyyy-MM-dd HH:mm:ss}\r\nData1 {chartPoint.PrimaryValue}",
                Values = dateTimePoints,
                LineSmoothness = 1,
                GeometrySize = 2,
                GeometryStroke = new SolidColorPaint
                {
                    Color = SKColors.Red,
                    StrokeThickness = 2,
                    StrokeCap = SKStrokeCap.Round,
                },
                Fill = null,
                Stroke = new SolidColorPaint
                {
                    Color = SKColors.Red,
                    StrokeThickness = 2,
                    StrokeCap = SKStrokeCap.Square,
                },
            };
            //lineSeries1.PointMeasured += OnPointMeasured;

            _series = new ISeries[] {

                new LineSeries<DateTimePoint>
                {
                   Name = "Data1",
                   TooltipLabelFormatter = (chartPoint) =>
                        $"{new DateTime((long) chartPoint.SecondaryValue):yyyy-MM-dd HH:mm:ss}\r\nData1 {chartPoint.PrimaryValue}",
                    Values = dateTimePoints,
                    LineSmoothness = 1,
                    GeometrySize = 2,
                    GeometryStroke = new SolidColorPaint
                    {
                        Color = SKColors.Red,
                        StrokeThickness = 2,
                        StrokeCap = SKStrokeCap.Round,
                    },
                    Fill = null,
                    Stroke = new SolidColorPaint
                    {
                        Color = SKColors.Red,
                        StrokeThickness = 2,
                        StrokeCap = SKStrokeCap.Square,
                    },
                },
                new LineSeries<DateTimePoint>
                {
                   Name = "Data2",
                   TooltipLabelFormatter = (chartPoint) =>
                        $"{new DateTime((long) chartPoint.SecondaryValue):yyyy-MM-dd HH:mm:ss}\r\nData2 {chartPoint.PrimaryValue}",
                    LineSmoothness = 1,
                    GeometrySize = 2,
                    GeometryStroke = new SolidColorPaint
                    {
                        Color = SKColors.Green,
                        StrokeThickness = 2,
                        StrokeCap = SKStrokeCap.Round,
                    },
                    Fill = null,
                    Stroke = new SolidColorPaint
                    {
                        Color = SKColors.Green,
                        StrokeThickness = 2,
                        StrokeCap = SKStrokeCap.Square,
                    },
                }

            };

            _xaxes = new Axis[]
            {
               new Axis
               {
                   Labeler = value => value > 0 ? new DateTime((long) value).ToString("yyyy-MM-dd HH:mm:ss") : string.Empty,
                   //LabelsRotation = 15,
                   TextSize = 10,
                   UnitWidth = TimeSpan.FromHours(10).Ticks,
                   MinStep = TimeSpan.FromMinutes(1).Ticks
               }
            };
            _yaxes = new Axis[]
            {
                new Axis
                {
                    //Name = "Temperature",
                    Labeler = value => value > 0 ? $"{value}" : string.Empty,
                    TextSize = 12,
                    UnitWidth = 5,
                    MinLimit = 0,
                    MaxLimit = 50,
                    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
                    {
                        StrokeThickness = 2,
                        PathEffect = new DashEffect(new float[] { 3, 3 })
                    }
                }
            };

            cartesianChart1.Series = _series;
            cartesianChart1.XAxes = _xaxes;
            cartesianChart1.YAxes = _yaxes;
        }

        private void OnPointMeasured(ChartPoint<float, RoundedRectangleGeometry, LabelGeometry> point)
        {
            var visual = point.Visual;
            if (visual is null) return;

            var delayedFunction = new DelayedFunction(EasingFunctions.BuildCustomElasticOut(1.5f, 0.60f), point, 30f);

            _ = visual
                .TransitionateProperties(
                    nameof(visual.Y),
                    nameof(visual.Height))
                .WithAnimation(animation =>
                    animation
                        .WithDuration(delayedFunction.Speed)
                        .WithEasingFunction(delayedFunction.Function));
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            //dateTimePoints.Clear();
            List<DateTimePoint> dateTimeList = new List<DateTimePoint>();
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 10, 0, 0), 23));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 10, 5, 0), 41));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 10, 10, 0), 33));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 10, 15, 0), 21));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 10, 44, 0), 23));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 11, 0, 0), 23));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 11, 5, 0), 23));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 11, 9, 0), 23));
            dateTimeList.Add(new DateTimePoint(new DateTime(2021, 1, 2, 11, 12, 0), 23));

            foreach (var item in dateTimeList)
            {
                dateTimePoints.Add(item);
            }
        }

    }
}
