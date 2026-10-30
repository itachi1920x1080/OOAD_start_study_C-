namespace Virtual_Methods__Method_Overriding_និង_Polymorphism
{
    public class Employee
    {
        // 1. បន្ថែម Keyword មួយនៅមុខ void ដើម្បីឱ្យកូន Override បាន
        public virtual void CalculateBonus()
        {
            Console.WriteLine("Standard Bonus: $200");
        }
    }

    public class Manager : Employee
    {
        // 2. សរសេរ Override Method CalculateBonus() នៅទីនេះ
        public override void CalculateBonus()
        {
            Console.WriteLine("Manager Bonus : $500");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Employee em1 = new Employee();
            em1.CalculateBonus();
            Manager em2 = new Manager();
            em2.CalculateBonus();
        }
    }
}
