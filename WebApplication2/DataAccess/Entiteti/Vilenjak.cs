using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public abstract class Vilenjak
    {
        public virtual int ID { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string ZemljaPorekla { get; set; }
        public virtual string RadniStaz { get; set; }
    }
}