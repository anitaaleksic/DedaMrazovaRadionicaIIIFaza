using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakZnaPesmu
    {
        public virtual int ID { get; set; }

        public virtual Pesma Pesma { get; set; }

        public virtual VilenjakIrvasi VilenjakIrvasi { get; set; }

        public VilenjakZnaPesmu() { }
    }
}
