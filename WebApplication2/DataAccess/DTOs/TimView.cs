using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class TimView
    {
        public virtual int ID { get; set; }
        public VilenjakIgrackeView Koordinator;

        public virtual IList<VilenjakIgrackeView> ClanoviTima { get; set; }

        public TimView()
        {
            ClanoviTima = new List<VilenjakIgrackeView>();
        }
        public TimView(Tim t)
        {
            if (t != null)
            {
                ID = t.ID;
                Koordinator = new VilenjakIgrackeView(t.Koordinator);
            }            
        }

        /*internal TimView(Tim t, VilenjakIgracke v) : this(t)
        {
            Koordinator = new VilenjakIgrackeView(v);
        }*/
    }
    
}
