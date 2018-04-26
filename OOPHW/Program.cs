using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPHW
{
     class Animal
    {
        public Animal()
        {

        }
        public virtual void Move()
        {
            Console.WriteLine("I move");
        }
    }
    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I run");

        }
        public string Name { get; set; }
        public Dog(string name)
        {
            this.Name = name;
        }
    }
    class Fish : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I swim");
        }
        public string Name { get; set; }
        public Fish(string name)
        {
            this.Name = name;
        }
    }
    class Bird : Animal
    {
        public override void Move()
        {
            Console.WriteLine("I fly");
        }
        public string Name { get; set; }
        public Bird(string name)
        {
            this.Name = name;
        }
    }
    class Sheepdog : Dog
    {
        public string Species{ get; set; }
        public Sheepdog(string name, string species) : base(name)
        {
            Species = species;
        }

        public override void Move()
        {
            Console.WriteLine("I run like a Sheepdog");
        }
    }
    class ClownFish : Fish
    {
        public string Species { get; set; }
        public ClownFish(string name, string species) : base(name)
        {
            Species = species;
        }

        public override void Move()
        {
            Console.WriteLine("I swim like a ClownFish");
        }
    }
    class Parrot : Bird
    {
        public string Species { get; set; }
        public Parrot(string name, string species) : base(name)
        {
            Species = species;
        }

        public override void Move()
        {
            Console.WriteLine("I fly like a Parrot");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            animal.Move();
            var dog = new Dog ("Bars");
            dog.Move();
            var fish = new Fish("Nemo");
            fish.Move();
            var bird = new Bird("Sparrow");
            bird.Move();
            var sheepdog = new Sheepdog("Rex", "Sheepdog");
            sheepdog.Move();
            var clownfish = new ClownFish("Nemo's Father", "Clown Fish");
            clownfish.Move();
            var parrot = new Parrot("Bly", "Parrot");
            parrot.Move();
            Console.WriteLine(dog.Name + " " + fish.Name + " " + bird.Name);
            Console.WriteLine(sheepdog.Name + " " + sheepdog.Species);
            Console.WriteLine(clownfish.Name + " " + clownfish.Species);
            Console.WriteLine(parrot.Name+" " + parrot.Species);

        }
    }
}
