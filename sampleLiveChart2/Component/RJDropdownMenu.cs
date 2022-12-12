using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace sampleLiveChart2
{
    public class RJDropdownMenu : ContextMenuStrip
    {
        //Fields
        private readonly Color menuItemTextColor = Color.FromArgb(164, 168, 185);
        private readonly Color primaryColor = Color.FromArgb(29, 37, 55);
        private readonly Color leftColumnColor = Color.FromArgb(44, 52, 72);
        private readonly Color borderColor = Color.FromArgb(16, 18, 28);
        private readonly Color primaryTextColor = Color.FromArgb(31, 214, 222);
        private readonly Color separatorColor = Color.FromArgb(37, 46, 66);

        //Constructor
        public RJDropdownMenu(IContainer container)
            : base(container)
        {

        }

        private void LoadMenuItemHeight()
        {
            // y값이 menuItemHeight
            Bitmap menuItemHeaderSize = new Bitmap(16, 32);

            // 재귀함수 자식 헤더 모두 사이즈 변경
            foreach (object item in this.Items)
            {
                if (item is ToolStripMenuItem menuItemChild)
                {
                    SetHeaderSize(menuItemChild, menuItemHeaderSize);

                }
            }
        }

        // 재귀함수 자식 헤더 모두 사이즈 변경
        private void SetHeaderSize(ToolStripMenuItem menuItem, Bitmap menuItemHeaderSize)
        {
            menuItem.ImageScaling = ToolStripItemImageScaling.None;
            if (menuItem.Image == null) menuItem.Image = menuItemHeaderSize;

            foreach (var item2 in menuItem.DropDownItems)
            {
                if (item2 is ToolStripMenuItem menuItemChild)
                {
                    SetHeaderSize(menuItemChild, menuItemHeaderSize);
                }
            }
        }

        //Overrides
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this.DesignMode == false)
            {
                this.Renderer = new MenuRenderer(primaryColor, primaryTextColor, menuItemTextColor, this.BackColor, leftColumnColor, borderColor, separatorColor);
                LoadMenuItemHeight();
            }
        }
    }
}
