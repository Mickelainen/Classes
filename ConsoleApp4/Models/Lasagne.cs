using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    class Lasagne
    {
        List<string> _ingridients = new List<string>();
        string _lasagnaType;

        public Lasagne(string lasagnatype, string []ing)
        {
            _lasagnaType = lasagnatype;
            foreach (string item in ing)
            {
                _ingridients.Add(item);
            }
        }

        public int CookTime()
        {
            return 40;
        }

        public int CookTimeLeft(int timeCooked)
        {
            return CookTime() - timeCooked;
        }

        public int NumberOfLayers(int layers)
        {
            return layers * 2;
        }

        public int MinutesFromStart(int layers, int timeInOven)
        {
            return NumberOfLayers(layers) + timeInOven;
        }

    }
}
