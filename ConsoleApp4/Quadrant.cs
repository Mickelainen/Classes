using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Quadrant
    {
        //Field

        private int _base;
        private int _height;

        public Quadrant(int a, int b)
        {
            this._base = a;
            this._height = b;
        }
       
        public void PrintQuadrant(int x, int y)
        {
            
            for (int i = 0; i < x; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();

            for (int i = 0; i < y; i++)
            {
                
                Console.Write("#");
            }

            
        }

        
    }
}
