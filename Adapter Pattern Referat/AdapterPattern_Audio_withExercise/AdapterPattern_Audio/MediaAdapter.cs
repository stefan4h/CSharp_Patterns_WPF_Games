using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Audio
{
    public class MediaAdapter : IMediaPlayer
    {

        IAdvancedMediaPlayer advancedMusicPlayer;

   public MediaAdapter(string audioType)
    {
        if (audioType=="vlc")
        {
            advancedMusicPlayer = new VlcPlayer();
        }
        else if (audioType=="mp4")
        {
            advancedMusicPlayer =new Mp4Player();
        }
    }
   public void Play(string audioType, string fileName)
    {

        if (audioType=="vlc")
        {
            advancedMusicPlayer.PlayVlc(fileName);
        }
        else if (audioType=="mp4")
        {
            advancedMusicPlayer.PlayMp4(fileName);
        }
    }
    }


}
