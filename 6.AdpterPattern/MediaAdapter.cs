using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.AdpterPattern
{
    public class MediaAdapter:MediaPlayer
    {
        AdvanceMediaPlayer AdvanceMediaPlayer;
        public MediaAdapter(string type)
        {
            if (string.Equals(type, "vic"))
                this.AdvanceMediaPlayer = new VicPlayer();
            else if (string.Equals(type, "mp4"))
                this.AdvanceMediaPlayer = new Mp4Player();

        }
        public void Play(string type)
        {
            if (AdvanceMediaPlayer is VicPlayer)
                AdvanceMediaPlayer.PlayVic();
            else if (AdvanceMediaPlayer is Mp4Player)
                AdvanceMediaPlayer.PlayMp4();
        }
    }
}
