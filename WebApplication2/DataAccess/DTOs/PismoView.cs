using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class PismoView
    {
        public virtual int ID { get; set; }
        public virtual DateTime DatumSlanja { get; set; }
        public virtual DateTime DatumPrijema { get; set; }
        public virtual float IndeksDobrote { get; set; }
        public virtual string Tekst { get; set; }
        public DeteView PoslaloDete;
        public virtual IList<ZeljaView> SadrziZelje { get; set; }

        public PismoView()
        {
            SadrziZelje = new List<ZeljaView>();
        }
        public PismoView(Pismo pismo)
        {
            if(pismo != null)
            {
                ID = pismo.ID;
                DatumSlanja = pismo.DatumSlanja;
                DatumPrijema = pismo.DatumPrijema;
                IndeksDobrote = pismo.IndeksDobrote;
                Tekst = pismo.Tekst;
                PoslaloDete = new DeteView(pismo.PoslaloDete);
            }
            
        }
        /*internal PismoView(Pismo p, Dete? d) : this(p)
        {
            PoslaloDete = new DeteView(d);
        }*/
    }
}

    
