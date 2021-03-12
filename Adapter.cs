using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class Adapter: IAuthor
    {
        External client;

        public Adapter(External c)
        {
            client = c ;
        }

        public void InsertAuthor(Guid id, string firstName, string lastName, string nationality)
        {
            Author auth = new Author { Id = id, FullName = firstName + " " + lastName, Nationality = nationality };
            client.NewAuthor(auth);
        }

        public string showAuthorNationality(int number)
        {
            Author auth = client.ReturnAuthor(number);
            if (auth != null)
                return auth.FullName + " is from " + auth.Nationality;
            else
                return "That position is not available";
        }

    }
}
