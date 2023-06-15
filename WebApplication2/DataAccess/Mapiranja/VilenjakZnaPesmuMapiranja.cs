using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakZnaPesmuMapiranja : ClassMap<VilenjakZnaPesmu>
    {
        public VilenjakZnaPesmuMapiranja()
        {
            Table("ZNA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Pesma).Column("ID_PES").LazyLoad();
            References(x => x.VilenjakIrvasi).Column("ID_VIL").LazyLoad();
        }

    }
}
