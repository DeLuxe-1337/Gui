using SkiaSharp;

namespace GuiFramework.Rendering
{
    public interface RenderObject
    {
        void Render(SKCanvas canvas);

        void Update();
    }
}