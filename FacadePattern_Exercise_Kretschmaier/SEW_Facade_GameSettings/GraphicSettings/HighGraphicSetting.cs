using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    class HighGraphicSetting : IGraphics
    {
        int fps = 60;
        int yResolution = 1080;
        int xResolution =1920;
        EQuality shadowQuality = EQuality.Medium;
        EQuality waterQuality = EQuality.Medium;
        EQuality textureQuality = EQuality.Medium;

        public void SetFPS(int fps)
        {
            this.fps = fps;
        }

        public void SetResolution(int y, int x)
        {
            yResolution = y;
            xResolution = x;
        }

        public void SetShadowQuality(EQuality e)
        {
            shadowQuality = e;
        }

        public void SetWaterQuality(EQuality e)
        {
            waterQuality = e;
        }

        public void TextureQuality(EQuality e)
        {
            textureQuality = e;
        }

        public void TestIt()
        {
            Console.WriteLine("High Game Graphics");
            Console.WriteLine(textureQuality);
            Console.WriteLine(shadowQuality);
            Console.WriteLine(waterQuality);
            Console.WriteLine(fps);
            Console.WriteLine(xResolution + "x" + yResolution);
        }
    }
}
