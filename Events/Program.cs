namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video()
            {
                Name = "4K Video"
            };

            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var smsService = new SmsService();//subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }

    }
}
