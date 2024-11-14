﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    public class Circle:IDrawable
    {
        public void Draw()
        {
            double radius;
            double thickness = 0.4;
            ConsoleColor BorderColor = ConsoleColor.Green;
            Console.ForegroundColor = BorderColor;

            char symbol = '*';
            radius = 5;

            Console.WriteLine();
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y=radius; y>= -radius; --y)
            {
                for (double x =-radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn*rIn && value <= rOut*rOut)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
