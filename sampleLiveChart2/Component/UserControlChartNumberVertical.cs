using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public partial class UserControlChartNumberVertical : UserControl
    {
        private List<CHART_NUMBER_PARAM> _list;
        public UserControlChartNumberVertical()
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
                    labelData1.Text = $"{list[0].Percent:00.00}";
                    labelCase1.Text = "%";
                }
                else
                {
                    labelData1.Text = $"{list[0].Values}";
                    labelCase1.Text = "Cases";
                }
            }

            // 확실하게 구분하기 위해 별도로 표시
            if (list.Count == 3)
            {
                autoScaleLabelTitle2.Text = list[1].SeriesName;
                autoScaleLabelTitle3.Text = list[2].SeriesName;

                if (isPieType)
                {
                    labelData2.Text = $"{list[1].Percent:00.00}";
                    labelCase2.Text = $"%";

                    labelData3.Text = $"{list[2].Percent:00.00}%";
                    labelCase3.Text = $"%";

                }
                else
                {
                    labelData2.Text = $"{list[1].Values}";
                    labelCase2.Text = $"Cases";

                    labelData3.Text = $"{list[2].Values}";
                    labelCase3.Text = $"Cases";
                }
            }
            else if (list.Count == 2)
            {
                autoScaleLabelTitle3.Text = list[1].SeriesName;

                if (isPieType)
                {
                    labelData3.Text = $"{list[1].Percent:00.00}%";
                    labelCase3.Text = $"%";
                }
                else
                {
                    labelData3.Text = $"{list[1].Values}";
                    labelCase3.Text = $"Cases";
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
                    // height 200이상 부터 위아래 padding 추가
                    int tall = panelMain.Height - 200;
                    if (_list.Count == 2)
                    {
                        tall = panelMain.Height - 150;
                    }

                    int paddingTopBottomValue = tall > 0 ? Convert.ToInt32(tall / 2) : 0;
                    this.panelMain.Padding = new System.Windows.Forms.Padding(5, paddingTopBottomValue, 5, paddingTopBottomValue);

                    int panelHeight = Convert.ToInt32((panelMain.Height - paddingTopBottomValue * 2) / _list.Count);
                    if (_list.Count == 2)
                    {
                        panelCase2.Visible = false;
                        panelCase1.Size = new Size(panelHeight, panelHeight);
                    }
                    else if (_list.Count == 3)
                    {
                        panelCase2.Visible = true;
                        
                        // 순서가 3 사이즈에 영향
                        panelCase2.BringToFront();
                        panelCase3.BringToFront();

                        panelCase1.Size = new Size(panelHeight, panelHeight);
                        panelCase2.Size = new Size(panelHeight, panelHeight);
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