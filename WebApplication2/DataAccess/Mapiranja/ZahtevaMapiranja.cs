using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class ZahtevaMapiranja : ClassMap<Zahteva>
    {
        public ZahtevaMapiranja()
        {
            Table("ZAHTEVA");


            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.DeoRadionice).Column("RADIONICA_ID").LazyLoad();
            References(X => X.MagicnaVestina).Column("NAZIV_V").LazyLoad();
        }
    }
}
