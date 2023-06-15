using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class ZeljaMapiranja : ClassMap<Zelja>
    {
        public ZeljaMapiranja()
        {
            Table("ZELJA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();
            Map(x => x.Naziv, "NAZIV");
            //mapiranje svojstava.
            References(x => x.PripadaPismu).Column("ID_PISMA").LazyLoad();

            References(x => x.SeOdnosiNaPoklon).Column("SIFRA_POK").LazyLoad();

            //1:1 da li ovako
            References(x => x.IDIgracke).Column("ID_IGRACKE").LazyLoad();
        }
    }
}
