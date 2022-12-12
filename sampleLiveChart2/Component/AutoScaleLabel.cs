using System.ComponentModel;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

// https://stackoverflow.com/questions/54816851/resize-a-labels-font-size-to-fit-within-a-panel-without-exceeding-a-maximum-fon
namespace sampleLiveChart2
{
    public class AutoScaleLabel : Label
    {
        public AutoScaleLabel() => InitializeComponent();

        private void InitializeComponent()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            this.AutoSize = false;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(this.ForeColor))
            using (StringFormat format = new StringFormat(StringFormatFlags.NoClip |
                   StringFormatFlags.NoWrap | StringFormatFlags.FitBlackBox))
            {
                format.Trimming = StringTrimming.None;

                Size clientSize = this.ClientSize;
                if (clientSize.Width < 100)
                {
                    clientSize.Width = 100;
                }

                SizeF textSize = e.Graphics.MeasureString(this.Text, this.Font, clientSize, format);



                bool isFlagWidth = false;
                bool isFlagHeight = false;
                if (textSize.Width > clientSize.Width)
                {
                    isFlagWidth = true;
                }
                if (textSize.Height > clientSize.Height)
                {
                    isFlagHeight = true;
                }

                if (isFlagWidth && isFlagHeight)
                {
                    float scaleWidth = (float)clientSize.Width / textSize.Width;
                    float scaleHeight = (float)clientSize.Height / textSize.Height;
                    float scale = scaleWidth > scaleHeight ? scaleHeight : scaleWidth;
                    e.Graphics.ScaleTransform(scale, scale);
                }
                else if (isFlagWidth)
                {
                    float scale = (float)clientSize.Width / textSize.Width;
                    e.Graphics.ScaleTransform(scale, scale);
                }
                else if(isFlagHeight)
                {
                    float scale = (float)clientSize.Height / textSize.Height;
                    e.Graphics.ScaleTransform(scale, scale);
                }
                else
                {
                    // none
                }

                e.Graphics.Clear(this.BackColor);
                e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
                e.Graphics.DrawString(this.Text, this.Font, brush, this.ClientRectangle, format);
            }
        }
    }
}
