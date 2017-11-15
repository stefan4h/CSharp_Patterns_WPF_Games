using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Audio
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;
        AdvancedMediaAdapter advancedMediaAdapter;

   public void Play(string audioType, string fileName)
    {

        //inbuilt support to play mp3 music files
        if (audioType=="mp3")
        {
            Console.WriteLine("Playing mp3 file. Name: " + fileName);
        }

        //mediaAdapter is providing support to play other file formats
        else if (audioType=="vlc" || audioType=="mp4")
        {
            mediaAdapter = new MediaAdapter(audioType);
            mediaAdapter.Play(audioType, fileName);
        }
        else if (audioType=="vlx" || audioType=="mp5")
        {
            advancedMediaAdapter = new AdvancedMediaAdapter(audioType);
            advancedMediaAdapter.Play(audioType, fileName);
        }
        else
        {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
        }
    }
    }


}
