namespace Correct_Example_L1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 10;
            int width = 5;
            Rectangle rect = new Rectangle();

            if (height != width)
            {
                
                rect.setWidth(width);
                rect.setHeight(height);
                var a = rect.CalculateRectangleArea();
            }
            else
            {
                rect.CalculateSquareArea(height);
            }
        }
    }
}
