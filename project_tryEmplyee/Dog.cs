using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_try
{
    internal class Dog
    {
        public Dog() { }
        public Dog(float width,
            float height,
            string name,
            string food)
        {
            Width = width;
            Height = height;
            Name = name;
            Food = food;
        }

        public void Run() 
        {
            Console.WriteLine($"dog {Name} is running");
        }
        public void Eat() 
        {
            Console.WriteLine($"dog {Name} is eat {Food}");
        }
        public void Play()
        {
            Console.WriteLine($"dog {Name} is play");
        }
        public void Set_food()
        {

        }
        

        public float Width;
        public float Height;
        public string Name;
        public string Food;
    }
}
