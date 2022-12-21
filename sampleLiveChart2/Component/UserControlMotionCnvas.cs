using LiveChartsCore;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlMotionCnvas : UserControl
    {
        private string _title = string.Empty;

        public UserControlMotionCnvas()
        {
            InitializeComponent();
        }

        public void SetDrawBarChart(List<CHART_PIE_PARAM> list, string title)
        {
//            _title = title;
//            ISeries[] seriesArray = new ISeries[list.Count];


        

////            double innerRadius = Math.Min(barChart1.Width, barChart1.Height) / 3;

//            for (int i = 0; i < list.Count; i++)
//            {
//                CHART_PIE_PARAM data = list[i];

//                seriesArray[i] = new ColumnSeries<int>
//                {
//                    Name = data.SeriesName,
//                    Values = new[] { data.Values },
//                    DataLabelsPaint = new SolidColorPaint(DEFINE.SK_FONT_COLOR),
//                    DataLabelsFormatter = _ => _title,
////                    Stroke = null,
//  //                  Fill = data.Paint,
//    //                Pivot = 5,
//                };
//            }

//            motionCanvas1.Series = seriesArray;

        }

        private void motionCanvas1_Load(object sender, EventArgs e)
        {
            //motionCanvas1.
        }
    }
}