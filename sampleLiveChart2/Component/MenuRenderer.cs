﻿using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace sampleLiveChart2
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        //Fields
        private readonly Color primaryColor;
        private readonly Color primaryTextColor;
        private readonly Color textColor;
        private readonly int arrowThickness;

        //Constructor
        public MenuRenderer(Color primaryColor, Color primaryTextColor, Color textColor, Color backColor, Color leftColumnColor, Color borderColor, Color separatorColor)
            : base(new MenuColorTable(primaryColor, primaryTextColor, textColor, backColor, leftColumnColor, borderColor, separatorColor))
        {
            this.primaryColor = primaryColor;
            this.primaryTextColor = primaryTextColor;


            arrowThickness = 3;
            if (textColor == Color.Empty)
                this.textColor = Color.Gainsboro;
            else//Set custom text color 
                this.textColor = textColor;
        }

        //Overrides
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? primaryTextColor : textColor;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            //Fields
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12);
            var arrowColor = e.Item.Selected ? primaryTextColor : primaryColor;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                //Drawing
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);
                graph.DrawPath(pen, path);
            }
        }
    }
}
