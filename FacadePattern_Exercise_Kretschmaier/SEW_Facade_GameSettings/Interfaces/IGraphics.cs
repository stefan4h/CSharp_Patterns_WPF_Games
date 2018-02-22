using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    enum EQuality { Low, Medium, High}
    interface IGraphics
    {
        void TextureQuality(EQuality e);

        void SetResolution(int y, int x);

        void SetWaterQuality(EQuality e);

        void SetShadowQuality(EQuality e);

        void SetFPS(int fps);

        void TestIt();

    }
}
