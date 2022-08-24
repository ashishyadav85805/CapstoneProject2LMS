using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Students
    {
        public void studentPortal()

        {
           
            Console.WriteLine();
            Console.WriteLine("------Hello You Have Just Entered In Student Portal-----");
            Console.WriteLine("********************************************************");
            Console.WriteLine("                 Enter 1 to BorrowBook                  ");
            Console.WriteLine("                 Enter 2 to ReturnBook                  ");
            Console.WriteLine("                 Enter  3 to View Available Books        ");
            Console.WriteLine("                 Enter 4 to End The Session            ");
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            int x=Convert.ToInt32(Console.ReadLine());

            Addition t = new Addition();

            StudentBook obj = new StudentBook();

            if (x == 1)
            {
                obj.BorrowOperation();
                studentPortal();
            }
            else if (x == 2)
            {
                obj.ReturnOperation();
                studentPortal();
            }
            else if (x == 3)
            {
                foreach (Book b in t)
                {
                    Console.WriteLine($"   *-  Book ID-{b.ID}  Book Name-{b.Name}");
                }
                studentPortal();

            }
            else if (x == 4)
            {

            }

            
        }
       
    }
}
