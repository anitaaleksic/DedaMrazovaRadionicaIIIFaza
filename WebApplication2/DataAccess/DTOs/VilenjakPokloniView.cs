using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class VilenjakPokloniView : VilenjakView
    {
        /*public override string ToString()
        {
            return $"{Ime}";
        }*/
        public virtual IList<PoklonView> SpakovaoPoklone { get; set; }
        public VilenjakPokloniView()
        {
            SpakovaoPoklone = new List<PoklonView>();
        }
        public VilenjakPokloniView(VilenjakPokloni p): base(p) { }
    }
}
