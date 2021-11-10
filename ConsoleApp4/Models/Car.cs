using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Car
    {
        //Fields -Egenskaper
        private string _regNr;
        private string _brand;
        private string _color;
        private string _fuelType;
        private double _fuelConsumptionPerMile;
        private double _maxFuel;
        private int _numberOfDoors;
        private int _year;

        //Property - Get & Set

        public string Model { get; set; } //Exempel på mer avancerat

        public string Brand
        {
            // Returnerar värdet
            get
            {
                return _brand;
            }
            // Tilldelar värdet
            set
            {
                _brand = value;
            }
        }

        public string Color
        {
            // Returnerar värdet
            get
            {
                return _color;
            }
            // Tilldelar värdet
            set
            {
                _color = value;
            }
        }

        public int Year
        {
            // Returnerar värdet
            get
            {
                return _year;
            }
            // Tilldelar värdet
            set
            {
                _year = value;
            }
        }

        //Metoder

        public void PrintInfo()
        {
            Console.WriteLine("Brand: {0}", _brand);
            Console.WriteLine("Color: {0}", _color);
            Console.WriteLine("Brand: {0}", _year);
        }


        //Konstruktor - skapar objekten
        public Car() 
        { 

        } 

        public Car(string b, string c, int y, string d)
        {
            this._brand = b;
            this._color = c;
            this._year = y;
            this._regNr = d;
        }

        public Car(string a, string b, string c, string d, double e, double f, int x, int y)
        {
            this._regNr = a;
            this._brand = b;
            this._color = c;
            this._fuelType = d;
            this._fuelConsumptionPerMile = f;
            this._numberOfDoors = x;
            this._year = y;
        }
        
    }
}
