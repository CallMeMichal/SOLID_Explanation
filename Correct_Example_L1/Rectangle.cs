using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Example_L1
{
    public class Rectangle : Square
    {
        int a;
        int b;



        public void setHeight(int height)
        {
            this.a = height;
        }

        public void setWidth(int width)
        {
            this.b = width;
        }

        public int CalculateRectangleArea()
        {
            
            return this.a * this.b;
        }



    }
}
