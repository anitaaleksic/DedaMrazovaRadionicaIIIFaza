using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakPosedujeVestinu
    {
        public virtual int ID { get; set; }
        public virtual VilenjakIgracke VilenjakIgracke { get; set; }
        public virtual MagicnaVestina MagicnaVestina { get; set; }
        public VilenjakPosedujeVestinu() { }
    }
}
