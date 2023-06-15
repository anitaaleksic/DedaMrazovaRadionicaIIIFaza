using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class ZeljaView
    {
        public override string ToString()
        {
            return $"{Naziv}";
        }
        public virtual int ID { get; set; }

        public virtual string Naziv { get; set; }

        public PismoView PripadaPismu;

        public  PoklonView SeOdnosiNaPoklon;
        public  IgrackaView IDIgracke;

        public ZeljaView() { }

        public ZeljaView(Zelja z)
        {
            if(z != null)
            {
                ID = z.ID;
                Naziv = z.Naziv;
                PripadaPismu = new PismoView(z.PripadaPismu);
                //SeOdnosiNaPoklon = new PoklonView(z.SeOdnosiNaPoklon);
                IDIgracke = new IgrackaView(z.IDIgracke);
            }
            
        }
        /*internal ZeljaView(Zelja z, Pismo p) : this(z)
        {
            PripadaPismu = new PismoView(p);
        }
        internal ZeljaView(Zelja z, Poklon p) : this(z)
        {
            SeOdnosiNaPoklon = new PoklonView(p);
        }
        internal ZeljaView(Zelja z, Igracka i) : this(z)
        {
            IDIgracke = new IgrackaView(i);
        }*/
    }
}
