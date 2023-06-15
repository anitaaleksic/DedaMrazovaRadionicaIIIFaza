using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakMapiranja : ClassMap<Vilenjak>
    {
        public VilenjakMapiranja()
        {
            UseUnionSubclassForInheritanceMapping();

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Ime).Column("IME");
            Map(x => x.ZemljaPorekla).Column("ZEMLJA_POREKLA");
            Map(x => x.RadniStaz).Column("RADNI_STAZ");
        }
    }
}
