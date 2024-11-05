using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{

    internal abstract class User
    {
        
        public int Id { get; }
        public string Name { get; }

        public User(int id, string name) 
        { 
            this.Id = id;
            this.Name = name;
        }

        public void displayInfo()
        {
            Console.WriteLine($"User:\nMembers:\nId = {Id}\nName = {Name}\n");
        }

    }
}
