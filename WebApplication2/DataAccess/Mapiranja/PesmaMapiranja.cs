using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class PesmaMapiranja : ClassMap<Pesma>
    {
        PesmaMapiranja()
        {
            Table("PESMA");

            Id(x => x.ID, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava.
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Tekst, "TEKST");

            //da li inverse ovde ili u vilenjaku?
            /*HasManyToMany(x => x.ZnajuVilenjaci)
                .Table("ZNA")
                .ParentKeyColumn("ID_PES")
                .ChildKeyColumn("ID_VIL")
                .Cascade.All()
                .Inverse();*/

            //n:m
            HasMany(x => x.VilenjakZnaPesmu).KeyColumn("ID_PES").LazyLoad().Cascade.All().Inverse();
        }
    }
}
