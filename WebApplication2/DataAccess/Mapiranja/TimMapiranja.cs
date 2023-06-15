using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class TimMapiranja : ClassMap<Tim>
    {
        public TimMapiranja()
        {
            Table("TIM");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();            

            //mapiranje svojstava

            //1:1 da li ovako
            References(x => x.Koordinator).Column("ID_KOORD").LazyLoad();

            HasMany(x => x.ClanoviTima).KeyColumn("ID_TIM").LazyLoad().Cascade.All().Inverse();
        }
    }
}
