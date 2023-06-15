using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Irvas
    {
        public virtual int ID { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Nadimak { get; set; }
        public virtual char Pol { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        
        public virtual IList<VilenjakIrvasi> ZaduzeniVilenjaci { get; set; }
        //public virtual IList<Tovar> IsporucujeTovare { get; set; }

        //N:M
        public virtual IList<IrvasIsporucujeTovar> IrvasIsporucujeTovar { get; set; }
        public Irvas()
        {
            ZaduzeniVilenjaci = new List<VilenjakIrvasi>();
            //IsporucujeTovare = new List<Tovar>();
            IrvasIsporucujeTovar = new List<IrvasIsporucujeTovar>();
        }
    }
}
