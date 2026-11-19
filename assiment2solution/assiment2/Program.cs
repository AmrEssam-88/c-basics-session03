namespace assiment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //السؤال الاول
            Console.WriteLine("------------Question 1------");

            int pages = 464;
            if(pages > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            //السؤال الثاني
            Console.WriteLine("------------Question 2------");

            int pagess = 464;
            bool isAvailable = true;

            if (pagess > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }

            //السؤال التالت
            Console.WriteLine("------------Question 3------");

            string title = "Refactoring";

            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            //السؤال الرابع 
            Console.WriteLine("------------Question 4------");

            int page = 464;
            string sizeLabel = (page > 300) ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            //السؤال الخامس
            Console.WriteLine("------------Question 5------");

            string[] books = { "Clean Code","The Pragmatic Programmer","Refactoring" };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }

            //السؤال السادس 
            Console.WriteLine("------------Question 6------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            int x = 0;

            while (x < books.Length)
            {
                Console.WriteLine(books[x]);
                x++;
            }

            //السؤال السابع
            Console.WriteLine("---------Question 7-----");

            int c = 0;

            do
            {
                Console.WriteLine("Checking book...");
                c++;
            } while (c < 3);

            //السؤال الثامن
            Console.WriteLine("------------Question 8-------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            //السؤال التاسع
            Console.WriteLine("------------Question 9------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);

                if (book == "Refactoring")
                {
                    break;
                }
            }
            //السؤال العاشر
            Console.WriteLine("------------Question 10------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

            //السؤال ال11
            Console.WriteLine("------------Question 11------");

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            PrintFirstBook();
            void PrintFirstBook()

            {
                if (books == null || books.Length == 0)
                {
                    return;
                }

                Console.WriteLine(books[0]);
            }

        }
    }
}

