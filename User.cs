using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    public class User
    {
        //declaring the attributes for the user class
        public string UserID { get; set; }
        public string UserName { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        //constructor 
        public User(string userID, string userName)
        {
            UserID = userID;
            UserName = userName;
            BorrowedBooks = new List<Book>();

        }
        //validating the user details
        public void UserValidate(string userID, string userName)
        {
            if (userID == null)
            {
                MessageBox.Show("Invalid user id!!");
            }
            else if (userName == null)
            {
                MessageBox.Show("Invalid user name!!");
            }
            else
            {
                MessageBox.Show("User is valid!!");
            }
        }

        public void BorrowBook( Book book)
        {
            //checking if the book is available 
            if (book.IsAvailable)
            {
                //if it's available then the user can borrow it and the book's availability is set to false
                book.IsAvailable = false;
                //adding books to the borrow list
                BorrowedBooks.Add(book);
                MessageBox.Show("Books borrowed successfully!");
            }
            else
            {
                //throwing exception when its not available
                throw new Exception("Book is not available");
            }
        }

        public void ReturnBook( Book book)
        {
            //if the borrow list contains the book details then the book is removed from the borrow list and the book's availability is set to true
            if(BorrowedBooks.Contains(book))
            {
                book.IsAvailable = true;
                BorrowedBooks.Remove(book);
            }
            else
            {
                //throwing an exception when its not borrowed
                throw new Exception("Book is not borrowed");
            }
        }

    }
}
