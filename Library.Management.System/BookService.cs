namespace Library.Management.System ;

    public class BookService
    {
        public static int borrowedBooksCount = 0;

        public void AddBook(List<Book> books)
        {
            Console.WriteLine("Enter title of the book");
            string title = Console.ReadLine();
            if (string.IsNullOrEmpty(title))
            {
                Console.WriteLine("Title cannot be empty");
                return;
            }
            bool capacity = CheckCapacity(books);

            if (capacity)
            {
                Console.WriteLine("Capacity is full, no more books can be added");
            }
            else
            {
                Book book = new Book(books.Count() + 1, title);
                books.Add(book);
                Console.WriteLine("Book added successfully");
            }
        }

        public void RemoveBook(List<Book> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books to remove");
            }
            else
            {
                Console.WriteLine("Enter the title of the book to remove");
                string title = Console.ReadLine();
                bool titleExists = DoesTitleExist(books, title);
                if (titleExists)
                {
                    books.RemoveAll(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                    Console.WriteLine("Book removed successfully");
                }
                else
                {
                    Console.WriteLine("Book not found");
                }
            }
        }

        public void DisplayBooks(List<Book> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title} Is Borrowed: {book.IsBorrowed}");
            }
        }

        public void SearchBook(List<Book> books)
        {
            Console.WriteLine("Enter the title of the book to search");
            string title = Console.ReadLine();
            bool titleExists = DoesTitleExist(books, title);
            if (titleExists)
            {
                Console.WriteLine($"Book found with title: {title}");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public void BorrowBook(List<Book> books, List<Book> borrowedBooks)
        {
            Console.WriteLine("Enter the title of the book to borrow");
            string title = Console.ReadLine();
            bool titleExists = DoesTitleExist(books, title);
            if (titleExists)
            {
                borrowedBooks.Add(new Book(borrowedBooksCount + 1, title));
                foreach (var book in books)
                {
                    if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                    {
                        book.IsBorrowed = true;
                    }
                }
                Console.WriteLine("Book borrowed successfully");
                borrowedBooksCount++;
            }
        }


        public void ReturnAllBooks(List<Book> books, List<Book> borrowedBooks)
        {
            foreach (var book in borrowedBooks)
            {
                foreach (var book1 in books)
                {
                    if (book.Title.Equals(book1.Title, StringComparison.OrdinalIgnoreCase))
                    {
                        book1.IsBorrowed = false;
                    }
                }
            }
            borrowedBooks.Clear();
            borrowedBooksCount = 0;
        }

        public bool BorrowedCapacityReached()
        {
            if (borrowedBooksCount == 3)
            {
                return true;
            }
            return false;
        }

        private static bool CheckCapacity(List<Book> books)
        {
            if (books.Count() == 5)
            {
                return true;
            }
            return false;
        }

        private static bool DoesTitleExist(List<Book> books, string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
    }