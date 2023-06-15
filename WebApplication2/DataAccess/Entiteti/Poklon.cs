using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Poklon
    {
        public virtual int ID { get; protected set; }
        public virtual string Boja { get; set; }
        public virtual string Posveta { get; set; }

        public virtual IList<Zelja> SeOdnosiNaZelje { get; set; }
        public virtual IList<Igracka> SpakovaneIgracke { get; set; }
        public virtual Tovar SeNalaziUTovaru { get; set; }

        //public virtual IList<VilenjakPokloni> PakovaliVilenjaci { get; set; }

        //N:M
        public virtual IList<JePakovao> JePakovao { get; set; }

        public Poklon()
        {
            SeOdnosiNaZelje = new List<Zelja>();
            SpakovaneIgracke = new List<Igracka>();

            //PakovaliVilenjaci = new List<VilenjakPokloni>();
            JePakovao = new List<JePakovao>();
        }
    }
}
