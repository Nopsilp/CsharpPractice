using Obj2HomeWorkLibrarySystem;
using System;

namespace Obj2HomeWorkLibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BookInformation> books = new List<BookInformation>();

            Console.WriteLine("Enter book information:");

            string? isbn, title, author;
            int totalCopies;

            do
            {
                Console.Write("ISBN: ");
                isbn = Console.ReadLine();
            } while (string.IsNullOrEmpty(isbn));

            do
            {
                Console.Write("Title: ");
                title = Console.ReadLine();
            } while (string.IsNullOrEmpty(title));

            do
            {
                Console.Write("Author: ");
                author = Console.ReadLine();
            } while (string.IsNullOrEmpty(author));

            do
            {
                Console.Write("Total copies: ");
            } while (!int.TryParse(Console.ReadLine(), out totalCopies) || totalCopies <= 0);

            BookCopy bookCopy = new BookCopy(totalCopies);

            BookInformation book = new BookInformation(isbn, title, author, totalCopies)
            {
                BookObject = bookCopy
            };

            books.Add(book);

            while (true)
            {
                Console.WriteLine("Do you want to enter another book? (y/n)");
                string? input = Console.ReadLine()?.ToLower();

                if (input == "n" || (string.IsNullOrEmpty(input)) )
                {
                    break;
                }

                do
                {
                    Console.Write("ISBN: ");
                    isbn = Console.ReadLine();
                } while (string.IsNullOrEmpty(isbn));

                do
                {
                    Console.Write("Title: ");
                    title = Console.ReadLine();
                } while (string.IsNullOrEmpty(title));

                do
                {
                    Console.Write("Author: ");
                    author = Console.ReadLine();
                } while (string.IsNullOrEmpty(author));

                do
                {
                    Console.Write("Total copies: ");
                } while (!int.TryParse(Console.ReadLine(), out totalCopies) || totalCopies <= 0);

                bookCopy = new BookCopy(totalCopies);

                book = new BookInformation(isbn, title, author, totalCopies)
                {
                    BookObject = bookCopy
                };

                books.Add(book);
            }

            Console.WriteLine("Book information:");

            foreach (BookInformation eachBook in books)
            {
                Console.WriteLine($"ISBN: {eachBook.IsbnOfBook}");
                Console.WriteLine($"Title: {eachBook.TitleOfBook}");
                Console.WriteLine($"Author: {eachBook.AuthorOfBook}");
                Console.WriteLine($"Total copies: {eachBook.BookObject.TotalCopyAmount}");

                foreach (int copyID in eachBook.BookObject.CopyID)
                {
                    Console.WriteLine($"Copy ID: {copyID}");
                }
            }
        }

    }
}
