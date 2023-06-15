using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Igracka
    {
        public virtual int ID { get; protected set; }
        public virtual int RedniBroj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Opis { get; set; }

        public virtual Poklon SpakovanaUPoklon { get; set; }

        public virtual VilenjakIgracke IzradioJeVilenjak { get; set; }

        //1:1
        public virtual Zelja PoZelji { get; set; } 
    }
}
