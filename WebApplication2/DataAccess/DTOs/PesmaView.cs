using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class PesmaView
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public string Tekst { get; set; }

        public virtual IList<VilenjakIrvasiView> ZnajuVilenjaci { get; set; }

        public PesmaView()
        {
            ZnajuVilenjaci = new List<VilenjakIrvasiView>();
        }
        public PesmaView(Pesma pesma)
        {
            if (pesma != null)
            {
                ID = pesma.ID;
                Naziv = pesma.Naziv;
                Tekst = pesma.Tekst;
            }
            
        }
    }
}
