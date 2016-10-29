namespace Sample.Entities
{
    class SpectralLine : Table
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

        public SpectralLine()
        {
            
        }
        public SpectralLine(int Id, int SpectrumId, float WaveLength, string Transition)
        {
            this.Id = Id;
            this.SpectrumId = SpectrumId;
            this.WaveLength = WaveLength;
            this.Transition = Transition;
        }

        public SpectralLine(int Id, int SpectrumId, float WaveLength, float Width, ushort RelativeIntensity, string Transition)
            : this(Id, SpectrumId, WaveLength, Transition)
        {
            this.Width = Width;
            this.RelativeIntensity = RelativeIntensity;
        }

        public SpectralLine(int Id, int SpectrumId, float WaveLength, float Width, ushort RelativeIntensity, string Transition, string Comment)
            : this(Id, SpectrumId, WaveLength, Width, RelativeIntensity, Transition)
        {
            this.Comment = Comment;
        }

        #endregion
    }
}
