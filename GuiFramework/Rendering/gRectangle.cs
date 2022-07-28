using System;
using System.Drawing;
using System.Numerics;
using SkiaSharp;

namespace GuiFramework.Rendering
{
    internal class gRectangle : RenderObject
    {
        public Color3 color = new Color3(20, 20, 20);
        public Vector2 pos;

        public Vector2 Position = new Vector2();
        public bool Rounded = false;
        public Vector2 size;
        public Vector2 Size = new Vector2();

        public void Render(SKCanvas canvas)
        {
            var paint = new SKPaint
            {
                Color = color.GetColor(),
                IsAntialias = true,
                Style = SKPaintStyle.Fill,
                TextAlign = SKTextAlign.Center
            };

            var resl = Calculate();

            if (Rounded)
                canvas.DrawRoundRect(new SKRoundRect(resl, 8, 8), paint);
            else
                canvas.DrawRect(resl, paint);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        private SKRect Calculate()
        {
            var ret = new RectangleF(Position.X, Position.Y, Size.X, Size.Y);

            pos = new Vector2(ret.X, ret.Y);
            size = new Vector2(ret.Width, ret.Height);

            return new SKRect(ret.Left, ret.Top, ret.Right, ret.Bottom);
        }

        public Rectangle GetRectangle()
        {
            Calculate();
            return new Rectangle((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y);
        }

        public Vector2 GetCenter(int offsetx = 0, int offsety = 0)
        {
            var rect = GetRectangle();
            return new Vector2(rect.Left + rect.Width / 2 + offsetx, rect.Top + rect.Height / 2 + offsety);
        }
    }
}