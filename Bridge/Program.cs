using Bridge.Implementation;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Red = new Red();
            var Blue = new Blue();

            var Circle = new Circle(Red);
            var Rectangle = new Rectangle(Blue);

            Circle.DrawShape();
            Rectangle.DrawShape();

        }
    }
}
