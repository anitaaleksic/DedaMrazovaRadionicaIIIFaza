using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakPokloniMapiranja : SubclassMap<VilenjakPokloni>
    {
        public VilenjakPokloniMapiranja()
        {
            Table("VILENJAK_POKLONI");

            Abstract();

            /*HasManyToMany(x => x.SpakovaoPoklone)
                .Table("JE_PAKOVAO")
                .ParentKeyColumn("ID_V")
                .ChildKeyColumn("SIFRA_P")
                .Cascade.All()
                .Inverse();*/

            //N:M

            HasMany(x => x.JePakovao).KeyColumn("ID_V").LazyLoad().Cascade.All().Inverse();

        }
    }
}
