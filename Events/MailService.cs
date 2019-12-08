using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Mail : {args.Video.Name}");
        }
    }
}