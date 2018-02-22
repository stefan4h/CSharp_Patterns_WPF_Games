using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    class SoundPreferences
    {
        public int generalSound;
        public int soundEffects;
        public int dialogueSound;
        public int environmentSound;

        public SoundPreferences(int generalSound, int soundEffects, int dialogueSound, int environmentSound)
        {
            this.dialogueSound = dialogueSound;
            this.environmentSound = environmentSound;
            this.soundEffects = soundEffects;
            this.generalSound = generalSound;
        }
    }
}
