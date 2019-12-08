using System.Collections.Generic;

namespace Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Name = "Cin Ali", Price = 5m},
                new Book() {Name = "Cin Ali", Price = 7m},
                new Book() {Name = "Ucuz Roman", Price = 10m},
                new Book() {Name = "Ağır Roman", Price = 70m},
                new Book() {Name = "Bebek Kitapları", Price = 100m},
                new Book() {Name = "Bebek Kitapları", Price = 130m}
            };

        }
    }
}
