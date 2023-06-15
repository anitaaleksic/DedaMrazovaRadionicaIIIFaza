using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class IrvasView
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Nadimak { get; set; }
        public char Pol { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public virtual IList<VilenjakIrvasiView> ZaduzeniVilenjaci { get; set; }
        public virtual IList<TovarView> IsporucujeTovare { get; set; }

        public IrvasView()
        {
            ZaduzeniVilenjaci = new List<VilenjakIrvasiView>();
            IsporucujeTovare = new List<TovarView>();
        }
        public IrvasView(Irvas irvas)
        {
            if (irvas != null)
            {
                ID = irvas.ID;
                Ime = irvas.Ime;
                Nadimak = irvas.Nadimak;
                Pol = irvas.Pol;
                DatumRodjenja = irvas.DatumRodjenja;

            }
        }
    }
}
