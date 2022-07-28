using System.Numerics;
using GuiFramework.Rendering;
using SkiaSharp;

namespace GuiFramework
{
    internal class gText : RenderObject
    {
        public Color3 color;
        public Vector2 position;
        public int size;
        public string text;

        public gText(string text, Color3 color, Vector2 position, int size = 24)
        {
            this.text = text;
            this.color = color;
            this.position = position;
            this.size = size;
        }

        public void Render(SKCanvas canvas)
        {
            var paint = new SKPaint
            {
                Color = color.GetColor(),
                IsAntialias = true,
                Style = SKPaintStyle.StrokeAndFill,
                TextAlign = SKTextAlign.Center,
                TextSize = size
            };

            var coord = new SKPoint(position.X, position.Y);
            canvas.DrawText(text, coord, paint);
        }

        public void Update()
        {
            //no need for text no anims etc
        }
    }
}