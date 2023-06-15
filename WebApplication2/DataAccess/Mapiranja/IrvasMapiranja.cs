using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class IrvasMapiranja : ClassMap<Irvas>
    {
        public IrvasMapiranja()
        {
            Table("IRVAS");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Ime, "IME");
            Map(x => x.Nadimak, "NADIMAK");
            Map(x => x.Pol, "POL");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");

            HasMany(x => x.ZaduzeniVilenjaci).KeyColumn("ID_IRVAS").LazyLoad().Cascade.All().Inverse();

            //N:M

            HasMany(x => x.IrvasIsporucujeTovar).KeyColumn("ID_IRV").LazyLoad().Cascade.All().Inverse();

            /*HasManyToMany(x => x.IsporucujeTovare)
                .Table("ISPORUCUJE")
                .ParentKeyColumn("ID_IRV")
                .ChildKeyColumn("SIFRA_T")
                .Cascade.All().Inverse();*/
               

        }
    }
}
