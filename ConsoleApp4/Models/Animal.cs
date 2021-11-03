using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    class Animal
    {
        //Fields
        internal string _name;
        internal int _age;
        internal string _type;
        internal bool _canFly;

        public Animal(string name, int age, string type, bool canFly)
        {
            this._name = name;
            this._age = age;
            this._type = type;
            this._canFly = canFly;
        }
    }

    

    class Dog : Animal
    {
        //Fields
        private string _breed;
        private string _color;

        public Dog(string name, int age, string type, bool canFly, string breed, string color) : base (name, age, type, canFly)
        {
            
            this._breed = breed;
            this._color = color;

        }
        
    }

}
