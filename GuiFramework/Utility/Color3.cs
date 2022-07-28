using SkiaSharp;

namespace GuiFramework.Rendering
{
    public struct Color3
    {
        private readonly byte r;
        private readonly byte g;
        private readonly byte b;

        public Color3(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public SKColor GetColor()
        {
            return new SKColor(r, g, b);
        }
    }
}