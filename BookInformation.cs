using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Obj2HomeWorkLibrarySystem
{
    public class BookInformation
    {
        private string _isbnOfBook;
        public string TitleOfBook { get; set; }
        public string AuthorOfBook { get; set; }
        public BookCopy BookObject { get; set; }

       
        public string IsbnOfBook
        {
            get
            {
                return _isbnOfBook;
            }

            set
            {
                if (value != null && value.ToString().Length == 10)
                {
                    _isbnOfBook = value;
                }
                else
                {
                    throw new ArgumentException("Invalid ISBN. Please put ISBN");
                }
            }
        }


        public BookInformation(string isbn = "", string title = "", string author = "", int totalCopyAmount = 0)
        {
            _isbnOfBook = isbn;
            TitleOfBook = title;
            AuthorOfBook = author;
            BookObject = new BookCopy(totalCopyAmount)
            {
                TotalCopyAmount = totalCopyAmount,
                
            };
        }

    }
}

/* The BookInformation class has the following properties:

_isbnOfBook: a private string field that stores the ISBN number of the book.
TitleOfBook: a public string property that gets or sets the title of the book.
AuthorOfBook: a public string property that gets or sets the author of the book.
Copies: a public List of BookCopy objects property that gets or sets the list of copies of the book.

By putting the Copies property in the BookInformation class, we can easily keep track of all the copies 
of a specific book without having to create a new instance of BookInformation for each individual copy. 
This allows us to better organize and manage our data in the library system.


The BookInformation class also has a constructor that takes four arguments:
isbn: a string that represents the ISBN of the book.
title: a string that represents the title of the book.
author: a string that represents the author of the book.
copies: a List of BookCopy objects that represents the list of copies of the book.

The BookInformation class has a property called IsbnOfBook that has a getter and a setter. 
The getter returns the private field _isbnOfBook, and 
the setter sets the value of _isbnOfBook if the value is not null and has a length of 10, 
otherwise it throws an ArgumentException.

The BookCopy class represents a single copy of a book and has two properties:

CopyID: a string property that identifies the specific copy.
TotalCopyAmount: a string property that stores the total number of copies. However, this property is not being used in the code and can be removed if not needed. The BookCopy class also has a constructor that takes two arguments:
copyID: a string that represents the ID of the copy.
totalCopyAmount: a string that represents the total number of copies.

*/

