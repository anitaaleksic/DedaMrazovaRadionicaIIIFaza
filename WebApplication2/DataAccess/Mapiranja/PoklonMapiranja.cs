using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class PoklonMapiranja : ClassMap<Poklon>
    {
        PoklonMapiranja()
        {
            Table("POKLON");

            Id(x => x.ID, "SIFRA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Boja, "BOJA");
            Map(x => x.Posveta, "POSVETA");


            HasMany(x => x.SeOdnosiNaZelje).KeyColumn("SIFRA_POK").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.SpakovaneIgracke).KeyColumn("SIFRA_POKLONA").LazyLoad().Cascade.All().Inverse();

            References(x => x.SeNalaziUTovaru).Column("SIFRA_TOV").LazyLoad();

            /*HasManyToMany(x => x.PakovaliVilenjaci)
                .Table("JE_PAKOVAO")
                .ParentKeyColumn("SIFRA_P")
                .ChildKeyColumn("ID_V")
                .Cascade.All();*/

            //n:m

            HasMany(x => x.JePakovao).KeyColumn("SIFRA_P").LazyLoad().Cascade.All().Inverse();//dodato inverse
        }
    }
}
