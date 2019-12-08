using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1
            ////Nullable<DateTime> date = null;
            //DateTime? date = null;

            //Console.WriteLine(date.GetValueOrDefault());
            //Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value); 
            #endregion

            #region Sample2
            //DateTime? date = new DateTime(1999, 1, 1);
            ////DateTime date1 = date; // convert hatası
            //DateTime date1 = date.GetValueOrDefault();
            //Console.WriteLine(date1);

            //DateTime? date2 = date1;
            #endregion

            #region Sample3
            DateTime? date = null;

            //The null-coalescing operator ?? 
            DateTime date1 = date ?? DateTime.Now;

            //The conditional operator ?:, also known as the ternary conditional operator,
            DateTime date2 = date == null ? DateTime.Now : date.GetValueOrDefault(); 
            #endregion
        }
    }
}
