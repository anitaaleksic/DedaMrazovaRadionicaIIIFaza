using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class PoklonView
    {
        public virtual int ID { get; set; }
        public virtual string Boja { get; set; }
        public virtual string Posveta { get; set; }

        public virtual IList<ZeljaView> SeOdnosiNaZelje { get; set; }
        public virtual IList<IgrackaView> SpakovaneIgracke { get; set; }
        public virtual IList<VilenjakPokloniView> PakovaliVilenjaci { get; set; }
        public TovarView SeNalaziUTovaru;
        

        public PoklonView()
        {
            SeOdnosiNaZelje = new List<ZeljaView>();
            SpakovaneIgracke = new List<IgrackaView>();
            PakovaliVilenjaci = new List<VilenjakPokloniView>();
        }

        public PoklonView(Poklon p)
        {
            if(p != null)
            {
                ID = p.ID;
                Boja = p.Boja;
                Posveta = p.Posveta;
                SeNalaziUTovaru = new TovarView(p.SeNalaziUTovaru);
            }
            
        }

        /*internal PoklonView(Poklon p, Tovar t) : this(p)
        {
            SeNalaziUTovaru = new TovarView(t);
        }*/
    }
    
}
