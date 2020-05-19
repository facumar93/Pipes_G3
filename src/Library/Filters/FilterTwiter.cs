using System;
namespace CompAndDel.Filters
{
   public class FilterTwitter : IFilter
    {
        
        
        public IPicture Filter (IPicture image)
        {
            var twitter = new TwitterImage(ConsumerKey, ConsumerKeySecret, AccessToken, AccessTokenSecret);
            System.Console.WriteLine(twitter.PublishToTwitter("new filter added",$"../imageWithFilter{contador}.JPG"));
            return image;
            
        }

        public Boolean result { get; set; }
        private int contador = 1;
        public string ConsumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
        public string ConsumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
        public string AccessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
        public string AccessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
    }
}
