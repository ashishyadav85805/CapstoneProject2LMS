using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Newspaper:Librarian
    {
        

        public void news()
        {
            Console.WriteLine();
            Console.WriteLine("1 Viewing all the available newspaper");
            Console.WriteLine("2 Add New Newspaper ");
            Console.WriteLine("3 Back");
            Console.WriteLine();

            int x  = Convert.ToInt32(Console.ReadLine());

            newspaperOperation n = new newspaperOperation();

            if(x == 1)
            {
                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.WriteLine();
                news();
            }
            else if (x==2)
            {
                Console.WriteLine("Please Enter Newspaper Title ");
                string b = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                n.add(new Paper { Title =b });

                foreach (Paper y in n)
                {
                    Console.WriteLine($"Title- {y.Title}");
                }
                Console.WriteLine();
                news();

            }

            else if (x == 3)
            {
                LibrarianPortal();
            }
        }
    }
}
