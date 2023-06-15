using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class TovarView
    {
        public int ID { get; set; }
        public string Grad { get; set; }

        public virtual IList<PoklonView> PokloniUTovaru { get; set; }
        public virtual IList<VilenjakIgrackeView> PakovaliVilenjaci { get; set; }
        public virtual IList<IrvasView> IsporucujuIrvasi { get; set; }

        public TovarView()
        {
            PokloniUTovaru = new List<PoklonView>();
            PakovaliVilenjaci = new List<VilenjakIgrackeView>();
            IsporucujuIrvasi = new List<IrvasView>();
        }

        public TovarView(Tovar t)
        {
            if(this != null)
            {
                ID = t.ID;
                Grad = t.Grad;
            }
            
        }
    }

}
