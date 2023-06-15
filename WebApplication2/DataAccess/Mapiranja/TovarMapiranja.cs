using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class TovarMapiranja : ClassMap<Tovar>
    {
        public TovarMapiranja()
        {
            Table("TOVAR");

            Id(x => x.ID, "SIFRA").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Grad, "GRAD");

            HasMany(x => x.PokloniUTovaru).KeyColumn("SIFRA_TOV").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.PakovaliVilenjaci).KeyColumn("TOVAR_SIFRA").LazyLoad().Cascade.All().Inverse();

            //N:M

            HasMany(x => x.IrvasIsporucujeTovar).KeyColumn("SIFRA_T").LazyLoad().Cascade.All().Inverse();//dodato inverse

            /* HasManyToMany(x => x.IsporucujuIrvasi)
                 .Table("ISPORUCUJE")
                 .ParentKeyColumn("SIFRA_T")
                 .ChildKeyColumn("ID_IRV")
                 .Cascade.All();*/
        }
    }
}
