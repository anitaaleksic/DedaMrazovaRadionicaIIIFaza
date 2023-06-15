using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class VilenjakTovar : Vilenjak
    {
        public virtual Tovar PripremioTovar { get; set; }

    }
}
