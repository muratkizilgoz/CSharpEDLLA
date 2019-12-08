using System.Collections.Generic;
using System.Linq;

namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int numberOfWord)
        {
            if(numberOfWord<=0)
                throw new ArgumentOutOfRangeException("numberOfWord > 0 ");

            var words = str.Split(' ');

            if (words.Length <= numberOfWord)
                return str;
            return string.Join(' ', words.Take(numberOfWord)) + "...";
        }
    }
}