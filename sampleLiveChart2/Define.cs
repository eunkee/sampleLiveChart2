using LiveChartsCore.SkiaSharpView.Painting;
using Newtonsoft.Json;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sampleLiveChart2
{
    public class DEFINE
    {
        #region color

        // rjButton CheckButton Color
        // Checkbutton = LIGHT_COLOR
        public static System.Drawing.Color RJBUTTON_UNCHECK_COLOR = System.Drawing.Color.FromArgb(70, 79, 94);
        public static System.Drawing.Color RJBUTTON_UNCHECK_COLOR2 = System.Drawing.Color.FromArgb(115, 128, 159);

        public static System.Drawing.Color RJBUTTON_LIGHT_RED_COLOR = System.Drawing.Color.FromArgb(245, 87, 98);
        public static System.Drawing.Color RJBUTTON_UN_FORE_COLOR = System.Drawing.Color.FromArgb(115, 128, 159);

        // grid color
        public static System.Drawing.Color GRID_DARK_RED_COLOR = System.Drawing.Color.FromArgb(63, 37, 49);
        //public static System.Drawing.Color GRID_DARK_RED_COLOR = System.Drawing.Color.FromArgb(116, 62, 69);
        public static System.Drawing.Color GRID_DARK_BLUE_COLOR = System.Drawing.Color.FromArgb(18, 21, 74);
        public static System.Drawing.Color GRID_DARK_YELLO_COLOR = System.Drawing.Color.FromArgb(125, 88, 50);
        //public static System.Drawing.Color GRID_DARK_YELLO_COLOR = System.Drawing.Color.FromArgb(58, 63, 37);
        public static System.Drawing.Color GRID_DARK_GREEN_COLOR = System.Drawing.Color.FromArgb(13, 67, 18);

        // device on | off color
        public static System.Drawing.Color DEVICE_ON_COLOR = System.Drawing.Color.FromArgb(2, 188, 119);
        public static System.Drawing.Color DEVICE_OFF_COLOR = System.Drawing.Color.FromArgb(255, 111, 112);


        // main color
        // 필요할 수 있는 부분: System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
        public static System.Drawing.Color BACKGROUND_COLOR = System.Drawing.Color.FromArgb(16, 15, 27);
        public static System.Drawing.Color LINE_COLOR = System.Drawing.Color.FromArgb(21, 32, 54);
        public static System.Drawing.Color BUTTON_BACKGROUND_COLOR = System.Drawing.Color.FromArgb(30, 34, 50);
        public static System.Drawing.Color LIGHT_COLOR = System.Drawing.Color.FromArgb(91, 190, 202);
        public static System.Drawing.Color TEXT_COLOR_NORMAL = System.Drawing.Color.FromArgb(152, 173, 192);
        public static System.Drawing.Color TEXT_COLOR_DARK = System.Drawing.Color.FromArgb(79, 90, 108);
        public static System.Drawing.Color TEXT_COLOR_WHITE = System.Drawing.Color.FromArgb(230, 232, 235);

        public static System.Drawing.Color NORMAL_BUTTON_OVER_COLOR = System.Drawing.Color.FromArgb(36, 40, 60);
        public static System.Drawing.Color DISABLE_BUTTON_TEXT_COLOR = System.Drawing.Color.FromArgb(120, 133, 161);
        public static System.Drawing.Color DISABLE_BUTTON_BACK_COLOR = System.Drawing.Color.FromArgb(70, 79, 94);

        public static System.Drawing.Color RELATED_SELECTED_COLOR = System.Drawing.Color.FromArgb(200, 18, 66, 81);


        #region live charts color
        private static readonly SKColor[] skColorsViolet =
        {
            new SKColor(157, 121, 188),
            new SKColor(95, 60, 125),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_VIOLET = new RadialGradientPaint(skColorsViolet);

        private static readonly SKColor[] skColorsSaffron =
        {
            new SKColor(202, 162, 97),
            new SKColor(184, 129, 41),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_SAFFRON = new RadialGradientPaint(skColorsSaffron);

        private static readonly SKColor[] skColorsOrange =
        {
            new SKColor(214, 179, 149),
            new SKColor(244, 120, 12),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_ORANGE = new RadialGradientPaint(skColorsOrange);

        private static readonly SKColor[] skColorsOlive =
        {
            new SKColor(190, 193, 157),
            new SKColor(142, 149, 64),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_OLIVE = new RadialGradientPaint(skColorsOlive);

        private static readonly SKColor[] skColorsDarkRed =
        {
            new SKColor(205, 62, 83),
            new SKColor(158, 7, 29),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_DARKRED = new RadialGradientPaint(skColorsDarkRed);

        private static readonly SKColor[] skColorsLightRed =
        {
            new SKColor(203, 133, 133),
            new SKColor(214, 56, 56),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_LIGHTRED = new RadialGradientPaint(skColorsLightRed);

        private static readonly SKColor[] skColorsSkyblue =
        {
            new SKColor(161, 206, 217),
            new SKColor(9, 184, 224),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_SKYBLUE = new RadialGradientPaint(skColorsSkyblue);

        private static readonly SKColor[] skColorsblue =
        {
            new SKColor(137, 135, 222),
            new SKColor(43, 39, 239),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_BLUE = new RadialGradientPaint(skColorsblue);

        private static readonly SKColor[] skColorsGreen =
{
            new SKColor(190, 193, 157),
            new SKColor(74, 156, 90),
        };
        public static readonly RadialGradientPaint GRADATION_BRUSH_GREEN = new RadialGradientPaint(skColorsGreen);

        public static SKColor SK_RED_COLOR = new SKColor(214, 56, 56);
        public static SKColor SK_ORANGE_COLOR = new SKColor(244, 120, 12);
        public static SKColor SK_SKYBLUE_COLOR = new SKColor(9, 184, 224);
        public static SKColor SK_VIOLET_COLOR = new SKColor(95, 60, 125);
        public static SKColor SK_OLIVE_COLOR = new SKColor(142, 149, 64);
        public static SKColor SK_SAFFRON_COLOR = new SKColor(184, 129, 41);
        public static SKColor SK_GREEN_COLOR = new SKColor(74, 156, 90);

        public static SKColor SK_FONT_COLOR = new SKColor(152, 173, 192);
        public static SKColor SK_GAUGE_BACK_COLOR = new SKColor(52, 53, 71);

        // graph
        public static SKColor SK_BACKGROUND = new SKColor(16, 15, 27);
        public static SKColor SK_SOLID_RED = new SKColor(193, 17, 35);
        public static SKColor SK_ALPHA_RED = new SKColor(193, 17, 35, 140);
        public static SKColor SK_SOLID_TURQUOISE = new SKColor(32, 223, 231);
        public static SKColor SK_ALPHA_TURQUOISE = new SKColor(32, 223, 231, 80);
        public static SKColor SK_FONTCOLOR = new SKColor(152, 173, 192);
        public static SKColor SK_FONTCOLOR_SUB = new SKColor(94, 103, 127);
        public static SKColor SK_ALARM_COLOR = new SKColor(248, 142, 32);

        #endregion live charts color

        #endregion color

    }

    // 온도 이벤트 전달
    public struct TEMPERATURE_EMERGENCY_STRUCT
    {
        public DateTime Datetime;
        public string DeviceId;
        public string Event;
    }

    // 파이 챠트 데이터 전달
    public struct CHART_PIE_PARAM
    {
        public string SeriesName;
        public int Values;
        public RadialGradientPaint Paint;
    }

    // 파이 챠트 데이터 전달
    public struct CHART_GAUGE_PARAM
    {
        public string SeriesName;
        public int Values;
        public double Percent;
        public SKColor Paint;
    }


    public struct CHART_NUMBER_PARAM
    {
        public string SeriesName;
        public int Values;
        public double Percent;
    }


    // 파이 챠트 데이터 전달
    public struct PIE_CHART_PARAM2
    {
        public string SeriesName;
        public long Values;
        public RadialGradientPaint Paint;
    }

    public static class ClientUtil
    {
        public static long DateTimeToTimeStampSecond(DateTime value)
        {
            return ((DateTimeOffset)value).ToUnixTimeSeconds();
        }

        public static DateTime TimeStampToDateTime(long value)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dt = dt.AddSeconds(value).ToLocalTime();
            return dt;
        }

        public static List<CHART_PIE_PARAM> MakePieChartParamList(
           string name1, string name2,
           int count1, int count2,
            RadialGradientPaint paint1, RadialGradientPaint paint2)
        {
            List<CHART_PIE_PARAM> list = new List<CHART_PIE_PARAM>();
            CHART_PIE_PARAM data1 = new CHART_PIE_PARAM
            {
                SeriesName = name1,
                Values = count1,
                Paint = paint1
            };
            list.Add(data1);
            CHART_PIE_PARAM data2 = new CHART_PIE_PARAM
            {
                SeriesName = name2,
                Values = count2,
                Paint = paint2
            };
            list.Add(data2);
            return list;
        }

        public static List<CHART_NUMBER_PARAM> MakeNumberParamList(
            string name1, string name2,
            int count1, int count2,
            double percent1, double percent2)
        {
            List<CHART_NUMBER_PARAM> list = new List<CHART_NUMBER_PARAM>();
            CHART_NUMBER_PARAM data1 = new CHART_NUMBER_PARAM
            {
                SeriesName = name1,
                Values = count1,
                Percent = percent1,
            };
            list.Add(data1);
            CHART_NUMBER_PARAM data2 = new CHART_NUMBER_PARAM
            {
                SeriesName = name2,
                Values = count2,
                Percent = percent2,
            };
            list.Add(data2);
            return list;
        }

        public static List<CHART_GAUGE_PARAM> MakeGaugeParamList(
    string name1, string name2,
    int count1, int count2,
    double percent1, double percent2,
    SKColor color1, SKColor color2)
        {
            List<CHART_GAUGE_PARAM> list = new List<CHART_GAUGE_PARAM>();
            CHART_GAUGE_PARAM data1 = new CHART_GAUGE_PARAM
            {
                SeriesName = name1,
                Values = count1,
                Percent = percent1,
                Paint = color1,
            };
            list.Add(data1);
            CHART_GAUGE_PARAM data2 = new CHART_GAUGE_PARAM
            {
                SeriesName = name2,
                Values = count2,
                Percent = percent2,
                Paint = color2,
            };
            list.Add(data2);
            return list;
        }
    }

    public class PostGraphParam
    {
        [JsonProperty("startDate")]
        public int StartDate { get; set; }

        [JsonProperty("currentDate")]
        public int CurrentDate { get; set; }

        // [today, week, month]
        [JsonProperty("tabName")]
        public string TabName { get; set; } = "today";
    }

    public class PhrsingGraphJson
    {
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public PhrsingGraphData Data { get; set; }
    }

    public class PhrsingGraphData
    {
        [JsonProperty("deviceID")]
        public string DeviceID { get; set; }

        [JsonProperty("dataRange")]
        public string DataRange { get; set; }

        [JsonProperty("deviceRefValue")]
        public int DeviceRefValue { get; set; }

        [JsonProperty("dataset")]
        public PhrsingGraphDataSet[] Dataset { get; set; }

        [JsonProperty("averageDataset")]
        public PhrsingGraphDataSet[] AverageDataset { get; set; }
    }

    public class PhrsingGraphDataSet
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public class DeviceData
    {
        // 장치 아이디
        [JsonProperty("deviceID")]
        public string DeviceID { get; set; }

        //장치 이름
        [JsonProperty("deviceName")]
        public string DeviceName { get; set; }
    }

    }
