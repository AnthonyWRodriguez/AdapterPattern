using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    public interface IAuthor
    {
        void InsertAuthor(Guid id, string firstName, string lastName, string nationlaity);
        string showAuthorNationality(int number);
    }
}
