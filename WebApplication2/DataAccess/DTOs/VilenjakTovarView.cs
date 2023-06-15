using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class VilenjakTovarView : VilenjakView
    {
        public TovarView PripremioTovar;

        public VilenjakTovarView() { }

        public VilenjakTovarView(VilenjakTovar vt) : base(vt) {
            PripremioTovar = new TovarView(vt.PripremioTovar);
        }
        /*internal VilenjakTovarView(VilenjakTovar vt, Tovar t) : this(vt)
        {
            PripremioTovar = new TovarView(t);
        }*/
    }
}
