using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.AdpterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audio = new AudioPlayer();
            audio.Play("mp4");
            audio.Play("mp3");
            audio.Play("mp4");
            audio.Play("vic");
            Console.ReadLine();
        }
    }
}
