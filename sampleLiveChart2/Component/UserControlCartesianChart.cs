using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlCartesianChart : UserControl
    {
        private readonly Form1 _parentForm;

        private readonly System.Collections.ObjectModel.ObservableCollection<DateTimePoint> _dateTimePointsTemp = new System.Collections.ObjectModel.ObservableCollection<DateTimePoint>();
        private readonly System.Collections.ObjectModel.ObservableCollection<DateTimePoint> _dateTimePointsML = new System.Collections.ObjectModel.ObservableCollection<DateTimePoint>();
        private readonly System.Collections.ObjectModel.ObservableCollection<DateTimePoint> _dateTimePointsScatter = new System.Collections.ObjectModel.ObservableCollection<DateTimePoint>();
        private Axis[] _xaxes;
        private Axis[] _yaxes;

        private readonly object _collectionLock = new object();

        // 폼 생성 기준 DateTime
        private readonly DateTime _current = DateTime.Now;

        private TEMPERATURE_GRAPH_RANGE rangeSet = TEMPERATURE_GRAPH_RANGE.None;

        // 설정된 디바이스 아이디
        private string _deviceId = string.Empty;

        // 설정된 TEMPERATURE_EVENT_STRUCT 정보
        private DateTime? _alarmEventTime = null;

        private string _alarmEventType = string.Empty;

        public string DeviceId
        {
            set
            {
                if (_deviceId != value || (_deviceId == value && _alarmEventTime != null))
                {
                    _deviceId = value;
                    _alarmEventTime = null;
                    _alarmEventType = string.Empty;

                    if (this.Handle != null)
                    {
                        InitializingDeviceId();
                    }
                }
            }
        }

        public TEMPERATURE_EMERGENCY_STRUCT AlarmEvent
        {
            set
            {
                if (_deviceId != value.DeviceId || _alarmEventTime != value.Datetime)
                {
                    _deviceId = value.DeviceId;
                    _alarmEventTime = value.Datetime;
                    _alarmEventType = value.Event;

                    if (this.Handle != null)
                    {
                        InitializingDeviceId();
                    }
                }
            }
        }

        // 동일한 그래프를 받지 않기 위해 변경된 값 비교를 위함
        private string _oldDeviceId = string.Empty;

        private DateTime _oldStartDateTime = new DateTime();
        private DateTime _oldEndDateTime = new DateTime();
        private double? currentMinLimit = null;
        private double? currentMaxLimit = null;

        private CancellationTokenSource _cts = null;

        private enum TEMPERATURE_GRAPH_RANGE
        {
            None = 0,
            Today = 1,
            Week = 2,
            Month = 3,
            Custom = 4
        }

        public void ReVisbleButton()
        {
            PanelTemperature4.Invalidate();
        }

        #region EnableRjButton

        private bool _rjButtonSetEnable = false;
        private bool _rjButtonClearEnable = true;

        private void SetEnableRjButton(RJButton button, bool enable)
        {
            if (button.Name == ButtonTemperatureSet.Name)
            {
                _rjButtonSetEnable = enable;
            }
            else if (button.Name == ButtonTemperatureClear.Name)
            {
                _rjButtonClearEnable = enable;
            }
            else
            {
                return;
            }

            button.Invoke((MethodInvoker)(() =>
            {
                if (enable)
                {
                    button.BackColor = DEFINE.BUTTON_BACKGROUND_COLOR;
                    button.BackgroundColor = DEFINE.BUTTON_BACKGROUND_COLOR;
                    button.BorderSize = 1;

                    button.ForeColor = DEFINE.LIGHT_COLOR;
                    button.TextColor = DEFINE.LIGHT_COLOR;

                    button.FlatAppearance.BorderSize = 1;
                    button.FlatAppearance.MouseDownBackColor = DEFINE.NORMAL_BUTTON_OVER_COLOR;
                    button.FlatAppearance.MouseOverBackColor = DEFINE.NORMAL_BUTTON_OVER_COLOR;
                }
                else
                {
                    button.BackColor = DEFINE.DISABLE_BUTTON_BACK_COLOR;
                    button.BackgroundColor = DEFINE.DISABLE_BUTTON_BACK_COLOR;
                    button.BorderSize = 0;

                    button.ForeColor = DEFINE.DISABLE_BUTTON_TEXT_COLOR;
                    button.TextColor = DEFINE.DISABLE_BUTTON_TEXT_COLOR;

                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseDownBackColor = DEFINE.DISABLE_BUTTON_BACK_COLOR;
                    button.FlatAppearance.MouseOverBackColor = DEFINE.DISABLE_BUTTON_BACK_COLOR;
                }
            }));
        }

        #endregion EnableRjButton

        #region EnableRjRadioButton

        private bool _rjButtonRadioTodayEnable = true;
        private bool _rjButtonRadioWeekEnable = false;
        private bool _rjButtonRadioMonthEnable = false;
        private bool _rjButtonRadioCustomEnable = false;

        private void SetEnableRjRadioButton(RJButton button, bool isCheck)
        {
            if (button.Name == rjButtonRadioToday.Name)
            {
                _rjButtonRadioTodayEnable = isCheck;
            }
            else if (button.Name == rjButtonRadioWeek.Name)
            {
                _rjButtonRadioWeekEnable = isCheck;
            }
            else if (button.Name == rjButtonRadioMonth.Name)
            {
                _rjButtonRadioMonthEnable = isCheck;
            }
            else if (button.Name == rjButtonRadioCustom.Name)
            {
                _rjButtonRadioCustomEnable = isCheck;
            }
            else
            {
                return;
            }

            button.Invoke((MethodInvoker)(() =>
            {
                if (isCheck)
                {
                    button.ForeColor = DEFINE.RJBUTTON_UNCHECK_COLOR;
                    button.TextColor = DEFINE.RJBUTTON_UNCHECK_COLOR;
                    button.BorderColor = DEFINE.RJBUTTON_UNCHECK_COLOR;
                }
                else
                {
                    button.ForeColor = DEFINE.LIGHT_COLOR;
                    button.TextColor = DEFINE.LIGHT_COLOR;
                    button.BorderColor = DEFINE.LIGHT_COLOR;
                }
            }));
        }

        #endregion EnableRjRadioButton

        public UserControlCartesianChart(Form1 form, bool isDockingBar = true)
        {
            _parentForm = form;

            InitializeComponent();

            // 도킹바가 아니면 창 내부
            if (!isDockingBar)
            {
                PanelTemperature1.Visible = false;
                PanelTemperature2.Visible = false;
                PanelTemperature3.Visible = false;
                ChartClearToolStripMenuItem.Visible = false;
            }
        }


        // 부모 패널 사이즈 받아와서 적용
        public void OnSizeChange(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        private void UserControlGraphTemperature_Load(object sender, EventArgs e)
        {
            // 툴팁 설정
            //cartesianChart1.TooltipFont = new System.Drawing.Font("Noto Sans CJK KR Regular", 9.25F);
            //cartesianChart1.TooltipTextColor = DEFINE.LIGHT_COLOR;
            //cartesianChart1.TooltipBackColor = DEFINE.BUTTON_BACKGROUND_COLOR;

            // 그래프 필 그라데이션 설정
            LinearGradientPaint redGradient = new LinearGradientPaint(
                new[] { DEFINE.SK_ALPHA_RED, DEFINE.SK_BACKGROUND }, new SKPoint(0.5f, 0), new SKPoint(0.5f, 1));
            LinearGradientPaint turquoiseGradient = new LinearGradientPaint(
                new[] { DEFINE.SK_ALPHA_TURQUOISE, DEFINE.SK_BACKGROUND }, new SKPoint(0.5f, 0), new SKPoint(0.5f, 1));

            ISeries[] _series = new ISeries[] {
                new LineSeries<DateTimePoint>
                {
                    Name = "ML Data",
                    TooltipLabelFormatter = (chartPoint) =>
                         $"{new DateTime((long) chartPoint.SecondaryValue):MM-dd HH:mm:ss}\r\nML {chartPoint.PrimaryValue}°C",
                     Values = _dateTimePointsML,
                     LineSmoothness = 1,
                    GeometrySize = 0.1d,
                     Fill = turquoiseGradient,
                     Stroke = new SolidColorPaint
                     {
                         Color = DEFINE.SK_SOLID_TURQUOISE,
                         StrokeThickness = 2,
                         StrokeCap = SKStrokeCap.Square,
                     },
                },
                new LineSeries<DateTimePoint>
                {
                    Name = "Temperature",
                    TooltipLabelFormatter = (chartPoint) =>
                         $"{new DateTime((long) chartPoint.SecondaryValue):MM-dd HH:mm:ss}\r\nTemperature {chartPoint.PrimaryValue}°C",
                    Values = _dateTimePointsTemp,
                    LineSmoothness = 1,
                    GeometrySize = 0.1d,
                    Fill = redGradient,
                    Stroke = new SolidColorPaint
                    {
                        Color = DEFINE.SK_SOLID_RED,
                        StrokeThickness = 2,
                        StrokeCap = SKStrokeCap.Round,
                    }
                },
                new ScatterSeries<DateTimePoint, AlarmMarkerGeometry>
                {
                     Values = _dateTimePointsScatter,
                     Stroke = null,
                     GeometrySize = 18,
                     TooltipLabelFormatter = (chartPoint) => $"{_alarmEventType} {new DateTime((long) chartPoint.SecondaryValue):HH:mm:ss}",
                     Fill = new SolidColorPaint(DEFINE.SK_ALARM_COLOR),
                },
            };

            DateTime sampleStart = new DateTime(_current.Year, _current.Month, _current.Day, 0, 0, 0);
            DateTime sampleEnd = new DateTime(_current.Year, _current.Month, _current.Day, 23, 59, 59);
            currentMinLimit = sampleStart.Ticks;
            currentMaxLimit = sampleEnd.Ticks;

            _xaxes = new Axis[]
            {
               new Axis
               {
                   Name = "Date & Time",
                   NameTextSize = 12,
                   NamePaint =  new SolidColorPaint(DEFINE.SK_FONTCOLOR_SUB),
                   Labeler = value => value > 0 ? new DateTime((long) value).ToString("MM-dd HH:mm:ss") : string.Empty,
                   //LabelsRotation = 15,
                   TextSize = 10,
                   LabelsPaint = new SolidColorPaint(DEFINE.SK_FONTCOLOR),
                   UnitWidth = TimeSpan.FromHours(1).Ticks,
                   MinStep = TimeSpan.FromMinutes(1).Ticks,
                   MinLimit = currentMinLimit,
                   MaxLimit = currentMaxLimit
               }
            };
            _yaxes = new Axis[]
            {
                new Axis
                {
                    Name = "Temperature",
                    NameTextSize = 12,
                    NamePaint =  new SolidColorPaint(DEFINE.SK_FONTCOLOR_SUB),
                    Labeler = value => value > 0 ? $"{value}°C" : string.Empty,
                    TextSize = 12,
                    LabelsPaint = new SolidColorPaint(DEFINE.SK_FONTCOLOR),
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

            //InitializingDateTime();

            // 줌 팬 모드
            cartesianChart1.ZoomMode = ZoomAndPanMode.X;
        }

        // 디바이스 아이디 변경 or 초기화
        private void InitializingDeviceId()
        {
            _cts?.Cancel();

            LabelTemperatureGraphCondition?.Invoke(new Action(() =>
            {
                LabelTemperatureGraphCondition.Text = string.Empty;
            }));

            if (_deviceId.Length > 0)
            {
                SetEnableRjButton(ButtonTemperatureSet, true);
                SetEnableRjButton(rjButtonRadioToday, true);
                SetEnableRjButton(rjButtonRadioWeek, true);
                SetEnableRjButton(rjButtonRadioMonth, true);
                SetEnableRjButton(rjButtonRadioCustom, true);
            }
            else
            {
                _oldDeviceId = string.Empty;

                SetEnableRjButton(ButtonTemperatureSet, false);
                SetEnableRjButton(rjButtonRadioToday, false);
                SetEnableRjButton(rjButtonRadioWeek, false);
                SetEnableRjButton(rjButtonRadioMonth, false);
                SetEnableRjButton(rjButtonRadioCustom, false);
            }

            InitializingDateTime();
        }

        // 데이트타임 컨트롤 초기화
        private void InitializingDateTime()
        {
            if (_alarmEventTime != null)
            {
                DateTime eventTime = _alarmEventTime ?? _current;
                rjDatePickerStart.Invoke((MethodInvoker)(() =>
                {
                    rjDatePickerStart.Value = new DateTime(eventTime.Year, eventTime.Month, eventTime.Day, 0, 0, 0);
                }));
                rjDateTimeChangerStart.Invoke((MethodInvoker)(() =>
                {
                    rjDateTimeChangerStart.Value = new DateTime(eventTime.Year, eventTime.Month, eventTime.Day, 0, 0, 0);
                }));
                rjDatePickerEnd.Invoke((MethodInvoker)(() =>
                {
                    rjDatePickerEnd.Value = new DateTime(eventTime.Year, eventTime.Month, eventTime.Day, 0, 0, 0);
                }));
                rjDateTimeChangerEnd.Invoke((MethodInvoker)(() =>
                {
                    rjDateTimeChangerEnd.Value = new DateTime(eventTime.Year, eventTime.Month, eventTime.Day, 23, 59, 59);
                }));

                rjButtonRadioCustom.Invoke((MethodInvoker)(() =>
                {
                    _rjButtonRadioCustomEnable = true;
                    RjButtonRadioCustom_Click(null, null);
                }));
            }
            else
            {
                rjDatePickerStart.Invoke((MethodInvoker)(() =>
                {
                    rjDatePickerStart.Value = new DateTime(_current.Year, _current.Month, _current.Day, 0, 0, 0);
                }));
                rjDateTimeChangerStart.Invoke((MethodInvoker)(() =>
                {
                    rjDateTimeChangerStart.Value = new DateTime(_current.Year, _current.Month, _current.Day, 0, 0, 0);
                }));
                rjDatePickerEnd.Invoke((MethodInvoker)(() =>
                {
                    rjDatePickerEnd.Value = new DateTime(_current.Year, _current.Month, _current.Day, 0, 0, 0);
                }));
                rjDateTimeChangerEnd.Invoke((MethodInvoker)(() =>
                {
                    rjDateTimeChangerEnd.Value = new DateTime(_current.Year, _current.Month, _current.Day, 23, 59, 59);
                }));

                rjButtonRadioToday.Invoke((MethodInvoker)(() =>
                {
                    _rjButtonRadioTodayEnable = true;
                    RjButtonRadioToday_Click(null, null);
                }));
            }
        }

        // 사용자 설정 날짜 및 시간으로 실행(커스텀)
        private void ButtonTemperatureSet_Click(object sender, EventArgs e)
        {
            if (_rjButtonSetEnable)
            {
                // 버튼 클릭 시 무조건 동작할 수 있게
                _rjButtonRadioCustomEnable = true;

                RjButtonRadioCustom_Click(null, null);
            }
        }

        // 그래프 초기화
        private void ButtonTemperatureClear_Click(object sender, EventArgs e)
        {
            //temp : 알림 마커 표시 테스트
            //DateTime sampleTest = new DateTime(_current.Year, _current.Month, _current.Day, 12, 59, 59);
            //SetMarker(sampleTest, 30d);
            //return;

            if (_rjButtonClearEnable)
            {
                ChartClearToolStripMenuItem_Click(sender, e);
            }
        }

        // 리스트 수신이 끝나면 이벤트를 확인
        private void CheckEventMarker()
        {
            if (_alarmEventTime != null && _alarmEventType != null)
            {
                DateTime eventTime = (DateTime)_alarmEventTime;

                // temp test
                // eventTime = _current.AddHours(-1);

                double distance = double.MaxValue;
                double? value = null;

                // 가장 가까운 시간대의 온도를 찾아 가져온다.
                // 이벤트 리스트 받을 때 온도 데이터를 받을 수 있으면 생략할 수 있음
                foreach (DateTimePoint item in _dateTimePointsTemp)
                {
                    //if(item.DateTime == eventTime
                    if (Math.Abs(item.DateTime.Ticks - eventTime.Ticks) < distance)
                    {
                        distance = Math.Abs(item.DateTime.Ticks - eventTime.Ticks);
                        value = item.Value;
                    }
                }

                // 영역에 포함되어 있을 경우에만 표시
                if (currentMinLimit <= eventTime.Ticks && currentMaxLimit >= eventTime.Ticks)
                {
                    if (value == null)
                    {
                        //없으면 대충 중앙에 표시
                        value = 25;
                    }

                    SetMarker(eventTime, value);
                }
            }
        }

        // 알림 마커 표시
        private void SetMarker(DateTime dateTime, double? value)
        {
            lock (_collectionLock)
            {
                cartesianChart1.Invoke(new Action(() =>
                {
                    _dateTimePointsScatter.Clear();
                    _dateTimePointsScatter.Add(new DateTimePoint(dateTime, value));
                }));
            }
        }

        private void RjButtonRadioToday_Click(object sender, EventArgs e)
        {
            if (_rjButtonRadioTodayEnable)
            {
                if (_deviceId.Length <= 0)
                {
                    return;
                }

                DateTime endDateTime = DateTime.Now;
                DateTime startDateTime = endDateTime.AddDays(-1);

                if (rangeSet == TEMPERATURE_GRAPH_RANGE.Today && _oldDeviceId == _deviceId)
                {
                    TimeSpan span = endDateTime - _oldEndDateTime;
                    // 3분 이내 데이터면 갱신 X
                    if (Math.Abs(span.TotalSeconds) < 180)
                    {
                        return;
                    }
                }

                rangeSet = TEMPERATURE_GRAPH_RANGE.Today;
                _oldDeviceId = _deviceId;
                _oldStartDateTime = startDateTime;
                _oldEndDateTime = endDateTime;
                GetDataFromRest(_deviceId, startDateTime, endDateTime);

                SetEnableRjRadioButton(rjButtonRadioToday, false);
                SetEnableRjRadioButton(rjButtonRadioWeek, true);
                SetEnableRjRadioButton(rjButtonRadioMonth, true);
                SetEnableRjRadioButton(rjButtonRadioCustom, true);
            }
        }

        private void RjButtonRadioWeek_Click(object sender, EventArgs e)
        {
            if (_rjButtonRadioWeekEnable)
            {
                if (_deviceId.Length <= 0)
                {
                    return;
                }

                DateTime endDateTime = DateTime.Now;
                DateTime startDateTime = endDateTime.AddDays(-7);

                if (rangeSet == TEMPERATURE_GRAPH_RANGE.Week && _oldDeviceId == _deviceId)
                {
                    TimeSpan span = endDateTime - _oldEndDateTime;
                    // 3분 이내 데이터면 갱신 X
                    if (Math.Abs(span.TotalSeconds) < 180)
                    {
                        return;
                    }
                }
                rangeSet = TEMPERATURE_GRAPH_RANGE.Week;
                _oldDeviceId = _deviceId;
                _oldStartDateTime = startDateTime;
                _oldEndDateTime = endDateTime;
                GetDataFromRest(_deviceId, startDateTime, endDateTime);

                SetEnableRjRadioButton(rjButtonRadioToday, true);
                SetEnableRjRadioButton(rjButtonRadioWeek, false);
                SetEnableRjRadioButton(rjButtonRadioMonth, true);
                SetEnableRjRadioButton(rjButtonRadioCustom, true);
            }
        }

        private void RjButtonRadioMonth_Click(object sender, EventArgs e)
        {
            if (_rjButtonRadioMonthEnable)
            {
                if (_deviceId.Length <= 0)
                {
                    return;
                }

                DateTime endDateTime = DateTime.Now;
                DateTime startDateTime = endDateTime.AddDays(-30);

                if (rangeSet == TEMPERATURE_GRAPH_RANGE.Month && _oldDeviceId == _deviceId)
                {
                    TimeSpan span = endDateTime - _oldEndDateTime;
                    // 3분 이내 데이터면 갱신 X
                    if (Math.Abs(span.TotalSeconds) < 180)
                    {
                        return;
                    }
                }
                rangeSet = TEMPERATURE_GRAPH_RANGE.Month;
                _oldDeviceId = _deviceId;
                _oldStartDateTime = startDateTime;
                _oldEndDateTime = endDateTime;
                GetDataFromRest(_deviceId, startDateTime, endDateTime);

                SetEnableRjRadioButton(rjButtonRadioToday, true);
                SetEnableRjRadioButton(rjButtonRadioWeek, true);
                SetEnableRjRadioButton(rjButtonRadioMonth, false);
                SetEnableRjRadioButton(rjButtonRadioCustom, true);
            }
        }

        private void RjButtonRadioCustom_Click(object sender, EventArgs e)
        {
            if (_rjButtonRadioCustomEnable)
            {
                if (_deviceId.Length <= 0)
                {
                    return;
                }

                DateTime startDate = rjDatePickerStart.Value;
                DateTime startTime = rjDateTimeChangerStart.Value;
                DateTime endDate = rjDatePickerEnd.Value;
                DateTime endTime = rjDateTimeChangerEnd.Value;

                DateTime startDateTime = new DateTime(startDate.Year, startDate.Month, startDate.Day, startTime.Hour, startTime.Minute, startTime.Second);
                DateTime endDateTime = new DateTime(endDate.Year, endDate.Month, endDate.Day, endTime.Hour, endTime.Minute, endTime.Second);
                TimeSpan span = endDateTime - startDateTime;
                if (span.Ticks <= 0)
                {
                    Console.WriteLine($"FAIL_TIME_EXCEPTION");
                    return;
                }
                if (span.TotalDays > 30)
                {
                    Console.WriteLine($"A maximum of 30 days can be specified.");
                    return;
                }

                if (rangeSet == TEMPERATURE_GRAPH_RANGE.Custom && _oldDeviceId == _deviceId)
                {
                    TimeSpan startSpan = startDateTime - _oldStartDateTime;
                    TimeSpan endSpan = endDateTime - _oldEndDateTime;
                    // 3분 이내 데이터면 갱신 X
                    if (Math.Abs(startSpan.TotalSeconds) < 180
                        && Math.Abs(endSpan.TotalSeconds) < 180)
                    {
                        return;
                    }
                }

                rangeSet = TEMPERATURE_GRAPH_RANGE.Custom;
                _oldDeviceId = _deviceId;
                _oldStartDateTime = startDateTime;
                _oldEndDateTime = endDateTime;
                GetDataFromRest(_deviceId, startDateTime, endDateTime);

                SetEnableRjRadioButton(rjButtonRadioToday, true);
                SetEnableRjRadioButton(rjButtonRadioWeek, true);
                SetEnableRjRadioButton(rjButtonRadioMonth, true);
                SetEnableRjRadioButton(rjButtonRadioCustom, false);
            }
        }

        private void GetDataFromRest(string deviceId, DateTime startDateTime, DateTime endDateTime)
        {
            if (deviceId == null)
            {
                return;
            }

            string deviceName = string.Empty;
            if (_parentForm.DeviceList.ContainsKey(deviceId).Equals(true))
            {
                deviceName = $"[{_parentForm.DeviceList[deviceId].DeviceName}]";
            }
            else
            {
                // 디바이스 정보가 없습니다.
                return;
            }

            string logMessage = $"{deviceName}[{deviceId}]  {startDateTime:yyyy-MM-dd HH:MM:ss} ~ {endDateTime:yyyy-MM-dd HH:MM:ss}";
            // temp -> 장치 리스트를 수령하면 device 관련 표시 정보를 조건에 추가할 것
            LabelTemperatureGraphCondition.Invoke(new Action(() =>
            {
                LabelTemperatureGraphCondition.Text = logMessage;
            }));
            Console.WriteLine($"{logMessage}");

            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

            TimeSpan datetimeSpan = endDateTime - startDateTime;
            int days = Convert.ToInt32(Math.Ceiling(datetimeSpan.TotalDays));
            List<PostGraphParam> paRams = new List<PostGraphParam>();

            try
            {
                for (int i = days; i > 0; i--)
                {
                    token.ThrowIfCancellationRequested();

                    int index = days - i;
                    DateTime endDay = endDateTime.AddDays(-index);
                    DateTime preDay = (index + 1 == days) ? startDateTime : endDay.AddDays(-1).AddSeconds(1);

                    PostGraphParam param = new PostGraphParam
                    {
                        StartDate = Convert.ToInt32(ClientUtil.DateTimeToTimeStampSecond(preDay)),
                        CurrentDate = Convert.ToInt32(ClientUtil.DateTimeToTimeStampSecond(endDay)),
                        TabName = "today"
                    };
                    paRams.Add(param);
                    Console.WriteLine($"index {index}: {preDay:MM:dd HH:mm:ss} stamp:{param.StartDate} ~ {endDay:MM:dd HH:mm:ss} stamp:{param.CurrentDate}");
                }
                paRams.Reverse();

                //int pointInterval = days + days * (days - 1);
                int pointInterval = 1 * days;
                Console.WriteLine($"pointInterval need Check: {pointInterval}");

                lock (_collectionLock)
                {
                    cartesianChart1.Invoke(new Action(() =>
                    {
                        _dateTimePointsScatter.Clear();
                        _dateTimePointsTemp.Clear();
                        _dateTimePointsML.Clear();
                    }));
                }

                _xaxes[0].MinLimit = startDateTime.Ticks;
                _xaxes[0].MaxLimit = endDateTime.Ticks;

                currentMinLimit = startDateTime.Ticks;
                currentMaxLimit = endDateTime.Ticks;

                var task = Task.Run(() => _parentForm.GetDeviceGraph(deviceId, paRams[0]), token);
                task.ContinueWith(x =>
                {
                    try
                    {
                        token.ThrowIfCancellationRequested();

                        PhrsingGraphData data = x.Result;
                        if (data != null)
                        {
                            //Console.WriteLine($"receive count: {data.Dataset.Length} ML count: {data.AverageDataset.Length}");

                            if (data.Dataset.Length > 0 || data.AverageDataset.Length > 0)
                            {
                                try
                                {
                                    List<DateTimePoint> Temperature1 = new List<DateTimePoint>();
                                    foreach (PhrsingGraphDataSet dataSet in data.Dataset)
                                    {
                                        token.ThrowIfCancellationRequested();

                                        double? value = null;
                                        if (dataSet.Y != 0)
                                        {
                                            value = dataSet.Y;
                                        }
                                        DateTimePoint model = new DateTimePoint
                                        {
                                            DateTime = ClientUtil.TimeStampToDateTime(Convert.ToInt64(dataSet.X / 1000)),
                                            Value = value
                                        };
                                        Temperature1.Add(model);
                                    }
                                    List<DateTimePoint> Temperature2 = new List<DateTimePoint>();
                                    foreach (PhrsingGraphDataSet dataSet in data.AverageDataset)
                                    {
                                        token.ThrowIfCancellationRequested();

                                        double? value = null;
                                        if (dataSet.Y != 0)
                                        {
                                            value = dataSet.Y;
                                        }
                                        DateTimePoint model = new DateTimePoint
                                        {
                                            DateTime = ClientUtil.TimeStampToDateTime(Convert.ToInt64(dataSet.X / 1000)),
                                            Value = value
                                        };
                                        Temperature2.Add(model);
                                    }
                                    (Temperature1, Temperature2) = GetScaleDistributionPoint2(Temperature1, Temperature2, pointInterval, token);
                                    //Console.WriteLine($"view count: {Temperature1.Count} ML count: {Temperature2.Count}");

                                    //챠트 인터벌 때문에 안하려했는데 foreach로 변경하면서 적용
                                    var nextTask = Task.Run(() => CreateDrawChartData(Temperature1, Temperature2), token);
                                    nextTask.ContinueWith(_ =>
                                    {
                                        if (days > 1)
                                        {
                                            RemainderGetData(deviceId, paRams, 1, days, pointInterval, token);
                                        }
                                        else
                                        {
                                            // 끝나서
                                            CheckEventMarker();
                                        }
                                    }, TaskScheduler.FromCurrentSynchronizationContext());
                                }
                                catch { }
                            }
                            else
                            {
                                // 처음이 없더라도 이후 날짜 확인
                                if (days > 1)
                                {
                                    RemainderGetData(deviceId, paRams, 1, days, pointInterval, token);
                                }
                            }
                        }
                        else
                        {
                            string message = $"Failed: Rest GetDeviceGraph s:{paRams[0].StartDate} c:{paRams[0].CurrentDate}";
                            Console.WriteLine($"{message}");
                        }
                    }
                    catch { }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            catch { }
        }

        // 데이터 할부 받기
        // 재귀함수
        public void RemainderGetData(string deviceId, List<PostGraphParam> paRams, int currentOffset, int endOffset,
            int pointInterval, CancellationToken token)
        {
            if (_cts.IsCancellationRequested)
            {
                return;
            }
            var task = Task.Run(() => _parentForm.GetDeviceGraph(deviceId, paRams[currentOffset]), token);
            task.ContinueWith(async x =>
            {
                try
                {
                    token.ThrowIfCancellationRequested();

                    PhrsingGraphData data = x.Result;
                    if (data != null)
                    {
                        if (data.Dataset.Length > 0 || data.AverageDataset.Length > 0)
                        {
                            List<DateTimePoint> Temperature1 = new List<DateTimePoint>();
                            foreach (PhrsingGraphDataSet dataSet in data.Dataset)
                            {
                                if (_cts.IsCancellationRequested)
                                {
                                    return;
                                }

                                double? value = null;
                                if (dataSet.Y != 0)
                                {
                                    value = dataSet.Y;
                                }
                                DateTimePoint model = new DateTimePoint
                                {
                                    DateTime = ClientUtil.TimeStampToDateTime(Convert.ToInt64(dataSet.X / 1000)),
                                    Value = value
                                };
                                Temperature1.Add(model);
                            }
                            List<DateTimePoint> Temperature2 = new List<DateTimePoint>();
                            foreach (PhrsingGraphDataSet dataSet in data.AverageDataset)
                            {
                                if (_cts.IsCancellationRequested)
                                {
                                    return;
                                }

                                double? value = null;
                                if (dataSet.Y != 0)
                                {
                                    value = dataSet.Y;
                                }
                                DateTimePoint model = new DateTimePoint
                                {
                                    DateTime = ClientUtil.TimeStampToDateTime(Convert.ToInt64(dataSet.X / 1000)),
                                    Value = value
                                };
                                Temperature2.Add(model);
                            }

                            (Temperature1, Temperature2) = GetScaleDistributionPoint2(Temperature1, Temperature2, pointInterval, token);
                            //Console.WriteLine($"view count: {Temperature1.Count} ML count: {Temperature2.Count}");

                            //챠트 인터벌 때문에 안하려했는데 foreach로 변경하면서 적용
                            await Task.Run(() => AddDrawChartData(Temperature1, Temperature2), token);
                            if (endOffset - 1 > currentOffset)
                            {
                                currentOffset++;
                                RemainderGetData(deviceId, paRams, currentOffset, endOffset, pointInterval, token);
                            }
                            else
                            {
                                //끝나서
                                CheckEventMarker();
                            }
                        }
                        else
                        {
                            if (endOffset - 1 > currentOffset)
                            {
                                currentOffset++;
                                RemainderGetData(deviceId, paRams, currentOffset, endOffset, pointInterval, token);
                            }
                            else
                            {
                                //끝나서
                                CheckEventMarker();
                            }
                        }
                    }
                    else
                    {
                        string message = $"Failed: Rest GetDeviceGraph s:{paRams[0].StartDate} c:{paRams[0].CurrentDate}";
                        Console.WriteLine($"{message}");
                    }
                }
                catch { }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        // 챠트 만들기
        private void CreateDrawChartData(List<DateTimePoint> models1, List<DateTimePoint> models2)
        {
            if (models1 == null || models2 == null)
            {
                string message = $"Failed: GetDeviceGraph Model == null";
                Console.WriteLine($"{message}");
                return;
            }

            lock (_collectionLock)
            {
                cartesianChart1.Invoke(new Action(() =>
                {
                    foreach (var item in models1)
                    {
                        _dateTimePointsTemp.Add(item);
                    }

                    foreach (var item in models2)
                    {
                        _dateTimePointsML.Add(item);
                    }
                }));
            }
        }

        // 챠트 그리기
        private Task AddDrawChartData(List<DateTimePoint> models1, List<DateTimePoint> models2)
        {
            if (models1 != null || models2 != null)
            {
                try
                {
                    lock (_collectionLock)
                    {
                        cartesianChart1.Invoke(new Action(() =>
                        {
                            foreach (var item in models1)
                            {
                                _dateTimePointsTemp.Add(item);
                            }

                            foreach (var item in models2)
                            {
                                _dateTimePointsML.Add(item);
                            }
                        }));
                    }
                }
                catch { }
            }
            return Task.CompletedTask;
        }

        // scale 기준 2개 동시 강제
        public static (List<DateTimePoint>, List<DateTimePoint>) GetScaleDistributionPoint2(List<DateTimePoint> list1,
            List<DateTimePoint> list2, int scale, CancellationToken token)
        {
            List<DateTimePoint> rslt = new List<DateTimePoint>();
            List<DateTimePoint> rslt2 = new List<DateTimePoint>();
            try
            {
                DateTime oldDateTime = new DateTime();
                double? oldValue = null;

                try
                {
                    for (int i = 0; i < list1.Count; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        // 처음을 제외하고
                        // 직전 값이 0 이 아닌데 현재 값이 0이 아닐 때의 직전 값 (저절로 처음이 제외)
                        if (oldValue != null && list1[i].Value == null)
                        {
                            DateTimePoint newModel = new DateTimePoint
                            {
                                DateTime = oldDateTime,
                                Value = oldValue
                            };
                            rslt.Add(newModel);

                            try
                            {
                                foreach (DateTimePoint tempModel in list2)
                                {
                                    token.ThrowIfCancellationRequested();

                                    if (oldDateTime.Equals(tempModel.DateTime))
                                    {
                                        rslt2.Add(tempModel);
                                        break;
                                    }
                                }
                            }
                            catch { }
                        }

                        // 온도가 35도 이상
                        // 리스트의 마지막 값이거나
                        // scale 값의 배수이거나 (리스트의 처음 값 포함)
                        // 직전 값이 0 인데 현재 값이 0이 아니거나 현재 값
                        if (list1[i].Value >= 35d || i == list1.Count - 1 || i % scale == 0d || (oldValue == null && list1[i].Value != null))
                        {
                            rslt.Add(list1[i]);

                            try
                            {
                                foreach (DateTimePoint tempModel in list2)
                                {
                                    token.ThrowIfCancellationRequested();

                                    if (list1[i].DateTime.Equals(tempModel.DateTime))
                                    {
                                        rslt2.Add(tempModel);
                                        break;
                                    }
                                }
                            }
                            catch { }
                        }

                        // 비교를 위해 담기
                        oldValue = list1[i].Value;
                        oldDateTime = list1[i].DateTime;
                    }
                }
                catch { }
            }
            catch { }

            return (rslt, rslt2);
        }

        private void ChartClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dateTimePointsTemp.Clear();
            _dateTimePointsML.Clear();
            _dateTimePointsScatter.Clear();

            DeviceId = string.Empty;
            _oldDeviceId = string.Empty;
            _oldStartDateTime = new DateTime();
            _oldEndDateTime = new DateTime();
            currentMinLimit = null;
            currentMaxLimit = null;

            DateTime sampleStart = new DateTime(_current.Year, _current.Month, _current.Day, 0, 0, 0);
            DateTime sampleEnd = new DateTime(_current.Year, _current.Month, _current.Day, 23, 59, 59);
            currentMinLimit = sampleStart.Ticks;
            currentMaxLimit = sampleEnd.Ticks;

            SetEnableRjRadioButton(rjButtonRadioToday, true);
            SetEnableRjRadioButton(rjButtonRadioWeek, true);
            SetEnableRjRadioButton(rjButtonRadioMonth, true);
            SetEnableRjRadioButton(rjButtonRadioCustom, true);
        }

        private void ZoomClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentMaxLimit != null && currentMinLimit != null)
            {
                if (_xaxes != null)
                {
                    if (_xaxes.Length > 0)
                    {
                        _xaxes[0].MinLimit = currentMinLimit;
                        _xaxes[0].MaxLimit = currentMaxLimit;
                    }
                }
            }
        }

        private void UserControlGraphTemperature_SizeChanged(object sender, EventArgs e)
        {
            ButtonTemperatureSet.Invalidate();
            ButtonTemperatureClear.Invalidate();
            rjButtonRadioToday.Invalidate();
            rjButtonRadioWeek.Invalidate();
            rjButtonRadioMonth.Invalidate();
            rjButtonRadioCustom.Invalidate();
        }

        private void PictureBoxButtonStartTimeUp_Click(object sender, EventArgs e)
        {
            if (rjDateTimeChangerStart.Focused)
            {
                SendKeys.Send("{UP}");
            }
        }

        private void PictureBoxButtonStartTimeDown_Click(object sender, EventArgs e)
        {
            if (rjDateTimeChangerStart.Focused)
            {
                SendKeys.Send("{DOWN}");
            }
        }

        private void PictureBoxButtonEndTimeUp_Click(object sender, EventArgs e)
        {
            if (rjDateTimeChangerEnd.Focused)
            {
                SendKeys.Send("{UP}");
            }
        }

        private void PictureBoxButtonEndTimeDown_Click(object sender, EventArgs e)
        {
            if (rjDateTimeChangerEnd.Focused)
            {
                SendKeys.Send("{DOWN}");
            }
        }
    }
}