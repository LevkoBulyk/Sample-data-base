using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class Decay : Table
    {
        #region Bare SQL properties

        public int SpectralLineId { get; set; }
        public float Time { get; set; }
        public float ExtWavelength { get; set; }
        public float LumWavelength { get; set; }

        #endregion

        #region Constructors

        public Decay() { }

        public Decay(int spectralLineId, float time, float extWavelength, float lumWavelength)
        {
            SpectralLineId = spectralLineId;
            Time = time;
            ExtWavelength = extWavelength;
            LumWavelength = lumWavelength;
        }

        #endregion

    }
}
