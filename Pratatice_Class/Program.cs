namespace Pratatice_Class
{
    internal class Program
    {
        public class Book
        {
            public string Title { get; set; }
            public int Price { get; set; }


            public Book(string  t ,int p)
            {
                Title = t;
                Price = p;
            }
            public void ShowBook()
            {
                Console.WriteLine($"Title: {Title}, Price: {Price}");
            }

        }
        static void Main(string[] args)
        {
            Book book1 =new Book("The Great Gatsby", 10);
            Book book2 = new Book("To Kill a Mockingbird", 12);
            book1.ShowBook();
            book2.ShowBook();
        }
    }
}
