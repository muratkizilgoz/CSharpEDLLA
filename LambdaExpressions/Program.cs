using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //args => expression
            //()=>...
            // x => ...
            //(x, y, z)=>...

            #region 1
            //Func<int, int> kareFunc = number => number * number;
            //Console.WriteLine(kareFunc(2));
            #endregion

            #region 2
            const int factor = 14;
            Func<int, int> carpan = n => n * factor;

            var sonuc = carpan(10);
            Console.WriteLine(sonuc);
            #endregion

            var books = new BookRepository().GetBooks();
            var lambdaBooks = books.FindAll(b => b.Price < 50);

            foreach (var book in lambdaBooks)
            {
                Console.WriteLine(book.Name);
            }


        }

    }
}
