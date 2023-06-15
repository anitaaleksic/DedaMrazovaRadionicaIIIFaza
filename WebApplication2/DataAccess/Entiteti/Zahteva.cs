using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Zahteva
    {
        public virtual int ID { get; set; }
        public virtual DeoRadionice DeoRadionice { get; set; }
        public virtual MagicnaVestina MagicnaVestina { get; set; }
        public Zahteva() { }
    }
}
