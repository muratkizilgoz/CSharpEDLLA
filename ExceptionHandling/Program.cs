using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1
            //try
            //{
            //    var calculator = new Calculator();
            //    var result = calculator.Bolme(1, 0);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Learn math {ex}");
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"errrorrrr: {ex}");
            //} 
            #endregion

            #region Sample2
            ////Dispose
            //StreamReader streamReader = StreamReader.Null;
            //try
            //{
            //    streamReader = new StreamReader(@"c:\win.rar");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //}
            //finally
            //{
            //    streamReader?.Dispose();
            //} 
            #endregion

            #region Sample3
            //try
            //{
            //    //auto dispose
            //    using (var streamReader = new StreamReader(@"c:\win.rar"))
            //    {
            //        var content = streamReader.ReadToEnd();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine("Errorrrrr" + ex);
            //} 
            #endregion

            #region Sample5
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            #endregion

        }
    }
}
