using System.Windows.Forms;
using System.Drawing;

namespace sampleLiveChart2
{
    public class MenuColorTable : ProfessionalColorTable
    {
        //Fields
        private readonly Color backColor;
        private readonly Color leftColumnColor;
        private readonly Color borderColor;
        private readonly Color menuItemBorderColor;
        private readonly Color menuItemSelectedColor;
        private readonly Color menuItemSeparatorDark;
        private readonly Color menuItemTextColor;
        private readonly Color mainTextColor;

        //Constructor
        public MenuColorTable(Color primaryColor, Color primaryTextColor, Color textColor, Color custombackColor, Color customleftColumnColor, Color customBorderColor, Color customSeparatorColor)
        {
            backColor = custombackColor;
            leftColumnColor = customleftColumnColor;
            borderColor = customBorderColor;
            menuItemBorderColor = primaryColor;
            menuItemSelectedColor = primaryColor;
            menuItemSeparatorDark = customSeparatorColor;
            menuItemTextColor = primaryTextColor;
            mainTextColor = textColor;
        }

        //Overrides
        public override Color ToolStripDropDownBackground { get { return backColor; } }
        public override Color MenuBorder { get { return borderColor; } }
        public override Color MenuItemBorder { get { return menuItemBorderColor; } }
        public override Color MenuItemSelected { get { return menuItemSelectedColor; } }
        public override Color ImageMarginGradientBegin { get { return leftColumnColor; } }
        public override Color ImageMarginGradientMiddle { get { return leftColumnColor; } }
        public override Color ImageMarginGradientEnd { get { return leftColumnColor; } }
        public override Color SeparatorDark { get { return menuItemSeparatorDark; } }
        public override Color SeparatorLight { get { return menuItemSeparatorDark; } }
        public override Color CheckSelectedBackground { get { return menuItemTextColor; } }
        public override Color ButtonPressedBorder { get { return leftColumnColor; } }
        public override Color ButtonSelectedBorder { get { return leftColumnColor; } }
        public override Color CheckBackground { get { return mainTextColor; } }
        public override Color CheckPressedBackground { get { return mainTextColor; } }
    }
}
