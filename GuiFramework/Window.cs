using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GuiFramework.Rendering;
using SkiaSharp;
using SkiaSharp.Views.Desktop;

namespace GuiFramework
{
    public partial class Window : Form
    {
        public List<RenderObject> Buffer = new List<RenderObject>();

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            Gui.Initialize(this);
        }

        private void skiaView_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
        {
            var canvas = e.Surface.Canvas;

            canvas.Clear(new SKColor(50, 50, 50));

            foreach (var renderObject in Buffer)
            {
                renderObject.Render(canvas);
                renderObject.Update();
            }

            Gui.Update(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            skiaView.Invalidate();
        }

        private void skiaView_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.CallMouseMove(e.X, e.Y);
        }

        private void skiaView_MouseDown(object sender, MouseEventArgs e)
        {
            MouseEvent.CallMouseDown();
        }

        private void skiaView_MouseUp(object sender, MouseEventArgs e)
        {
            MouseEvent.CallMouseUp();
        }
    }
}