using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    public class SpectrumImg : Table
    {
        #region Bare SQL parameters

        public int SpectrumId { get; set; }
        public string Img { get; set; } //TODO: тип файлу

        #endregion

        #region Constructors

        public SpectrumImg() { }
        // TODO: Constructors for SpectrumImg class

        #endregion

    }
}
