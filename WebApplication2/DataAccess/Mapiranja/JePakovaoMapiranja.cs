using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class JePakovaoMapiranja : ClassMap<JePakovao>
    {
        public JePakovaoMapiranja()
        {
            Table("JE_PAKOVAO");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.VilenjakPokloni).Column("ID_V").LazyLoad();
            References(X => X.Poklon).Column("SIFRA_P").LazyLoad();

        }
    }
}
