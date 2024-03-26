namespace MySlideShow.Services
{
    internal class FontService
    {
        public static System.Drawing.Font GetFont(Models.Font f)
        {
            var style = GetFontStyle(f);
            return new System.Drawing.Font(new FontFamily(f.Name), f.Size, style, GraphicsUnit.Point);
        }

        private static FontStyle GetFontStyle(Models.Font f)
        {
            FontStyle s = FontStyle.Regular;

            if (f.Style.IndexOf("Bold") > 0)
                s = FontStyle.Bold;
            if (f.Style.IndexOf("Italic") > 0)
                s = FontStyle.Italic;
            if (f.Style.IndexOf("Underline") > 0)
                s |= FontStyle.Underline;
            if (f.Style.IndexOf("Strikeout") > 0)
                s |= FontStyle.Strikeout;

            return s;
        }

    }
}
