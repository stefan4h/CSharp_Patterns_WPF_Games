using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{

    enum EDifficulty { Easy, Normal, Hard}
    enum EDisplay{Fullscreen, Window, Borderless}

    interface IGameGeneralSettingFacade
    {
        void Configure(GeneralPreferences generalPref, GamePreferences gamePref);
    }

    class GameGeneralSettings:IGameGeneralSettingFacade
    {
        IGeneralSettings genSet;
        IGameSettings gamSet;

        public GameGeneralSettings(IGeneralSettings genSet, IGameSettings gamSet)
        {
            this.genSet = genSet;
            this.gamSet = gamSet;
        }

        public void Configure(GeneralPreferences generalPref, GamePreferences gamePref)
        {
            genSet.setDisplay(generalPref.display);
            genSet.setMouseSensitivity(generalPref.mouseSensitivity);
            genSet.TestIt();

            gamSet.setDifficulty(gamePref.gameDifficulty);
            gamSet.setEnemySpawnRate(gamePref.enemySpawnRate);
            gamSet.TestIt();
        }
    }

    interface IGeneralSettings 
    {
        void setMouseSensitivity(int mouseSensitivity);
        void setDisplay(EDisplay display);
        void TestIt();
    }

    class GeneralSettings:IGeneralSettings 
    {
        int mouseSensitivity = 50;
        EDisplay display = EDisplay.Fullscreen;

        public void setMouseSensitivity(int mouseSensitivity)
        {
            this.mouseSensitivity = mouseSensitivity;
        }

        public void setDisplay(EDisplay display)
        {
            this.display = display;
        }

        public void TestIt()
        {
            Console.WriteLine("General Settings:");
            Console.WriteLine("Mouse Sensitivity:" + mouseSensitivity);
            Console.WriteLine("Display:" + display);
        }
    }

    interface IGameSettings
    {
        void setEnemySpawnRate(int enemySpawnRate);
        void setDifficulty(EDifficulty gameDifficulty);
        void TestIt();
    }

    class GameSettings : IGameSettings
    {
        EDifficulty gameDifficulty = EDifficulty.Normal;
        int enemySpawnRate = 100;

        public void setEnemySpawnRate(int enemySpawnRate)
        {
            this.enemySpawnRate = enemySpawnRate;
        }

        public void setDifficulty(EDifficulty gameDifficulty)
        {
            this.gameDifficulty = gameDifficulty;
        }
            
        public void TestIt()
        {
            Console.WriteLine("Game Settings:");
            Console.WriteLine("Enemy spawn rate:"+enemySpawnRate);
            Console.WriteLine("Game difficulty:"+gameDifficulty);
        }
    }



    class GeneralPreferences
    {
        public int mouseSensitivity = 50;
        public EDisplay display = EDisplay.Fullscreen;

        public GeneralPreferences(int mouseSensitivity, EDisplay display)
        {
            this.mouseSensitivity = mouseSensitivity;
            this.display = display;
        }

    }

    class GamePreferences
    {
        public int enemySpawnRate = 100;
        public EDifficulty gameDifficulty = EDifficulty.Normal;

        public GamePreferences(int enemySpawnRate, EDifficulty gameDifficulty)
        {
            this.enemySpawnRate = enemySpawnRate;
            this.gameDifficulty = gameDifficulty;
        }
    }

}
