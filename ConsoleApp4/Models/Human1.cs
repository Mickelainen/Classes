using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    class Human
    {
        //fields
        private string _name;
        private int _age;
        private double _height;
        private string _location;

        //Properties (Get & Set Metoder)
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }
        public string Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }

        //Constructor
        public Human()
        {
        }

        public Human(string name, int age, double height, string location)
        {
            this._name = name;
            this._age = age;
            this._height = height;
            this._location = location;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name : {0}", _name);
        }
            
    }
}
