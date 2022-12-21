using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Easing;
using LiveChartsCore.Kernel;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using LiveChartsCore.SkiaSharpView.WinForms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SkiaSharp;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class Form1 : Form
    {
        readonly UserControlSimpleChart sampleChart = new UserControlSimpleChart();
        readonly UserControlCartesianChart realChart;
        readonly UserControlPieChartPanel pieChart = new UserControlPieChartPanel();
        readonly UserControlGaugeChartPanel gaugeChart = new UserControlGaugeChartPanel();
        readonly UserControlBarChart barChart = new UserControlBarChart();
        readonly UserControlMotionCnvas motionChart = new UserControlMotionCnvas();

        public Form1()
        {
            InitializeComponent();

            realChart = new UserControlCartesianChart(this, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(sampleChart);
            panel1.Controls.Add(realChart);
            panel1.Controls.Add(pieChart);
            panel1.Controls.Add(gaugeChart);
            panel1.Controls.Add(barChart);
            panel1.Controls.Add(motionChart);

            sampleChart.Dock = System.Windows.Forms.DockStyle.Fill;
            realChart.Dock = System.Windows.Forms.DockStyle.Fill;
            pieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            gaugeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            barChart.Dock = System.Windows.Forms.DockStyle.Fill;
            motionChart.Dock = System.Windows.Forms.DockStyle.Fill;

            sampleChart.Visible = true;
            realChart.Visible = false;
            pieChart.Visible = false;
            gaugeChart.Visible = false;
            barChart.Visible = false;
            motionChart.Visible = false;

            PieChartSetData(510, 490);
        }

        private ConcurrentDictionary<string, DeviceData> _deviceList = new ConcurrentDictionary<string, DeviceData>();

        public ConcurrentDictionary<string, DeviceData> DeviceList
        {
            get
            {
                return _deviceList;
            }
            set
            {
                _deviceList = value;
            }
        }
        public static TimeSpan REST_TIMEOUT_SPAN = new TimeSpan(0, 0, 20);
        private readonly string _mainRestAddress = string.Empty;

        public async Task<PhrsingGraphData> GetDeviceGraph(string deviceId, PostGraphParam param)
        {
            PhrsingGraphData rslt = null;
            using (var client = new HttpClient())
            {
                string address = _mainRestAddress;
                client.Timeout = REST_TIMEOUT_SPAN;
                try
                {
                    string jsonString = JsonConvert.SerializeObject(param);
                    string temp_addr = $"{address}/devices/{deviceId}/graph";
                    var response = await client.PostAsync(temp_addr,
                    new StringContent(jsonString, Encoding.UTF8, "application/json"));

                    if (response.IsSuccessStatusCode)
                    {
                        string str = response.Content.ReadAsStringAsync().Result;
                        //System.Diagnostics.Trace.WriteLine(str);
                        if (str.Length > 0)
                        {
                            PhrsingGraphJson origin = JsonConvert.DeserializeObject<PhrsingGraphJson>(str);
                            rslt = origin.Data;
                        }
                    }
                    else
                    {
                        string failedMessage = $"Failed GetDeviceGraph StatusCode:{response.StatusCode} ReasonPhrase:{response.ReasonPhrase}";
                        Console.WriteLine(failedMessage);
                    }
                }
                catch (TaskCanceledException tce)
                {
                    Console.WriteLine(tce.Message);
                    Console.WriteLine(tce.StackTrace);
                }
                catch (HttpRequestException hre)
                {
                    Console.WriteLine(hre.Message);
                    Console.WriteLine(hre.StackTrace);
                }
            }
            return rslt;
        }

        // 데이터 처음 표시
        public void PieChartSetData(int serviceCount1, int serviceCount2)
        {
            double totalCount = serviceCount1 + serviceCount2;
            if (totalCount > 0)
            {
                double servicePercent1 = serviceCount1 / totalCount * 100d;
                double servicePercent2 = serviceCount2 / totalCount * 100d;

                List<CHART_PIE_PARAM> list = ClientUtil.MakePieChartParamList(
                    SERVICE1_NAME, SERVICE2_NAME,
                    serviceCount1, serviceCount2,
                    DEFINE.GRADATION_BRUSH_VIOLET, DEFINE.GRADATION_BRUSH_SAFFRON);

                List<CHART_NUMBER_PARAM> list2 = ClientUtil.MakeNumberParamList(
                    SERVICE1_NAME, SERVICE2_NAME,
                    serviceCount1, serviceCount2,
                    servicePercent1, servicePercent2);

                List<CHART_GAUGE_PARAM> list3 = ClientUtil.MakeGaugeParamList(
                    SERVICE1_NAME, SERVICE2_NAME,
                    serviceCount1, serviceCount2,
                    servicePercent1, servicePercent2,
                    DEFINE.SK_VIOLET_COLOR, DEFINE.SK_SAFFRON_COLOR);

                // pie chart
                string title = "Service Type";
                pieChart?.SetDrawPieChart(list, list2, title);

                // gauge chart
                gaugeChart?.SetDrawGaugeChart(list3, list2);

                barChart?.SetDrawBarChart(list3, title);
            }
        }

        readonly string SERVICE1_NAME = "service 1";
        readonly string SERVICE2_NAME = "service 2";

        // 데이터 갱신
        public void UpdateData(int serviceCount1, int serviceCount2)
        {
            double totalCount = serviceCount1 + serviceCount2;

            if (totalCount > 0)
            {
                double servicePercent1 = serviceCount1 / totalCount * 100d;
                double servicePercent2 = serviceCount2 / totalCount * 100d;

                List<CHART_PIE_PARAM> list = ClientUtil.MakePieChartParamList(
                    SERVICE1_NAME, SERVICE2_NAME,
                    serviceCount1, serviceCount2,
                    DEFINE.GRADATION_BRUSH_VIOLET, DEFINE.GRADATION_BRUSH_SAFFRON);

                List<CHART_NUMBER_PARAM> list2 = ClientUtil.MakeNumberParamList(
                    SERVICE1_NAME, SERVICE2_NAME,
                    serviceCount1, serviceCount2,
                    servicePercent1, servicePercent2);

                List<CHART_GAUGE_PARAM> list3 = ClientUtil.MakeGaugeParamList(
                    SERVICE1_NAME, SERVICE2_NAME,
                    serviceCount1, serviceCount2,
                    servicePercent1, servicePercent2,
                    DEFINE.SK_VIOLET_COLOR, DEFINE.SK_SAFFRON_COLOR);

                // pie chart
                pieChart?.UpdateValuePieChart(list, list2);

                // gauge chart
                gaugeChart?.UpdateDrawGaugeChart(list3, list2);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sampleChart.Visible = true;
            realChart.Visible = false;
            pieChart.Visible = false;
            gaugeChart.Visible = false;
            barChart.Visible = false;
            motionChart.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sampleChart.Visible = false;
            realChart.Visible = true;
            pieChart.Visible = false;
            gaugeChart.Visible = false;
            barChart.Visible = false;
            motionChart.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            sampleChart.Visible = false;
            realChart.Visible = false;
            pieChart.Visible = true;
            gaugeChart.Visible = false;
            barChart.Visible = false;
            motionChart.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            sampleChart.Visible = false;
            realChart.Visible = false;
            pieChart.Visible = false;
            gaugeChart.Visible = true;
            barChart.Visible = false;
            motionChart.Visible = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            sampleChart.Visible = false;
            realChart.Visible = false;
            pieChart.Visible = false;
            gaugeChart.Visible = false;
            barChart.Visible = true;
            motionChart.Visible = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            sampleChart.Visible = false;
            realChart.Visible = false;
            pieChart.Visible = false;
            gaugeChart.Visible = false;
            barChart.Visible = false;
            motionChart.Visible = true;
        }
    }
}
