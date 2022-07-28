using System;
using System.Numerics;
using GuiFramework.Rendering;
using SkiaSharp.Views.Desktop;

namespace GuiFramework
{
    internal class GuiProgram
    {
        public static gButton Test = new gButton(new Vector2(100, 40), new Vector2(100, 45), rounded: true);
        public static gButton Other = new gButton(new Vector2(100, 120), new Vector2(100, 45), "Try me!");

        public static void Initialize(Window window)
        {
            window.Buffer.Add(Test);
            Test.Activated += TestOnActivated;

            window.Buffer.Add(Other);
            Other.Activated += OtherOnActivated;
        }

        private static void OtherOnActivated(object sender, EventArgs e)
        {
        }

        private static void TestOnActivated(object sender, EventArgs e)
        {
            Console.WriteLine("User has pressed the Gui Button!");
        }

        public static void Update(Window window, SKPaintSurfaceEventArgs e)
        {
        }
    }
}