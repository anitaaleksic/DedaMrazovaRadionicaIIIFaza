using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class MagicnaVestinaView
    {
        public string ID { get; set; }
        public IList<VilenjakIrvasiView> ImajuVilenjaci { get; set; }
        public IList<VilenjakIgrackeView> PosedujuVilenjaci { get; set; }
        public IList<DeoRadioniceView> ZahtevanaZaRadionice { get; set; }
        public MagicnaVestinaView()
        {
            ImajuVilenjaci = new List<VilenjakIrvasiView>();
            PosedujuVilenjaci = new List<VilenjakIgrackeView>();
            ZahtevanaZaRadionice = new List<DeoRadioniceView>();
        }
        public MagicnaVestinaView(MagicnaVestina m)
        {
            if(m != null){
                this.ID = m.ID;
            }
            
        }
    }
}
