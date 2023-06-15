using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class PismoMapiranja : ClassMap<Pismo>
    {
        public PismoMapiranja()
        {
            Table("PISMO");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.DatumSlanja, "DATUM_SLANJA");
            Map(x => x.DatumPrijema, "DATUM_PRIJEMA");
            Map(x => x.IndeksDobrote, "INDEKS_DOBROTE");
            Map(x => x.Tekst, "TEKST");

            References(x => x.PoslaloDete).Column("ID_DETE").LazyLoad();

            HasMany(x => x.SadrziZelje).KeyColumn("ID_PISMA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
