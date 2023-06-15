using DedaMraz.Entiteti;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakPosedujeVestinuMapiranja : ClassMap<VilenjakPosedujeVestinu>
    {
        public VilenjakPosedujeVestinuMapiranja()
        {
            Table("POSEDUJE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.MagicnaVestina).Column("NAZIV_VES").LazyLoad();
            References(x => x.VilenjakIgracke).Column("VILENJAK_ID").LazyLoad();
        }
    }
}
