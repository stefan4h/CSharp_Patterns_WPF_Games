using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    interface ISoundSetting
    {
        void SetTheGeneralSound(int percent);

        void SetDialogueSound(int percent);

        void SetEnvironmentSound(int percent);

        void SetSoundEffects(int percent);

        void TestIt();
    }
}
