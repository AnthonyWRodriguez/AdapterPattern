using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class Local
    {
        List<LocalAuthor> authors;

        public Local()
        {
            authors = new List<LocalAuthor>();
        }

        public void InsertAuthor(Guid id, string firstName, string lastName, string nationality)
        {
            var author = new LocalAuthor{ Id = id, FirstName = firstName, LastName = lastName, Nationality = nationality };
            authors.Add(author);
        }

        public string showAuthorNationality(int position)
        {
            if (authors.Count >= position)
                return authors[position-1].FirstName +" "+ authors[position-1].LastName + " is from " + authors[position-1].Nationality;
            else
                return "That position is not available";
        }
    }
    public class LocalAuthor
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
    }
}
