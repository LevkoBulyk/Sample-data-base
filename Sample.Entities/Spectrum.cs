namespace Sample.Entities
{
    class Spectrum : Table
    {
        #region Helpfull enum

        public enum SpectrumTypes
        {
            Luminescence,
            Excitation
        }

        #endregion

        #region Bare SQL properties

        public int CompountId { get; set; }
        public SpectrumTypes SpectrumType { get; set; }
        public string SourceLink { get; set; }
        public int UserId { get; set; }
        public bool Visibility { get; set; }
        public float Temperature { get; set; }
        public float Preasure { get; set; }
        public float Wavelength { get; set; }

        #endregion

        #region Constructors

        public Spectrum(int Id, int CompountId, SpectrumTypes SpectrumType)
        {
            this.Id = Id;
            this.CompountId = CompountId;
            this.SpectrumType = SpectrumType;
        }

        public Spectrum()
        {
               
        }
        #endregion
    }
}
