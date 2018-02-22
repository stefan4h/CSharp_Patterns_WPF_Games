using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEW_Facade_GameSettings
{
    class GraphicsPreferences
    {
        public EQuality textureQuality;
        public EQuality waterQuality;
        public EQuality shadowQuality;
        public int fps;
        public int yResolution;
        public int xResolution;

        public GraphicsPreferences(int xResolution, int yResolution, int fps, EQuality shadowQuality, EQuality waterQuality, EQuality textureQuality)
        {
            this.fps = fps;
            this.xResolution = xResolution;
            this.yResolution = yResolution;
            this.textureQuality = textureQuality;
            this.waterQuality = waterQuality;
            this.shadowQuality = shadowQuality;
        }

    }
}
