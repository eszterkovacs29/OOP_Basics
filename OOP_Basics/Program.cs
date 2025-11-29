using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOP_Basics
{
    internal class Program
    {
        class Vehicle
        {
            private string color;
            private string brand;
            private string type;

            public Vehicle(string color, string brand, string type)
            {
                this.color = color;
                this.brand = brand;
                this.type = type;
            }

          
            public string GetColor()
            {
                return this.color;
            }
            public string GetBrand()
            {
                return this.brand;
            }
            public string GetType()
            {
                return this.type;
            }

            public void SetColor(string color)
            {
                this.color = color;
            }


            public void Move()
            {
                if (this.type == "Ship")
                {
                    Console.WriteLine($"This {this.color} {this.type} sails in the water");
                }
                else if(this.type == "Car")
                {
                    Console.WriteLine($"This {this.color} {this.type} rolls on the road on four wheels");
                }
                else if (this.type == "Bike")
                {
                    Console.WriteLine($"This {this.color} {this.type} rolls on the road on two wheels");
                }
            }   
        }
        class Animal
        {
            public string color;
            public string species;
            public string habitat;
            public Animal(string color, string species, string habitat)
            {
                this.color = color;
                this.species = species;
                this.habitat = habitat;
            }
            public void Sound()
            {
                if (this.species == "Bird")
                {
                    Console.WriteLine($"This {this.color} {this.species} lives in {this.habitat} and sings.");
                }
                if (this.species == "Cat")
                {
                    Console.WriteLine($"This {this.color} {this.species} lives in {this.habitat} and meows.");
                }
                if (this.species == "Dog")
                {
                    Console.WriteLine($"This {this.color} {this.species} lives in {this.habitat} and barks.");
                }
            }
        }   
        static void WelcomeUser(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        static int Square(int number)
        {
            return number * number;
        }

        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("Black", "Audi", "Car");
            Vehicle ship = new Vehicle("Whhite", "Titanic", "Ship");
            Vehicle bike = new Vehicle("Green", "Kawasaki", "Bike");

            Console.WriteLine($"Color property: {car.GetBrand()}");
            Console.WriteLine($"Car color: {car.GetColor()}");
            car.SetColor("Lila");
            Console.WriteLine($"Car color: {car.GetColor()}");


            Animal bird = new Animal("Black", "Bird","Forest");
            Animal cat = new Animal("Tabby", "Cat", "My apartment");
            Animal dog = new Animal("Brown", "Dog", "Garden");



            Console.ReadKey();
        }
    }
}
