using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            #region Sample1

            ////Linq Query Operators
            //var queryLinqBooks = from b in books
            //                     where b.Price <= 70
            //                     orderby b.Name
            //                     select b.Name;



            //// Linq Extension Methods
            //var linqBooks = books
            //    .Where(b => b.Price <= 70)
            //    .OrderBy(b => b.Name)
            //    .Select(b => b.Name);


            //foreach (var book in linqBooks)
            //{
            //    //Console.WriteLine(book.Name + book.Price);
            //    Console.WriteLine(book);
            //} 

            #endregion

            #region Sample2

            //var book = books.SingleOrDefault(b => b.Name == "Cin Ali"); 
            //var book = books.FirstOrDefault(b => b.Name == "Cin Ali");
            //var book = books.LastOrDefault(b => b.Name == "Cin Ali");

            //Console.WriteLine(book.Name+" Price:"+book.Price); 

            #endregion

            #region Sample3

            ////Pagination
            //var pagedBooks = books.Skip(2).Take(3);

            //foreach (var pagedBook in pagedBooks)
            //{
            //    Console.WriteLine(pagedBook.Name);
            //} 

            #endregion

            #region Sample4

            //var count = books.Count();
            //Console.WriteLine(count); 

            #endregion

            #region Sample5

            //var max = books.Max(b => b.Price);
            //Console.WriteLine(max);
            //var min = books.Min(b => b.Price);
            //Console.WriteLine(min); 

            #endregion

            #region Sample6

            //var total = books.Sum(b => b.Price);
            //Console.WriteLine(total); 

            #endregion
            
        }
    }
}
