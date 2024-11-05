using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Member : User
    {
        private List<int> booksIds;
        private int numOfBooks = 0;
        internal Library library;
        public Member(int id, string name, Library library) : base(id, name)
        {
            booksIds = new List<int>();
            this.library = library;
        }

        public bool BorrowBook(int newBookId)
        {
            if (numOfBooks <= 3)
            {
                try
                {
                    library.BorrowBook(newBookId);
                    booksIds.Add(newBookId);
                    numOfBooks++;
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            Console.WriteLine("It is not possible to borrow more than 3 books.");
            return false;
        }

        public bool ReturnBook(int oldBookId) 
        {
            if (booksIds.Contains(oldBookId))
            {
                try
                {
                    booksIds.Remove(oldBookId);
                    library.ReturnBook(oldBookId);
                    numOfBooks--;
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            Console.WriteLine("The book you are trying to return is not in your books list.");
            return false;
        }
    }
}
