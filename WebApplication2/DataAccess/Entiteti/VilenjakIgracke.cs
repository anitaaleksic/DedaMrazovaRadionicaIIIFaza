using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakIgracke : Vilenjak
    {
        public virtual float Ocena { get; set; }
        public virtual string TrajanjeObuke { get; set; }
        public virtual string SpecijalizovanZa { get; set; }
        public virtual string Sef { get; set; }
        public virtual string Mentor { get; set; }
        public virtual string Koordinator { get; set; }
        public virtual IList<Igracka> IzradjeneIgracke { get; set; }
        // 1:1
        public virtual DeoRadionice JeSef { get; set; }
        public virtual Tim JeKoordinator { get; set; }
        public virtual DeoRadionice RasporedjenURadionicu { get; set; }

        public virtual VilenjakIgracke IDMentor { get; set; }

        public virtual IList<VilenjakIgracke> ObucavaniVilenjaci { get; set; }
        //public virtual IList<MagicnaVestina> PosedujeVestine { get; set; }

        //m:n
        public virtual IList<VilenjakPosedujeVestinu> VilenjakPosedujeVestinu { get; set; }
        public virtual Tim Tim { get; set; }
        public VilenjakIgracke()
        {
            IzradjeneIgracke = new List<Igracka>();
            ObucavaniVilenjaci = new List<VilenjakIgracke>();
            VilenjakPosedujeVestinu = new List<VilenjakPosedujeVestinu>();
        }

        
    }
}
