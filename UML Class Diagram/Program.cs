namespace UML_Class_Diagram
{
    internal class Program
    {
        class Book
        {
            private string title;
            private double price;
            public Book(string title, double price)
            {
                this.title = title;
                this.price = price;
            }
            public string GetDetails()
            {
                return $"Title: {title}, Price: {price}";
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Book st = new Book("The Great Gatsby", 12.99);
            Console.WriteLine(st.GetDetails());
        }
    }
}
