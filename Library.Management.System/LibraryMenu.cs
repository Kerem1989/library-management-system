namespace Library.Management.System ;

    public class LibraryMenu
    {
        public void RunMenu()
        {
            bool running = true;
            List<Book> books = new List<Book>();
            List<Book> borrowedBooks = new List<Book>();
            BookService bookService = new BookService();

            Console.WriteLine("Welcome to the Library Management System");
            Console.WriteLine("");
            while (running)
            {
                Console.WriteLine("Please select an option regarding books by typing in the action:");
                Console.WriteLine("Add");
                Console.WriteLine("Remove");
                Console.WriteLine("Search");
                Console.WriteLine("Display");
                Console.WriteLine("Borrow");
                Console.WriteLine("Return");
                Console.WriteLine("Exit");
                string choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add":
                        bookService.AddBook(books);
                        break;
                    case "remove":
                        bookService.RemoveBook(books);
                        break;
                    case "search":
                        bookService.SearchBook(books);
                        break;
                    case "display":
                        bookService.DisplayBooks(books);
                        break;
                    case "borrow":
                        if (bookService.BorrowedCapacityReached())
                        {
                            Console.WriteLine("Borrowed capacity reached, no more books can be borrowed");
                            break;
                        }
                        bookService.BorrowBook(books, borrowedBooks);
                        break;
                    case "return":
                        bookService.ReturnAllBooks(books, borrowedBooks);
                        break;
                    case "exit":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }