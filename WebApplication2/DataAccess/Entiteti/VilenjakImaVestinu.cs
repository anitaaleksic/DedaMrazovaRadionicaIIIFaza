using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakImaVestinu
    {
        public virtual int ID { get; set; }
        public virtual VilenjakIrvasi VilenjakIrvasi { get; set; }
        public virtual MagicnaVestina MagicnaVestina { get; set; }
        public VilenjakImaVestinu() { }
    }
}
