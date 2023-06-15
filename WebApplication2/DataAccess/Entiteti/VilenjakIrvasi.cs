using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakIrvasi : Vilenjak
    {
        public virtual Irvas ZaduzenZaIrvasa { get; set; }
        //public virtual IList<Pesma> ZnaPesme { get; set; }

        //n:m
        public virtual IList<VilenjakZnaPesmu> VilenjakZnaPesmu { get; set; }
        //public virtual IList<MagicnaVestina> ImajuVestine { get; set; }
        public virtual IList<VilenjakImaVestinu> VilenjakImaVestinu { get; set; }
        public VilenjakIrvasi()
        {
            //ZnaPesme = new List<Pesma>();
            VilenjakZnaPesmu = new List<VilenjakZnaPesmu>();
            //ImajuVestine = new List<MagicnaVestina>();
            VilenjakImaVestinu = new List<VilenjakImaVestinu>();
        }
    }
}
