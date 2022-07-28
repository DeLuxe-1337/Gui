using System;
using System.Numerics;
using SkiaSharp;
using Xamarin.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace GuiFramework.Rendering
{
    internal class gButton : RenderObject
    {
        //Vectors
        public Vector2 Position;

        public Vector2 Size;

        //Colors
        public Color3 ClickColor = new Color3(40, 40, 40);

        public Color3 Color = new Color3(10, 10, 10);
        public Color3 HoverColor = new Color3(23, 82, 254);

        //Additional
        private bool Hovering;

        private string Text;

        //Elements
        public gRectangle rect = new gRectangle();

        public gText text = new gText("Click me!", new Color3(255, 255, 255), new Vector2(0, 0), 18);

        public gButton(Vector2 position, Vector2 size, Color3 backColor, Color3 hoverColor, string text = "Click me!", bool round = false)
        {
            Position = position;
            Size = size;
            rect.color = Color;
            HoverColor = hoverColor;
            rect.Rounded = round;
            this.Text = text;

            BindEvents();
        }

        public gButton(Vector2 position, Vector2 size, string text = "Click me!", bool rounded = false)
        {
            Position = position;
            Size = size;
            rect.Rounded = rounded;
            this.Text = text;

            BindEvents();
        }

        public void Render(SKCanvas canvas)
        {
            rect.Render(canvas);
            text.Render(canvas);
        }

        public void Update()
        {
            text.position = rect.GetCenter(offsety: 4);
            text.text = this.Text;

            rect.Position = Position;
            rect.Size = Size;
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