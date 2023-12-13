using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_9dec
{
    public class Animal
    {
        public string Name { get; set; }
        public int age { get; set; }

        public Animal(string Name, int age)
        {
            this.Name = Name;
            this.age = age;


        }
        public void MakeSound()
        {

        }


    }
    class Mammal : Animal
    {
        public string FurColor { get; set; }
        public Mammal(string name, int age, string furColor) : base(name, age)
        {
            this.Name = name;
            this.age = age;
            this.FurColor = furColor;
        }

        public void DisplayMammal()
        {
            Console.WriteLine("name : " + Name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("Fur Color : " + FurColor);
        }
    }

    class Reptile : Animal
    {
        public string ScaleType { get; set; }

        public Reptile(string name, int age, string scaleType) : base(name, age)
        {
            this.Name = name;
            this.age = age;
            this.ScaleType = scaleType;
        }

        public void DisplayReptile()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Scale type : " + ScaleType);
        }

    }

    class Bird : Animal
    {
        public string WingSpan { get; set; }

        public Bird(string name, int age, string wingSpan) : base(name, age)
        {
            this.Name = name;
            this.age = age;
            this.WingSpan = wingSpan;
        }

        public void DisplayBird()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("wingSpan : " + WingSpan);
        }
    }
    class Lion : Mammal
    {
        public Lion(string Name,int age, string FurColor) :
        {
            Console.WriteLine("Mammal : ");
        }
    }

    class Snake : Reptile
    {
        public Snake(string name,int age,string scaleType) :base (name,age)
        {
            Console.WriteLine("Raptile : " );
        }
        
    }

    class Sparrow : Bird
    {
        public Bird(string Name,int age,string wingSpan) : base(name,age)
        {
            Console.WriteLine("Bird : ");
        } 
    }


   
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.ReadKey();
        }
    }
}
