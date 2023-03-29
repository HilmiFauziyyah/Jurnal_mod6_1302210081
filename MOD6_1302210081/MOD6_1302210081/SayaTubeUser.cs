using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD6_1302210081
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List <SayaTubeVideo> uploadVideo;

        public SayaTubeUser(string username)
        {
            this.username = username;
            uploadVideo= new List<SayaTubeVideo>();
        }
        public int GettotalVideoPlayCount()
        {
            int totalVideoPlayCount = 0;
            for (int i = 0; i < uploadVideo.Count; i++)
            {
                totalVideoPlayCount += uploadVideo[i].getPlayCount();

            }
            return totalVideoPlayCount;
        }
        public void addvideo(SayaTubeVideo Video)
        {
            uploadVideo.Add(Video);
        }
        public void PrintAllVideoCount()
        {
            Console.WriteLine("User: " + username);
            for(int i = 0; i < uploadVideo.Count; i++)
            {
                Console.WriteLine("Vidio "+i+" Judul: " + uploadVideo[i].gettitle());
            }
        }
    }

}
