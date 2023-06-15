using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Tovar
    {
        public virtual int ID { get; protected set; }
        public virtual string Grad { get; set; }

        public virtual IList<Poklon> PokloniUTovaru { get; set;} 
        public virtual IList<VilenjakTovar> PakovaliVilenjaci { get; set; }
        //public virtual IList<Irvas> IsporucujuIrvasi { get; set; }
        //N:M
        public virtual IList<IrvasIsporucujeTovar> IrvasIsporucujeTovar { get; set; }


        public Tovar()
        {
            PokloniUTovaru = new List<Poklon>();
            PakovaliVilenjaci = new List<VilenjakTovar>();
            //IsporucujuIrvasi = new List<Irvas>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovar>();
        }
    }
}
