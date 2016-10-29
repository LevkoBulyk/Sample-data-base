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
        public uint DecayTime { get; set; }
        public string Comment { get; set; }

        #endregion

        #region Constructors

        public SpectralLine(int Id, int SpectrumId, float WaveLength, string Transition)
        {
            this.Id = Id;
            this.SpectrumId = SpectrumId;
            this.WaveLength = WaveLength;
            this.Transition = Transition;
        }

        public SpectralLine(int Id, int SpectrumId, float WaveLength, float Width, ushort RelativeIntensity, string Transition, uint DecayTime)
            : this(Id, SpectrumId, WaveLength, Transition)
        {
            this.Width = Width;
            this.RelativeIntensity = RelativeIntensity;
            this.DecayTime = DecayTime;
        }

        public SpectralLine(int Id, int SpectrumId, float WaveLength, float Width, ushort RelativeIntensity, string Transition, uint DecayTime, string Comment)
            : this(Id, SpectrumId, WaveLength, Width, RelativeIntensity, Transition, DecayTime)
        {
            this.Comment = Comment;
        }

        #endregion
    }
}
