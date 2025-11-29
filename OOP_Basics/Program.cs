using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OOP_Basics
{
    internal class Program
    {
        class Vehicle
        {
            public string color;
            public string brand;
            public string type;
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
            public void Sound()
            {
                if (this.species == "bird")
                {
                    Console.WriteLine($"This {this.color} {this.species} lives in {this.habitat} and sings.");
                }
                if (this.species == "cat")
                {
                    Console.WriteLine($"This {this.color} {this.species} lives in {this.habitat} and meows.");
                }
                if (this.species == "dog")
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
            Vehicle car = new Vehicle();
            Vehicle ship = new Vehicle();
            Vehicle bike = new Vehicle();
            car.type = "Car";
            car.brand = "Audi";
            car.color = "Black";

            ship.type = "Ship";
            ship.brand = "Titanic";
            ship.color = "white";

            bike.type = "Bike";
            bike.brand = "Kawasaki";
            bike.color = "green";

            Animal bird = new Animal();
            Animal cat = new Animal();
            Animal dog = new Animal();

            bird.color = "black";
            bird.species = "bird";
            bird.habitat = "forest";

            cat.color = "tabby";
            cat.species = "cat";
            cat.habitat = "my apartment";

            dog.color = "brown";
            dog.species = "dog";
            dog.habitat = "garden";

            dog.Sound();
            cat.Sound();
            bird.Sound();

            Console.ReadKey();
        }
    }
}
