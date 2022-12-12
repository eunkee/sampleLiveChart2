using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlChartNumberHorizontal : UserControl
    {
        private List<CHART_NUMBER_PARAM> _list;
        public UserControlChartNumberHorizontal()
        {
            InitializeComponent();
        }

        public void SetDrawData(List<CHART_NUMBER_PARAM> list, bool isPieType = false)
        {
            _list = list;

            ReDrawPanel();

            if (list.Count > 0)
            {
                autoScaleLabelTitle1.Text = list[0].SeriesName;

                if (isPieType)
                {
                    autoScaleLabelData1.Text = $"{list[0].Percent:00.00}%";
                }
                else
                {
                    autoScaleLabelData1.Text = $"{list[0].Values}";
                }
            }

            // 확실하게 구분하기 위해 별도로 표시
            if (list.Count == 3)
            {
                autoScaleLabelTitle2.Text = list[1].SeriesName;
                autoScaleLabelTitle3.Text = list[2].SeriesName;

                if (isPieType)
                {
                    autoScaleLabelData2.Text = $"{list[1].Percent:00.00}%";
                    autoScaleLabelData3.Text = $"{list[2].Percent:00.00}%";
                }
                else
                {
                    string seriesValue0 = list[0].Values.ToString();
                    string seriesValue1 = list[1].Values.ToString();
                    string seriesValue2 = list[2].Values.ToString();

                    // 글자 길이 맞추기
                    if (seriesValue0.Length != seriesValue1.Length 
                        || seriesValue1.Length != seriesValue2.Length 
                        || seriesValue2.Length != seriesValue0.Length)
                    {

                        int tempMax = Math.Max(seriesValue0.Length, seriesValue1.Length);
                        tempMax = Math.Max(seriesValue2.Length, tempMax);

                        int division0 = tempMax - seriesValue0.Length;
                        int division1 = tempMax - seriesValue1.Length;
                        int division2 = tempMax - seriesValue2.Length;
                        if (division0 > 0)
                        {
                            string frontSpace = string.Empty;
                            for (int i = 0; i < division0; i++)
                            {
                                frontSpace += " ";
                            }
                            seriesValue0 = $"{frontSpace}{seriesValue0}";
                        }
                        if (division1 > 0)
                        {
                            string frontSpace = string.Empty;
                            for (int i = 0; i < division1; i++)
                            {
                                frontSpace += " ";
                            }
                            seriesValue1 = $"{frontSpace}{seriesValue1}";
                        }
                        if (division2 > 0)
                        {
                            string frontSpace = string.Empty;
                            for (int i = 0; i < division2; i++)
                            {
                                frontSpace += " ";
                            }
                            seriesValue2 = $"{frontSpace}{seriesValue2}";
                        }
                    }

                    autoScaleLabelData1.Text = seriesValue0;
                    autoScaleLabelData2.Text = seriesValue1;
                    autoScaleLabelData3.Text = seriesValue2;
                }
            }
            else if (list.Count == 2)
            {
                autoScaleLabelTitle3.Text = list[1].SeriesName;
                if (isPieType)
                {
                    autoScaleLabelData3.Text = $"{list[1].Percent:00.00}%";
                }
                else
                {
                    string seriesValue0 = list[0].Values.ToString();
                    string seriesValue1 = list[1].Values.ToString();

                    // 글자 길이 맞추기
                    if (seriesValue0.Length != seriesValue1.Length)
                    {
                        int division = Math.Abs(seriesValue0.Length - seriesValue1.Length);
                        string frontSpace = string.Empty;
                        for (int i = 0; i < division; i++)
                        {
                            frontSpace += " ";
                        }

                        if (seriesValue0.Length > seriesValue1.Length)
                        {
                            seriesValue1 = $"{frontSpace}{seriesValue1}";
                        }
                        else
                        {
                            seriesValue0 = $"{frontSpace}{seriesValue0}";
                        }
                    }

                    autoScaleLabelData1.Text = seriesValue0;
                    autoScaleLabelData3.Text = seriesValue1;
                }

                

            }
            else
            {
                // none
            }




        }

        public void ClearData()
        {
            _list.Clear();
        }

        private void ReDrawPanel()
        {
            if (_list != null)
            {
                if (_list.Count > 0)
                {
                    // left margin 15
                    int panelMainWidth = panelMain.Width > 15 ? panelMain.Width - 15 : 0;
                    if (panelMainWidth <= 0)
                        return;

                    int panelWidth = Convert.ToInt32((panelMain.Width - 15) / _list.Count);
                    if (_list.Count == 2)
                    {
                        panelCase2.Visible = false;
                        panelCase1.Size = new Size(panelWidth, panelWidth);
                    }
                    else if (_list.Count == 3)
                    {
                        panelCase2.Visible = true;
                        
                        // 순서가 3 사이즈에 영향
                        panelCase2.BringToFront();
                        panelCase3.BringToFront();

                        panelCase1.Size = new Size(panelWidth, panelWidth);
                        panelCase2.Size = new Size(panelWidth, panelWidth);
                    }
                    else
                    {
                        // none
                    }
                }
            }
        }

        private void Panel4_SizeChanged(object sender, EventArgs e)
        {
            ReDrawPanel();
        }
    }
}