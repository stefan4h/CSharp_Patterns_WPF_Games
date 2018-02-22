using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            // only for testing

            SoundPreferences s = new SoundPreferences(50, 50, 80, 100);

            GraphicsPreferences g = new GraphicsPreferences(480, 720, 30, EQuality.Low, EQuality.High, EQuality.Medium);

            GamePreferences gamPref = new GamePreferences(150,EDifficulty.Hard);

            GeneralPreferences genPref = new GeneralPreferences(75, EDisplay.Borderless);

            IGameSettingFacade r = new RestrictedGameSettingsFacade(new LowGraphicSetting(),new HighSoundQualitySetting(),
                new GameGeneralSettings(new GeneralSettings(), new GameSettings()));
            
            r.SetGraphicSettings(g);

            r.SetSoundSettings(s);

            r.SetGeneralSettings(gamPref, genPref);

            Console.ReadLine();
        }
    }
}
