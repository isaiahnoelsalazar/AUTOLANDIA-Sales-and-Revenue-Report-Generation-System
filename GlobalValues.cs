using MaterialSkin;
using MaterialSkin.Controls;

namespace AUTOLANDIA_Sales_and_Revenue_Report_Generation_System
{
    public class GlobalValues
    {
        public static void SET_SKIN(MaterialForm MaterialForm)
        {
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(MaterialForm);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(0, 0, Primary.Grey500, 0, TextShade.WHITE);
        }
    }
}
