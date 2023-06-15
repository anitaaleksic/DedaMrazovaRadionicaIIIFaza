using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Pesma
    {
        public virtual int ID { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual string Tekst { get; set; }

        //public virtual IList<VilenjakIrvasi> ZnajuVilenjaci { get; set;}
        //n:m
        public virtual IList<VilenjakZnaPesmu> VilenjakZnaPesmu { get; set; }

        public Pesma()
        {
            //ZnajuVilenjaci = new List<VilenjakIrvasi>();
            VilenjakZnaPesmu = new List<VilenjakZnaPesmu>();
        }
    }
}
