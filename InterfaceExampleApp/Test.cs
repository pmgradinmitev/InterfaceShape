using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    public static class Test
    {
        public static IDrawable GetCircle()
        {
            return new Circle();
        }

        public static IDrawable GetRectangle() 
        { 
            return new Rectangle();
        }

        public static void PrintShape(IDrawable shape)
        {
            shape.Draw();
        }
    }
}
