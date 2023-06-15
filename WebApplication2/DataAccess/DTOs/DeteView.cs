using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class DeteView
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public string ImeMajke { get; set; }

        public string ImeOca { get; set; }

        public virtual IList<PismoView> SaljePisma { get; set; }

        public DeteView()
        {
            SaljePisma = new List<PismoView>();
        }

        public DeteView(Dete dete)
        {
            if(dete != null)
            {
                ID = dete.ID;
                Ime = dete.Ime;
                Prezime = dete.Prezime;
                DatumRodjenja = dete.DatumRodjenja;
                Drzava = dete.Drzava;
                Grad = dete.Grad;
                Adresa = dete.Adresa;
                ImeMajke = dete.ImeMajke;
                ImeOca = dete.ImeOca;

            }
        }
    }
}
