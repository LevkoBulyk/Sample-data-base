namespace Sample.Entities
{
    public class SpectralLine : Table
    {
        #region Bare SQL properties

        public int SpectrumId { get; set; }
        public int OriginOfLine { get; set; }
        public float WaveLength { get; set; }
        public float Width { get; set; }
        public ushort RelativeIntensity { get; set; }
        public string Transition { get; set; }
        public string Comment { get; set; }


        #endregion

        #region Constructors

        public SpectralLine() { }

        public SpectralLine(int id, int spectrumId, float waveLength, string transition)
        {
            this.Id = id;
            this.SpectrumId = spectrumId;
            this.WaveLength = waveLength;
            this.Transition = transition;
        }

        public SpectralLine(int id, int spectrumId, float waveLength, float width, ushort relativeIntensity, string transition)
            : this(id, spectrumId, waveLength, transition)
        {
            this.Width = width;
            this.RelativeIntensity = relativeIntensity;
        }

        public SpectralLine(int id, int spectrumId, float waveLength, float width, ushort relativeIntensity, string transition, string comment)
            : this(id, spectrumId, waveLength, width, relativeIntensity, transition)
        {
            this.Comment = comment;
        }

        #endregion
    }
}
