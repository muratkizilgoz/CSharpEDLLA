using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(1);

            var books = new GenericList<Book>();
            books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("123asd",new Book());

            var number1 = new Nullable<int>();
            Console.WriteLine($"Has value: {number1.HasValue} - Value : {number1.GetValueorDefault()}");
        }
    }
}
