using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.AdpterPattern
{
    public class AudioPlayer:MediaPlayer
    {
        MediaAdapter MediaAdapter;
        public void Play(string type)
        {
            //当是这两种情况（播放vic和MP4文件），属于系统一开始的设计的缺陷，属于意外的功能
            //用这种适配器去操作，留意会发现，这种适配器MediaAdapter，和当前这个类AudioPlayer
            //实现了同一个接口
            if (string.Equals(type,"vic")||string.Equals(type,"mp4"))
            {
                this.MediaAdapter = new MediaAdapter(type);
                this.MediaAdapter.Play(type);
            }
            else if (string.Equals(type,"mp3"))//这是系统原来就有的功能（播放mp3文件）
            {
                Console.WriteLine("PlayMp3");
            }
        }
    }
}
