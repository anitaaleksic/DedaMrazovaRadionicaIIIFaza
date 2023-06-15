using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class MagicnaVestina
    {
       public virtual string ID { get; /*protected*/ set; }//ne moze protected set zbog dodavanja

       //public virtual IList<VilenjakIrvasi> ImajuVilenjaci { get; set; }
       //public virtual IList<VilenjakIgracke> PosedujuVilenjaci { get; set; }
       //public virtual IList<DeoRadionice> ZahtevanaZaRadionice { get; set; }

        //m:n
       //public virtual int ID { get; set; }
       public virtual IList<Zahteva> Zahteva { get; set; }
       public virtual IList<VilenjakImaVestinu> VilenjakImaVestinu { get; set; }
       public virtual IList<VilenjakPosedujeVestinu> VilenjakPosedujeVestinu { get; set; }
       public MagicnaVestina()
       {
           //ImajuVilenjaci = new List<VilenjakIrvasi>();
           //PosedujuVilenjaci = new List <VilenjakIgracke>();
           //ZahtevanaZaRadionice = new List<DeoRadionice>();
           Zahteva = new List<Zahteva>();
           VilenjakImaVestinu = new List<VilenjakImaVestinu>();
           VilenjakPosedujeVestinu = new List<VilenjakPosedujeVestinu>();
       }
        
    }
}
