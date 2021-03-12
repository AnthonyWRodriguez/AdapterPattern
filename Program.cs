using System;

namespace Adapter_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            IAuthor external = new Adapter(new External());
            var local = new Local();
            while (number < 4 && number > 0)
            {
                Console.Clear();
                Console.WriteLine("Please choose your action:");
                Console.WriteLine("1. Add a new Author");
                Console.WriteLine("2. Show information about an author");
                Console.WriteLine("3. Exit");
                var ans = Console.ReadKey().KeyChar.ToString();
                if (int.TryParse(ans, out int i))
                    number = int.Parse(ans);
                else
                    number = 4;
                if(number < 4)
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("\nAuthor's first name: ");
                            var firstName = Console.ReadLine();
                            Console.WriteLine("Author's lastName name: ");
                            var lastName = Console.ReadLine();
                            Console.WriteLine("Author's nationality: ");
                            var nationality = Console.ReadLine();
                            external.InsertAuthor(new Guid(), firstName, lastName, nationality);
                            local.InsertAuthor(new Guid(), firstName, lastName, nationality);
                            Console.WriteLine("Author has been added");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("\nChoose the author based on the number it was introduced to the system ( starts from 1 )");
                            var num = -1;
                            while(num <= 0)
                            {
                                var a = Console.ReadKey().KeyChar.ToString();
                                if (int.TryParse(a, out int e))
                                    num = int.Parse(a);
                                else
                                    num = -1;
                            }
                            if(num != -1)
                            {
                                Console.WriteLine("\nFrom the external\n" + external.showAuthorNationality(num));
                                Console.WriteLine("\nFrom the local\n" + local.showAuthorNationality(num));
                                Console.ReadKey(true);
                            }
                            break;
                        default:
                            Console.WriteLine("Bye");
                            Console.ReadKey(true);
                            Environment.Exit(0);
                            break;
                    }
                }
            }
        }
    }
}
