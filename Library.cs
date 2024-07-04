using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LMS
{
    public class Library
    {
        public List<Book> books;
        public List<User> users;
        public const string bookspath = "inventory.txt";
        public const string userspath = "users.txt";

        public Library()
        {
            books = new List<Book>();
            users = new List<User>();
        }
   
        public static void Add(Book newBook )
        {
            // this.add_books.Click += new System.EventHandler(Library.AddBook(Book books));
            string docPath =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = File.AppendText(Path.Combine(docPath, bookspath)))
            {
                sw.WriteLine(JsonSerializer.Serialize(newBook));
            }
            MessageBox.Show("Book added successfully");
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
       /* public Book SearchItem(string isbn)
        {

            foreach (Book book in books)
            {
                if (book.ISBN == isbn)
                {
                    return book;
                }

            }
        }
       */
        
        public List<Book> GetAvailableBooks()
        {
            return books.Where(books => books.IsAvailable).ToList();
        }
        public List <Book> GetBooksByISBN(string isbn)
        {
            return books.Where(books => books.ISBN == isbn).ToList();   
        }
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
       /* public List<Book> GetAvailableUsers()
        {
            return users;
        }*/
       /* public void LoadUsers(string userspath)
        {
            var lines = File.ReadAllLines(userspath);
            foreach (var line in lines)
            {
                var parts = line.Split(' ');
                var userID = parts[0];
                var userName = parts[1];
                var borrowedBooks = parts.Skip(2).ToList();

                var user = new User(userID, userName);
                foreach (var isbn in borrowedBooks)
                {
                    var book = GetBooksByISBN(isbn);
                    if (book != null)
                    {
                        user.BorrowBook( books);
                        books.IsAvailable = false;
                    }
                }
                users.Add(user);
            }
       */
        }
    }


