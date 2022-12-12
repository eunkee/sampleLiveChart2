using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace sampleLiveChart2
{
    public class RJDateTimeChanger : DateTimePicker
    {
        //Fields
        //-> Appearance
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.PaleVioletRed;
        private int borderSize = 0;

        //Properties
        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                this.Invalidate();
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set
            {
                textColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        //Constructor
        public RJDateTimeChanger()
        {
            //this.DoubleBuffered = true;
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);

            //this.SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor, true);

            //this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.Opaque, true);
            //this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5F);

            //this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.Opaque, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.Opaque, true);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams; cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //base.OnPaintBackground(e);
        }

        private Graphics _graphics;

        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            using (_graphics = this.CreateGraphics())
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (SolidBrush skinBrush = new SolidBrush(skinColor))
            using (SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using (SolidBrush textBrush = new SolidBrush(textColor))
            using (StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5F, this.Height - 0.5F);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                //Draw surface
                _graphics.FillRectangle(skinBrush, clientArea);
                //Draw text
                _graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                //Draw border 
                if (borderSize >= 1) _graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
            }
        }

        //protected override void OnHandleCreated(EventArgs e)
        //{
        //    base.OnHandleCreated(e);
        //}
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //}
    }
}
