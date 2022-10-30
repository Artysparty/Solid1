using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IShape rect = new Rectangle();
            GraphicEditor ge = new GraphicEditor();
            ge.DrawShape(rect);
        }
    }
}
