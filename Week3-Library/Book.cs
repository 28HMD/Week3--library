namespace Week3_Library
{
    class Book
    {
        // Private fields
        private string title;
        private string author;
        private string isbn;

        // Title property
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // Author property
        public string Author
        {
            get { return author; }
            set
            {
                // Checks if any character is a number
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }

        // ISBN property
        public string ISBN
        {
            get { return isbn; }
            set
            {
                // Checks that ISBN is not blank
                if (value != "")
                {
                    isbn = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        // Constructor
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        // Display book information
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}