using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        private List<Book> books;
        
        public Library()
        {
            books = new List<Book>();
        }

        private int GetBookById(int id) 
        {
            for (int i=0; i<books.Count;i++)
            {
                if (books[i].Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
        public void AddBook(Book book)
        {
            if(GetBookById(book.Id) != -1)
            {
                throw new Exception("Book id already exists.");
            }
            books.Add(book);
        }

        public void RemoveBook(int bookId)
        {
            int bookIdx = GetBookById(bookId);
            if (bookIdx != -1)
                books.RemoveAt(bookIdx);
            throw new Exception("Book id is not exists.");
        }

        public void BorrowBook(int newBookId)
        {
            int bookIdx = GetBookById(newBookId);
            if (bookIdx != -1)
            {
                books[bookIdx].BorrowBook();
            }
            else
            {
                throw new Exception("Book is not exists.");
            }

        }

        public void ReturnBook(int oldBookId)
        {
            int bookIdx = GetBookById(oldBookId);
            if (bookIdx != -1)
            {
                books[bookIdx].ReturnBook();
            }
            else
            {
                throw new Exception("Book is not exists.");
            }
        }
    }
}
