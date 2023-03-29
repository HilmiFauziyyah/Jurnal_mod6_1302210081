using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD6_1302210081
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int Playcount;


        public SayaTubeVideo(string title)
        {
            this.title = title;
            var a = this.title.Substring(this.title.Length);
            Contract.Requires(this.title !=null);

            string number = "";

            Random rnd = new Random();

            this.id = rnd.Next(1,999);

            number += id.ToString("D5");

            this.Playcount = 0;
        }
        public void IncreasePlayCount(int Playcount)
        {
            this.Playcount++;
        }
        public int getPlayCount()
        {
            return Playcount;
        }
        public void PrintVideoDetail( )
        {
            Console.WriteLine("ID : " + id);

            Console.WriteLine("Title : " + title);

            Console.WriteLine("PlayCount : " + Playcount);

        }

        public string gettitle()
        {
            return title;
        }
    }
}
