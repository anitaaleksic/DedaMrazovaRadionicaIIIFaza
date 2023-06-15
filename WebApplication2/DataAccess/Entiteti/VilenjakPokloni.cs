using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakPokloni : Vilenjak
    {
        //public virtual IList<Poklon> SpakovaoPoklone { get; set; }

        //n:m
        public virtual IList<JePakovao> JePakovao { get; set; }

        public VilenjakPokloni()
        {
            //SpakovaoPoklone = new List<Poklon>();
            JePakovao = new List<JePakovao>();
        }
    }
}
