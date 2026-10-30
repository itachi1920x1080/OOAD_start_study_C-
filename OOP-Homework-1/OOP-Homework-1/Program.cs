using System;
using System.Collections.Generic;

namespace OOP_Homework_1
{
    // 1. បង្កើត Interface សម្រាប់កំណត់ស្តង់ដារ
    interface IAnimal
    {
        void DisplayInfo();
    }

    // 2. Base Class (ថ្នាក់មេ) ដែលយក Interface មក implement
    class Animal : IAnimal
    {
        public string Name { get; set; } // Property សម្រាប់ឈ្មោះសត្វ

        // Constructor សម្រាប់កំណត់ឈ្មោះពេលបង្កើត Object
        public Animal(string name)
        {
            Name = name;
        }

        // អនុវត្ត Method ពី Interface IAnimal
        public void DisplayInfo()
        {
            Console.WriteLine($"\n[Animal Info] Name: {Name}");
        }

        // Virtual Method (អនុញ្ញាតឱ្យថ្នាក់កូនកែប្រែបាន)
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a generic sound.");
        }
    }

    // 3. Child Class (Dog) ទទួលមរតកពី Animal (Inheritance)
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        // Method Overriding
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Dog) barks: Woof! Woof!");
        }
    }

    // 4. Child Class (Cat) ទទួលមរតកពី Animal
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        // Method Overriding
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Cat) meows: Meow! Meow!");
        }
    }

    // 5. Child Class (Bird) ទទួលមរតកពី Animal
    class Bird : Animal
    {
        public Bird(string name) : base(name) { }

        // Method Overriding
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} (Bird) chirps: Tweet! Tweet!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Animal Management System ===");

            // 6. Polymorphism នៅក្នុងការអនុវត្តជាក់ស្តែង!
            // បង្កើត List ប្រភេទ Animal តែយើងអាចដាក់ Dog, Cat, Bird ចូលបានទាំងអស់
            List<Animal> zoo = new List<Animal>();

            // បង្កើតសត្វ (Create animals)
            zoo.Add(new Dog("Kiki"));
            zoo.Add(new Cat("Mimi"));
            zoo.Add(new Bird("Piki"));

            // ប្រើ foreach loop ដើម្បីបញ្ជាសត្វទាំងអស់ម្តងមួយៗ
            foreach (Animal animal in zoo)
            {
                animal.DisplayInfo(); // ហៅ Method របស់ Interface / Base Class
                animal.MakeSound();   // ហៅ Virtual/Override Method
            }

            Console.WriteLine("\n=================================");
        }
    }
}