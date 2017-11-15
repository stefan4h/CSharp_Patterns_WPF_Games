using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Audio
{
    class AdvancedMediaAdapter:IMediaPlayer
    {
            IEvenMoreAdvancedMediaPlayer evenMoreAdvancedMusicPlayer;

            public AdvancedMediaAdapter(string audioType)
            {
                if (audioType == "vlx")
                {
                    evenMoreAdvancedMusicPlayer = new VlxPlayer();
                }
                else if (audioType == "mp5")
                {
                    evenMoreAdvancedMusicPlayer = new Mp5Player();
                }
            }
            public void Play(string audioType, string fileName)
            {

                if (audioType == "vlx")
                {
                    evenMoreAdvancedMusicPlayer.PlayVlx(fileName);
                }
                else if (audioType == "mp5")
                {
                    evenMoreAdvancedMusicPlayer.PlayMp5(fileName);
                }
            }
        }
    }

