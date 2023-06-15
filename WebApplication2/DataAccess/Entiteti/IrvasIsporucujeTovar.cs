using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Entiteti
{
    public class IrvasIsporucujeTovar
    {
        public virtual int ID { get; set; } 
        public virtual Irvas Irvas { get; set; }
        public virtual Tovar Tovar { get; set; }

        public IrvasIsporucujeTovar() { }
    }
}
