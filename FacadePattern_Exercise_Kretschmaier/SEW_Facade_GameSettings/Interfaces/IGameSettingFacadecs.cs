using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SEW_Facade_GameSettings.Exceptions;

namespace SEW_Facade_GameSettings
{
    interface IGameSettingFacade
    {
        void SetGraphicSettings(GraphicsPreferences g);
        void SetSoundSettings(SoundPreferences s);
        void SetGeneralSettings(GamePreferences g, GeneralPreferences ge);
    }

    class DetailedGameSettingsFacade:IGameSettingFacade
    {
        IGraphics gameGraphics;
        ISoundSetting gameSoundSettings;
        IGameGeneralSettingFacade gameGeneralSettings;

        public DetailedGameSettingsFacade(IGraphics g, ISoundSetting s, IGameGeneralSettingFacade gameGeneralSettings)
        {
            gameGraphics = g;
            gameSoundSettings = s;
            this.gameGeneralSettings = gameGeneralSettings;
        }

        public void SetGeneralSettings(GamePreferences g, GeneralPreferences ge)
        {
            gameGeneralSettings.Configure(ge, g);
        }

        public void SetGraphicSettings(GraphicsPreferences g)
        {
            gameGraphics.SetResolution(g.yResolution, g.xResolution);
            gameGraphics.SetFPS(g.fps);
            gameGraphics.SetShadowQuality(g.shadowQuality);
            gameGraphics.SetWaterQuality(g.waterQuality);
            gameGraphics.TextureQuality(g.textureQuality);
            gameGraphics.TestIt();
        }

        public void SetSoundSettings(SoundPreferences s)
        {
            gameSoundSettings.SetDialogueSound(s.dialogueSound);
            gameSoundSettings.SetEnvironmentSound(s.environmentSound);
            gameSoundSettings.SetSoundEffects(s.soundEffects);
            gameSoundSettings.SetTheGeneralSound(s.generalSound);
            gameSoundSettings.TestIt();
        }
    }

    class RestrictedGameSettingsFacade : IGameSettingFacade
    {
        IGraphics gameGraphics;
        ISoundSetting gameSoundSettings;
        IGameGeneralSettingFacade gameGeneralSettings;

        public RestrictedGameSettingsFacade(IGraphics g, ISoundSetting s, IGameGeneralSettingFacade gameGeneralSettings)
        {
            gameGraphics = g;
            gameSoundSettings = s;
            this.gameGeneralSettings = gameGeneralSettings;
        }

        public void SetGeneralSettings(GamePreferences g, GeneralPreferences ge)
        {
            gameGeneralSettings.Configure(ge, g);
        }

        public void SetGraphicSettings(GraphicsPreferences g)
        {
            if (g.fps > 30)
                throw new DoesNotMatchRestrictionsException("FPS sind über 30");
            if(g.yResolution>720 || g.xResolution>480)
                throw new DoesNotMatchRestrictionsException("Zu große Auflösung");
            gameGraphics.SetResolution(g.yResolution, g.xResolution);
            gameGraphics.SetFPS(g.fps);
            gameGraphics.SetShadowQuality(g.shadowQuality);
            gameGraphics.SetWaterQuality(g.waterQuality);
            gameGraphics.TextureQuality(g.textureQuality);
            gameGraphics.TestIt();
        }

        public void SetSoundSettings(SoundPreferences s)
        {
            if (s.dialogueSound < 80)
                throw new DoesNotMatchRestrictionsException("Dialog-Lautstärke ist zu niedrig");
            if (s.generalSound>50)
                throw new DoesNotMatchRestrictionsException("Algemeine-Lautstärke ist zu hoch");
            gameSoundSettings.SetDialogueSound(s.dialogueSound);
            gameSoundSettings.SetEnvironmentSound(s.environmentSound);
            gameSoundSettings.SetSoundEffects(s.soundEffects);
            gameSoundSettings.SetTheGeneralSound(s.generalSound);
            gameSoundSettings.TestIt();
        }
    }
}
