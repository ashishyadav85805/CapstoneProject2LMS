using System;

namespace LibraryManagment
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("   <<<<<<< Select Any One:  >>>>>");
            Console.WriteLine("    ---------------------------- ");
            Console.WriteLine("      Press 1 For  Librarian   ");
            Console.WriteLine("      Press 2 For  student      ");
            Console.WriteLine(" ");
            string chosen= Console.ReadLine();
            int x=int.Parse(chosen);

            Librarian l =new Librarian();
            Students s= new Students();

            switch(x)
            {
                case 1:
                    l.LibrarianPortal();
                    break;
                case 2:
                    s.studentPortal();
                    break;
            }
        }
    }

   
}
