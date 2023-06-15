using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class JePakovao
    {
        public virtual int ID { get; set; }

        public virtual Poklon Poklon { get; set; }
        public virtual VilenjakPokloni VilenjakPokloni { get; set; }

        public JePakovao() { }
    }
}
