using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entities
{
    class SpectrumImg : Table
    {
        public int SpectrumId { get; set; }
        public string Img { get; set; } // Хз який тип файлу

        public SpectrumImg()
        {
            
        }
    }
}
