using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Audio
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file. Name: " + fileName);
        }
 
        public void PlayMp4(string fileName)
        {
            //do nothing
        }
    }
     public class Mp4Player : IAdvancedMediaPlayer
     {
        public void PlayVlc(string fileName)
        {
            //do nothing
        }

        public void PlayMp4(string fileName)
        {
           Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }
      }
}

