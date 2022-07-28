using System;
using System.Drawing;
using System.Numerics;
using SkiaSharp;

namespace GuiFramework.Rendering
{
    internal class gButton : RenderObject
    {
        public Color3 ClickColor = new Color3(40, 40, 40);

        public Color3 Color = new Color3(10, 10, 10);
        public Color3 HoverColor = new Color3(23, 82, 254);
        private bool Hovering;
        public Vector2 Position;
        public gRectangle rect = new gRectangle();
        public Vector2 Size;
        public gText text = new gText("Click me!", new Color3(255, 255, 255), new Vector2(0, 0), 18);

        public gButton(Vector2 position, Vector2 size, Color3 backColor, Color3 hoverColor, bool round = false)
        {
            Position = position;
            Size = size;
            rect.color = Color;
            HoverColor = hoverColor;
            rect.Rounded = round;

            BindEvents();
        }

        public gButton(Vector2 position, Vector2 size, bool rounded = false)
        {
            Position = position;
            Size = size;
            rect.Rounded = rounded;

            BindEvents();
        }

        public void Render(SKCanvas canvas)
        {
            text.position = rect.GetCenter(offsety: 4);

            rect.Position = Position;
            rect.Size = Size;

            rect.Render(canvas);
            text.Render(canvas);
        }

        public void Update()
        {
        }

        private void BindEvents()
        {
            MouseEvent.Move += MouseEventOnMove;
            MouseEvent.Down += MouseEventOnDown;
            MouseEvent.Up += MouseEventOnUp;
        }

        private void MouseEventOnMove(object sender, (int x, int y) e)
        {
            var x = e.x;
            var y = e.y;

            var mouse = new Rectangle(x, y, 5, 5);
            var button = rect.GetRectangle();

            if (mouse.IntersectsWith(button))
            {
                rect.color = HoverColor;
                Hovering = true;
            }
            else
            {
                rect.color = Color;
                Hovering = false;
            }
        }

        public event EventHandler Activated;

        private void MouseEventOnUp(object sender, object e)
        {
            if (Hovering)
            {
                rect.color = HoverColor;
                Activated(null, null);
            }
        }

        private void MouseEventOnDown(object sender, object e)
        {
            if (Hovering)
                rect.color = ClickColor;
        }
    }
}