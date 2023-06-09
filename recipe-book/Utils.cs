using System.Data.SQLite;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace recipe_book
{
	internal static class Utils
	{
		public static void MakeRound(this Control control)
		{
            using GraphicsPath graphicsPath = new();
			control.Height = control.Width;
            graphicsPath.AddEllipse(0, 0, control.Width, control.Height);
            control.Region = new Region(graphicsPath);
        }

        public static Image Crop(this Image image)
        {
            Bitmap bitmap = (Bitmap)image;
            int rectSize = int.Min(image.Width, image.Height);
            Rectangle rect = new(0, 0, rectSize, rectSize);
            int offset = (image.Width - image.Height) / 2;
            if (offset < 0)
                rect.Y = offset;
            else
                rect.X = offset;
            return bitmap.Clone(rect, bitmap.PixelFormat);
        }

		public static byte[] ToBytes(this Image img)
		{
            using MemoryStream ms = new();
            img.Save(ms, ImageFormat.Bmp);
            return ms.ToArray();
        }

        public static Image? GetImage(this SQLiteDataReader rdr, int i)
        {
            if (rdr.GetValue(i) is not byte[] bytes)
                return null;
            using MemoryStream ms = new(bytes);
            return Image.FromStream(ms);
        }
    }
}
