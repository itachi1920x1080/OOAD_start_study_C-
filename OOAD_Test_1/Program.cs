namespace OOAD_Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Computer c1 = new Computer("HP ", "HP-1");
            //Computer c2 = new Computer("Dell", "HP-1");
            //Computer c3 = new Computer("Ausu ", "HP-1");
            //Computer[] computers = new Computer[] { c1, c2, c3 };

            Computer[] computers = { new Computer("HP ", "HP-1"),};
            foreach(Computer computer in computers)
            {
                computer.ShowInfo();
                computer.Beep();
            }
        }

        class Computer
        {
            private string? brand;
            private string? model;
            public Computer (string brand , string  model)
            {
                this.brand = brand;
                this.model = model;
            }
            public string Brand
            {
                get { return this.brand;}
                set { this.brand = value; }
            }
            public string Model            {
                get { return this.model; }
                set { this.model = value; }
            }



            public void Beep()
            {
                Console.WriteLine("Beep!");
            }
            public void ShowInfo()
            {
                Console.WriteLine($"Brean : {brand}  |  Mdel : {model}");
            }

        }
    }
}


