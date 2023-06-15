using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Zelja
    {
        public virtual int ID { get; set; }
        public virtual string Naziv { get; set; }

        public virtual Pismo PripadaPismu { get; set; }

        public virtual Poklon SeOdnosiNaPoklon { get; set; }

        //1:1 da li ovako
        public virtual Igracka IDIgracke { get; set; }
    }
}
