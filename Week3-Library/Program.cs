using Week3_Library;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book(
            "C# for beginners",
            "Bill Gates",
            "1234567"
        );

        book.DisplayInfo();

        Book book1 = new Book(
            "Ultimate C#",
            "Microsoft",
            "2233445"
        );

        book1.DisplayInfo();
    }
}