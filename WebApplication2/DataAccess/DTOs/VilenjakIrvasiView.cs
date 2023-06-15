using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class VilenjakIrvasiView : VilenjakView
    {
        public  IrvasView ZaduzenZaIrvasa;
        public virtual IList<PesmaView> ZnaPesme { get; set; }
        public virtual IList<MagicnaVestinaView> ImajuVestine { get; set; }
        public VilenjakIrvasiView()
        {
            ZnaPesme = new List<PesmaView>();
            ImajuVestine = new List<MagicnaVestinaView>();
        }

        public VilenjakIrvasiView(VilenjakIrvasi v) : base(v) {
            //ZaduzenZaIrvasa = new IrvasView(v.ZaduzenZaIrvasa);
        }

        /*internal VilenjakIrvasiView(VilenjakIrvasi v, Irvas i) : base(v)
        {
            ZaduzenZaIrvasa = new IrvasView(i);
        }*/
        
    }
}
