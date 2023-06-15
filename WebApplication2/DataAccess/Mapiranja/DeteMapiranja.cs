using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class DeteMapiranja : ClassMap<Dete>
    {
        public DeteMapiranja()
        {
            Table("DETE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Grad, "GRAD");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.ImeMajke, "IME_MAJKE");
            Map(x => x.ImeOca, "IME_OCA");

            HasMany(x => x.SaljePisma).KeyColumn("ID_DETE").LazyLoad().Cascade.All().Inverse();
        }
    }
}

