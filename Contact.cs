using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Contact
    {
        public string Name { get; init; }
        public string Surname { get; init; }
        public string Telephone { get; init; }
        public string Key { get; init; }

        public Contact(string name, string surname, string telephone)
        {
            Name = name;
            Surname = surname;
            Telephone = telephone;
            Key = $"{Surname}-{Name}";
        }

        public override string ToString() => $"{Name} {Surname} {Telephone}";
    }

}
