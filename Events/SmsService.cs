using System;

namespace Events
{
    public class SmsService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine($"Sms : {args.Video.Name}");
        }
    }
}