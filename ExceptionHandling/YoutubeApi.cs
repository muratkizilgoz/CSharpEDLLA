using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        
        public List<Video> GetVideos()
        {
            try
            {
                throw new Exception("low level youtube error");
            }
            catch (Exception ex)
            {
                throw new YoutubeException("fetch the videos from youtube error",ex);

            }

            return new List<Video>();
        }
    }
}