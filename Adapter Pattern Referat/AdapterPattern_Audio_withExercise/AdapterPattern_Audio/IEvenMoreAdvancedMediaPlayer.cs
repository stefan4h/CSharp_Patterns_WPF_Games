using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Audio
{
    interface IEvenMoreAdvancedMediaPlayer
    {
            void PlayVlx(string fileName);
            void PlayMp5(string fileName);
    }
}
