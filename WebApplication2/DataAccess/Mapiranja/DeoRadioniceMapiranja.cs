using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class DeoRadioniceMapiranja : ClassMap<DeoRadionice>
    {
        DeoRadioniceMapiranja()
        {
            Table("DEO_RADIONICE");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.BrojVilenjaka, "BROJ_VILENJAKA");
            Map(x => x.TipIgracaka, "TIP_IGRACAKA");

            //1:1 da li ovako
            References(x => x.Sef).Column("ID_SEFA").LazyLoad();

            HasMany(x => x.RasporedjeniVilenjaci).KeyColumn("ID_RAD").LazyLoad().Cascade.All().Inverse();

            /*HasManyToMany(x => x.ZahtevaneVestine)
                .Table("ZAHTEVA")
                .ParentKeyColumn("RADIONICA_ID")
                .ChildKeyColumn("NAZIV_V")
                .Cascade.All();*/

            //m:n
            HasMany(x => x.Zahteva).KeyColumn("RADIONICA_ID").LazyLoad().Cascade.All().Inverse();//dodato inverse
        }
    }
}
