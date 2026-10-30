namespace Inheritance___Polymorphism
{
    public class Animal
    {
        public string Name { get; set; }
        
    }
    public class Dog : Animal
    {
        public Dog(string n) {
            this.Name = n;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
        public void Bark(int time) 
        {
            Console.WriteLine($"Woof ! Barked {time} times."); 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Buddy");
            dog1.Bark();
            dog1.Bark(5);
        }
    }
}
