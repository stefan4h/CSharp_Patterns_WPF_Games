using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    class MediumSoundQualitySetting : ISoundSetting
    {
        int generalSound = 100;
        int soundEffects = 100;
        int dialogueSound = 100;
        int environmentSound = 100;

        public void SetDialogueSound(int percent)
        {
            dialogueSound = percent;

        }

        public void SetEnvironmentSound(int percent)
        {
            environmentSound = percent;
        }

        public void SetSoundEffects(int percent)
        {
            soundEffects = percent;
        }

        public void SetTheGeneralSound(int percent)
        {
            generalSound = percent;
        }

        public void TestIt()
        {
            Console.WriteLine("The sound quality is acceptable");
            Console.WriteLine("Medium: General sound percent:" + generalSound);
            Console.WriteLine("Medium: Soundeffects percent:" + soundEffects);
            Console.WriteLine("Medium: Environment sound percent:" + environmentSound);
            Console.WriteLine("Medium: Dialogue sound percent:" + dialogueSound);
        }
    }
}
