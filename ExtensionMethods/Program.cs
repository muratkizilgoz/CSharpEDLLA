using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Extensions methods bla bla bla bla bla lba";
            var shortedText = text.Shorten(3);
            Console.WriteLine(shortedText);
        }
    }
}
