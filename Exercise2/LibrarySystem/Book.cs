using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        private bool Availability { get; set; }

        public Book(int id, string name, string author) 
        {
            this.Id = id;
            this.Name = name;
            this.Author = author;
            this.Availability = true;
        }

        public void BorrowBook()
        {
            if (!Availability)
            {
                throw new Exception("The book is not available to borrow");
            }
            this.Availability = false;
        }

        public void ReturnBook()
        {
            if (Availability)
            {
                throw new Exception("A book is not marked as borrowed.");
            }
            this.Availability = true;
        }

        public void displayInfo()
        {
            Console.WriteLine($"Book:\nMembers:\nId = {this.Id}\nName = {Name}\nAuthor = {Author}\nAvailability = {Availability}");
        }
    }
}
