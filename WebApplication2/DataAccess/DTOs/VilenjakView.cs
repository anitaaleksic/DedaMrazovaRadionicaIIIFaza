using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class VilenjakView
    {
        public virtual int ID { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual string RadniStaz { get; set; }
        public VilenjakView() { }

        public VilenjakView(Vilenjak v)
        {
            if(v != null)
            {
                this.ID = v.ID;
                this.Ime = v.Ime;
                this.ZemljaPorekla = v.ZemljaPorekla;
                this.RadniStaz = v.RadniStaz;
            }
        }
        
    }
}
