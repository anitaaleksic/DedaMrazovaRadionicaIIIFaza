using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakImaVestinuMapiranja : ClassMap<VilenjakImaVestinu>
    {
        public VilenjakImaVestinuMapiranja()
        {
            Table("IMA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakIrvasi).Column("VIL_ID").LazyLoad();
            References(x => x.MagicnaVestina).Column("NAZIV_VESTINE").LazyLoad();
        }
    }
}
