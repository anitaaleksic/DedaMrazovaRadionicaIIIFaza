using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class IrvasIsporucujeTovarMapiranja : ClassMap<IrvasIsporucujeTovar>
    {
        public IrvasIsporucujeTovarMapiranja()
        {
            Table("ISPORUCUJE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            References(x => x.Tovar).Column("SIFRA_T").LazyLoad();
            References(X => X.Irvas).Column("ID_IRV").LazyLoad();
        }
    }
}
