using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Audio
{
    public class VlxPlayer : IEvenMoreAdvancedMediaPlayer
    {
        public void PlayVlx(string fileName)
        {
            Console.WriteLine("Playing vlx file. Name: " + fileName);
        }

        public void PlayMp5(string fileName)
        {
            //do nothing
        }
    }
    public class Mp5Player : IEvenMoreAdvancedMediaPlayer
    {
        public void PlayVlx(string fileName)
        {
            //do nothing
        }

        public void PlayMp5(string fileName)
        {
            Console.WriteLine("Playing mp5 file. Name: " + fileName);
        }
    }
}
