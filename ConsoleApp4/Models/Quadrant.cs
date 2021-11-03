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

        public void PrintQuadrant()
        {

            for (int i = 0; i < _base; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();

            for (int i = 0; i < _height; i++)
            {

                Console.Write("#");
            }

        }

        public void PrintRectangel()
        {
            for (int y = 0; y < _height; y++)
            {
                for (int x = 0; x < _base; x++)
                {
                    Console.Write("# ");
                }
                Console.Write("\n");
            }
        }

        public void PrintTriangle()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _base; j++)
                {
                    if (j <= i)
                    {
                        Console.Write(" #");
                    }

                }
                Console.WriteLine();
            }
        }

        public void PrintTriangle3()
        {
            PrintTriangle2();

            for (int i = _height -2; i >= 0; i--)
            {
                for (int j = 0; j < _base * 2; j++)
                {
                    if (j >= _base - i && j <= _base + i)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else if (i % 2 == 1 && j % 2 == 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }



                }
                Console.WriteLine();
            }
        }

        public void PrintTriangle2()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _base * 2; j++)
                {
                    if (j >= _base - i && j <= _base + i)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            Console.Write("#");
                        }
                        else if (i % 2 == 1 && j % 2 == 1)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                    }



                }
                Console.WriteLine();
            }
        }

    }
    }

