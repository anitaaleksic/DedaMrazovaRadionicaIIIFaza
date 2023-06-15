using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class IgrackaView
    {
        public virtual int ID { get; set; }
        public virtual int RedniBroj { get; set; }
        public virtual string Tip { get; set; }
        public virtual string Opis { get; set; }
        public PoklonView? SpakovanaUPoklon { get; set; }
        public VilenjakIgrackeView? IzradioJeVilenjak { get; set; }

        public IgrackaView() { }

        public IgrackaView(Igracka igracka)
        {
            if(igracka != null)
            {
                this.ID = igracka.ID;
                this.RedniBroj = igracka.RedniBroj;
                this.Tip = igracka.Tip;
                this.Opis = igracka.Opis;
                this.SpakovanaUPoklon = new PoklonView(igracka.SpakovanaUPoklon);
                this.IzradioJeVilenjak = new VilenjakIgrackeView(igracka.IzradioJeVilenjak);
            }
        }

        //internal IgrackaView(Igracka i, Poklon p): this(i)
        //{
        //    SpakovanaUPoklon = new PoklonView(p);
        //}

        //internal IgrackaView(Igracka i, VilenjakIgracke vigr) : this(i)
        //{
        //    IzradioJeVilenjak = new VilenjakIgrackeView(vigr);
        //}
    }
    
}
