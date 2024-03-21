using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Tools()
    {
        public static void InsertContact(string name, string surname, string telephone, ContactList book)
        {
            var c = new Contact(name, surname, telephone);
            book.AddContact(c);
        }

        public static Dictionary<string, Contact> SearchContact(string name, string surname, string telephone, ContactList book)
        {
            return book.Search(name, surname, telephone);
        }
        
        public static void RemoveContact(Dictionary<string, Contact> contactsToDelete, ContactList book)
        {
            foreach (var c in contactsToDelete)
                book.Remove(c.Key);
        }

        public static void ViewContacts(Dictionary<string, Contact> book, ListView lv)
        {
            lv.Items.Clear();

            foreach (var c in book)
                lv.Items.Add(c.Value.ToString());
        }

    }
}
