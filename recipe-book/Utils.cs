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

		public static byte[] ToArray(this Image img)
		{
            using MemoryStream ms = new();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }

        public static Image ToImage(this byte[] array)
        {
            using MemoryStream ms = new(array);
            return Image.FromStream(ms);
        }
    }
}
