using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Librarian
    {
        public void LibrarianPortal()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------What do you want to manage today?------");
            Console.WriteLine();
            
            Console.WriteLine("   |<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>|");
            Console.WriteLine("       Enter  1 for Books              ");
            Console.WriteLine("       Enter  2 for Newspaper          ");
            Console.WriteLine("       Enter  3 to end this session    ");
            Console.WriteLine("   |<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>|");

            Librarian l = new Librarian();

            string LibrarianChoice= Console.ReadLine();
            int y= int.Parse(LibrarianChoice);

            Books b = new Books();
            Newspaper p = new Newspaper();

            if (y == 1)
            {
                b.Booksportal();
            }
            else if(y == 2)
            {
                p.news();

            }
            
        }
    }
}
