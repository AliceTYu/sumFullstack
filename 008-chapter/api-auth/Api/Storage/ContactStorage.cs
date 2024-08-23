public class ContactStorage
{
    private List<Contact> Contacts { get; set; }

    public ContactStorage()
    {
        Contacts = new List<Contact>();

        for (int i = 1; i < 6; i++)
        {
            Contacts.Add(new Contact()
            {
                Id = i,
                Name = $"Имя {i}",
                PhoneNumber = $"+7 999 99-99-9{i}",
                Email = $"email{i}@ya.ru"
            });
        }
    }

    public List<Contact> GetContacts()
    {
        return Contacts;
    }

    // public Contact GetContactById(int id)
    // {
    //     Contact contact;
    //     for (int i = 0; i < Contacts.Count(); i++)
    //     {
    //         if (Contacts[i].Id == id)
    //         {
    //             contact = Contacts[i];
    //             return contact;
    //         }
    //     }
    //     return null;
    // }

    public bool AddContact(Contact contact)
    {
        foreach (var item in Contacts)
        {
            if (contact.Id == item.Id || contact.PhoneNumber == item.PhoneNumber || contact.Email == item.Email)
            {
                return false;
            }
        }
        Contacts.Add(contact);
        return true;
    }

    public bool DeleteContact(int id)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count(); i++)
        {
            if (Contacts[i].Id == id)
            {
                contact = Contacts[i];
                Contacts.Remove(contact);
                return true;
            }
        }
        return false;
    }

    public bool UpdateContact(ContactDto contactDto, int id)
    {
        Contact contact;
        for (int i = 0; i < Contacts.Count(); i++)
        {
            if (Contacts[i].Id == id)
            {
                contact = Contacts[i];
                if (!String.IsNullOrEmpty(contactDto.Email) & contactDto.Email != "string")
                {
                    contact.Email = contactDto.Email;
                }
                if (!String.IsNullOrEmpty(contactDto.PhoneNumber) & contactDto.PhoneNumber != "string")
                {
                    contact.PhoneNumber = contactDto.PhoneNumber;
                }
                if (!String.IsNullOrEmpty(contactDto.Name) & contactDto.Name != "string")
                {
                    contact.Name = contactDto.Name;
                }
                return true;
            }
        }
        return false;
    }
}