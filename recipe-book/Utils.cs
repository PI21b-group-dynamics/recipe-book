using System.Drawing.Drawing2D;

namespace recipe_book
{
	internal static class Utils
	{
		public static void MakeRound(Control control)
		{
            using GraphicsPath graphicsPath = new();
			control.Height = control.Width;
            graphicsPath.AddEllipse(0, 0, control.Width, control.Height);
            control.Region = new Region(graphicsPath);
        }
	}
}
