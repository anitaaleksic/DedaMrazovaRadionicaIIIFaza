using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class DeoRadionice
    {
        public virtual int ID { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual int BrojVilenjaka { get; set; }
        public virtual string TipIgracaka { get; set; }
        public virtual DateTime DatumPostavljanja { get; set; }


        //1:1 
        public virtual VilenjakIgracke Sef { get; set; }

        public virtual IList<VilenjakIgracke> RasporedjeniVilenjaci { get; set; }
        //public virtual IList<MagicnaVestina> ZahtevaneVestine { get; set; }

        //N:M

        public virtual IList<Zahteva> Zahteva { get; set; }

        public DeoRadionice()
        {
            RasporedjeniVilenjaci = new List<VilenjakIgracke>();
            //ZahtevaneVestine = new List<MagicnaVestina>();
            Zahteva = new List<Zahteva>();
        }
    }
}
