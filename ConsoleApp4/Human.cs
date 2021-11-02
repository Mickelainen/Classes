using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Human
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _city;
        private bool _isParent;

        public string Firstname
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
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

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public bool Isparent
        {
            get
            {
                return _isParent;
            }
            set
            {
                _isParent = value;
            }
        }



        public Human()
        {

        }

        public Human(string a, string b, int c, string d, bool e)
        {
            this._firstName = a;
            this._lastName = b;
            this._age = c;
            this._city = d;
            this._isParent = e;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Firstname: {0}", _firstName);
            Console.WriteLine("Lastname: {0}", _lastName);
            Console.WriteLine("Age: {0}", _age);
            Console.WriteLine("City: {0}", _city);
            Console.WriteLine("Is Parent: {0}", _isParent);
        }

    }
}
