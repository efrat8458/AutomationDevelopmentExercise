using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : Member
    {
        public Librarian(int id, string name, Library library) : base(id, name, library)
        {
        }

        public bool DeleteBook(int id)
        {
            try
            {
                library.RemoveBook(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool AddBook(int id, string name, string author)
        {
            Book newBook = new Book(id, name, author);

            try
            {
                library.AddBook(newBook);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
