using System;

namespace Dynamic
{
    class Program
    {
        // Statically typed Lang: c#, java => at compile time => early feedback => .net4 added dynamic capability
        // Dynamically typed lang : Python, Ruby, Javascript => at run time => easier and faster to code but need more unit test  
        // Reflection is a way to inspect the metadata about the type, and access prop and method.
        static void Main(string[] args)
        {
            #region Reflection
            //object obj = "Snow";

            //var methdInfo = obj.GetType().GetMethod("GetHashCode");
            //methdInfo.Invoke(null, null); 
            #endregion

            dynamic obj1 = "John";
            //obj1.OlmayanBirMethod(); // No error compile


            dynamic name = "John";
            name = 10;
            Console.WriteLine(name);

            dynamic a = 12;
            dynamic b = 33;
            var c = a + b;

            a = obj1;
            a++;


        }
    }
}
