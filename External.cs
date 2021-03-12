using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    class External
    {
        List<Author> authors;

        public External()
        {
            authors = new List<Author>();
        }

        public void NewAuthor(Author author)
        {
            authors.Add(author);
        }

        public Author ReturnAuthor(int position)
        {
            if (authors.Count >= position)
                return authors[position - 1];
            else
                return null;
        }
    }

    public class Author
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
    }
}
