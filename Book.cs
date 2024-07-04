using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LMS
{
 
    public class Book
    {
        //declaring attributes 
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; }
        public string Action
        {
            get => IsAvailable ? "Borrow": "Return";
        }

        // constructor 
        public Book(string title, string author, string isbn, bool isAvailable=true)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsAvailable = isAvailable;
        }

        public void BorrowBook(Book book)
        {
            if(!book.IsAvailable)
            {
                MessageBox.Show("Book is not available to borrow");
                return;
            }


            book.IsAvailable = false;
            MessageBox.Show("Book Borrowed Successfully");
        }

        public void ReturnBook(Book book)
        {
            if(book.IsAvailable)
            {
                MessageBox.Show("Book is not Borrowed to Return");
                return;
            }
            book.IsAvailable=true;
            MessageBox.Show("Book Returned Successfully");
        }

    }
}
