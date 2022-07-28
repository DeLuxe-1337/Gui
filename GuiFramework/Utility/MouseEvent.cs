using System;

namespace GuiFramework
{
    internal class MouseEvent
    {
        public static event EventHandler<(int x, int y)> Move;

        public static event EventHandler<object> Down;

        public static event EventHandler<object> Up;

        public static void CallMouseMove(int x, int y)
        {
            Move(null, (x, y));
        }

        public static void CallMouseDown()
        {
            Down(null, null);
        }

        public static void CallMouseUp()
        {
            Up(null, null);
        }
    }
}