namespace Phonebook
{
    internal class ContactList : Dictionary<string, Contact>
    {
        public void AddContact(Contact contact)
        {
            if (ContainsKey(contact.Key))
                throw new Exception("Contatto già presente");

            Add(contact.Key, contact);
        }

        public void RemoveContact(string key)
        {
            if (!ContainsKey(key))
                throw new Exception("Contatto non trovato");

            Remove(key);
        }

        public Dictionary<string, Contact> Search(string name, string surname, string telephone)
        {
            return this.Where(x =>
                (string.IsNullOrEmpty(name) || string.Equals(name, x.Value.Name, StringComparison.InvariantCultureIgnoreCase)) &&
                (string.IsNullOrEmpty(surname) || string.Equals(surname, x.Value.Surname, StringComparison.InvariantCultureIgnoreCase)) &&
                (string.IsNullOrEmpty(telephone) || string.Equals(telephone, x.Value.Telephone, StringComparison.InvariantCultureIgnoreCase)))
                .ToDictionary();
        }

    }
}
