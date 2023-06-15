using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class DeoRadioniceView
    {        
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int BrojVilenjaka { get; set; }
        public string TipIgracaka { get; set; }
        public VilenjakIgrackeView Sef;
        public DateTime DatumPostavljanja { get; set; }
        public IList<VilenjakIgrackeView> RasporedjeniVilenjaci { get; set; }
        public IList<MagicnaVestinaView> ZahtevaneVestine { get; set; }

        public DeoRadioniceView()
        {
            RasporedjeniVilenjaci = new List<VilenjakIgrackeView>();
            ZahtevaneVestine = new List<MagicnaVestinaView>();
        }
        
        public DeoRadioniceView(DeoRadionice deoRadionice)
        {
            if (deoRadionice != null)
            {
                this.ID = deoRadionice.ID;
                this.Naziv = deoRadionice.Naziv;
                this.BrojVilenjaka = deoRadionice.BrojVilenjaka;
                this.TipIgracaka = deoRadionice.TipIgracaka;
                this.DatumPostavljanja = deoRadionice.DatumPostavljanja;
                Sef = new VilenjakIgrackeView(deoRadionice.Sef);
            }
        }

        /*internal DeoRadioniceView(DeoRadionice dr, VilenjakIgracke v) : this(dr)
        {
            Sef = new VilenjakIgrackeView(v);
        }*/

    }
}
