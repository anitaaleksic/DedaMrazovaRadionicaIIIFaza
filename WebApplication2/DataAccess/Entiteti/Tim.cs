using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class Tim
    {
        public virtual int ID { get; protected set; }

        //1:1 da li ovako
        public virtual VilenjakIgracke Koordinator { get; set; }

        public virtual IList<VilenjakIgracke> ClanoviTima { get; set; }

        public Tim()
        {
            ClanoviTima = new List<VilenjakIgracke>();
        }
    }
}
