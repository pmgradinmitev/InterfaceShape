using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    public class Rectangle:IDrawable
    {
        private int Width = 10;
        private int Height = 10;

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for(int i = 1; i< width-1; i++)
            {
                Console.Write(mid);
            }
            Console.WriteLine(end);
        }
        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height - 1; i++)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }
    }
}
