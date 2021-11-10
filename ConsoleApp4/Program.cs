using System;
using ConsoleApp4.Models;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dog dog = new Dog();
            Dog dog1 = new Dog();

            dog.age = 20;
            dog.name = "Pluto";

            dog1.name = "grizzly";

            Console.WriteLine(dog.name);
            Console.WriteLine(dog.age);

            dog.Bark();
            

            Car car = new Car("Volvo", "Black", 1981);

            Console.WriteLine(car.Brand);
            car.Brand = "Ford";
            Console.WriteLine(car.Brand);

            Console.WriteLine(car.Color);
            car.Color = "Red";
            Console.WriteLine(car.Color);

            Console.WriteLine(car.Year);
            car.Year = 2020;
            Console.WriteLine(car.Year);
            

            car.PrintInfo();


            
            Car car1 = new Car();
            car.brand = "Saab";
            car.color = "röd";
            car.year = 2001;

            Console.WriteLine(car.brand);
            Console.WriteLine(car.color);
            Console.WriteLine(car.year);

            Car car2 = new Car("Ford", "Black", 2005);
            Console.WriteLine(car2._brand);
            Console.WriteLine(car2._color);
            Console.WriteLine(car2._year);
            

            Human human = new Human();
            

            Human human1 = new Human("Charlie", "Petersson", 31, "Hisingen", false);

            human.PrintInfo();
            human1.PrintInfo();

            human.Firstname = "Micke";
            human.Lastname = "Gustafsson";
            human.Age = 30;
            human.City = "GBG";
            human.Isparent = false;

            human1.Firstname = "Calle";
            human1.Lastname = "Pett";
            human1.Age = 30;
            human1.City = "Eketrä";
            human1.Isparent = true;

            human.PrintInfo();
            human1.PrintInfo();
            

            Quadrant quadrant = new Quadrant(8, 8);

            Human human = new Human();
   
            quadrant.PrintTriangle();
            */

            Dog dog = new Dog("Lufsen", 4, "Dog", true, "Tax", "black");

            Lasagne lasagne = new Lasagne("Mickes lasagne", new string[] { "ost", "köttfärs", "lök" });

            Console.WriteLine("test");
            
        }
    }
}
 