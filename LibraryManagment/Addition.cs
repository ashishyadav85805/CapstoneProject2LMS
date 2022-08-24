using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagment
{
    internal class Addition:IEnumerable
    {
        public static List<Book> books = new List<Book>
        {
            new Book{ID=1,Name="The Dark"},
            new Book{ID=2,Name="The Gandhi"},
            new Book{ID=3,Name="Lord of the Rings"},
            new Book{ID=4,Name="The Hobbit" },
            new Book{ID=5,Name="Gone with the Wind" },
            new Book{ID=6,Name="Life of Pi" },
            new Book{ID=7,Name="The Hunger Games" },
            new Book{ID=8,Name="The Chronicles of NARNIA" },
            new Book{ID=9,Name="Divergent" },
            new Book{ID=10,Name="City of Glass"}
        };

        public void ADD(Book NewBook)
        {
            if (books == null)
            {
                books = new List<Book>();
              
            }
            books.Add(NewBook);
        }

        public void Rem(int i)
        {
            if (books != null)
            {
                books.RemoveAll(r => r.ID == i);
                
            }
            
        }

        
        public IEnumerator GetEnumerator()
        {
            if (books != null)
            {
                return books.GetEnumerator();
            }
            else
            {
                return null;
            }

        }

    }

   

    public class Book
    {
        public Boolean Borrowed
        { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }

        
    }
}
