namespace Test_bog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Dog Data = new Dog("Testbog ", "PP");
            
            Data.Info();


        }
        public class Dog
        {
            //filed
            private string name;
            private string breed;
            public Dog()
            {

            }

            //constructor 
            public Dog (string name , string breed){
                this.name = name;
                this.breed = breed;
            }
            //property

            public string Name
            {
                get {  return name; }
                set { this.name = value; }
            }
            public string Breed
            {
                get{ return breed; }
                set {  breed = value; }
            }
            public void Info() 
            {
                Console.WriteLine($"Name :{name}|Breed :{breed}");
            } 

        }

    }
}
