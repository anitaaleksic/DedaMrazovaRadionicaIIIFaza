using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class IgrackaMapiranja : ClassMap<Igracka>
    {
        public IgrackaMapiranja()
        {
            Table("IGRACKA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.RedniBroj, "REDNI_BROJ");
            Map(x => x.Tip, "TIP");
            Map(x => x.Opis, "OPIS");

            References(x => x.SpakovanaUPoklon).Column("SIFRA_POKLONA").LazyLoad();

            References(x => x.IzradioJeVilenjak).Column("ID_VILENJAK").LazyLoad();

            HasOne(x => x.PoZelji).PropertyRef(x => x.IDIgracke);
        }
    }
}
