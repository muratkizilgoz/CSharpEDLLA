using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Name = "Cin Ali", Price = 5m},
                new Book() {Name = "Ucuz Roman", Price = 10m},
                new Book() {Name = "Ağır Roman", Price = 70m},
                new Book() {Name = "Bebek Kitapları", Price = 100m}
            };

        }
    }
}
