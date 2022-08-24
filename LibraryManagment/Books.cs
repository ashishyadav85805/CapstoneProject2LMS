using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Books:Newspaper
    {
        public void Booksportal()
        {
            Console.WriteLine();
            Console.WriteLine("    ***********************************************");
            Console.WriteLine("         1 for Adding                            ");
            Console.WriteLine("         2 for Removing                          ");
            Console.WriteLine("         3 for Viewing all the available books   ");
            Console.WriteLine("         4 for Back                              ");
            Console.WriteLine("    ***********************************************");
            Console.WriteLine();

            Addition t = new Addition();

            string input = Console.ReadLine();
            int z = int.Parse(input);

            if (z == 1)
            {
                Console.Write(" >>>>>>  How Many Books You Want to Add Now: ");
                int quantity=Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < quantity; i++) {
                    Console.Write("   *-  Please Enter Book ID: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("   *-  Please Enter Book Name: ");
                    string b = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    t.ADD(new Book{ ID = a, Name = b });
                }
                    

                foreach(Book x in t)
                {
                    Console.WriteLine($"   *-  Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();

                Booksportal();

            }
            else if(z == 2)
            {
                Console.Write("   *-  Type Book code to Remove: ");
                int i = Convert.ToInt32(Console.ReadLine());
                t.Rem(i);

                foreach (Book x in t)
                {
                    Console.WriteLine($"   *-  Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();
                Booksportal();
            }
            else if(z==3)
            {
                foreach (Book x in t)
                {
                    Console.WriteLine($"   *-  Book ID-{x.ID}  Book Name-{x.Name}");
                }
                Console.WriteLine();
                Booksportal();
            }
            else
            {
                Console.WriteLine("   <<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("       Enter  1 for Books               ");
                Console.WriteLine("       Enter  2 for Newspaper           ");
                Console.WriteLine("       Enter  3 to end this session     ");
                Console.WriteLine("   <<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y == 1)
                {
                    Booksportal();
                }
                else if (y == 2)
                {
                    news();
                }
                else if(y == 3)
                {

                }
                else
                {
                    Console.WriteLine("   *-  Invalid Input");

                }
            }
        }

    }
}
