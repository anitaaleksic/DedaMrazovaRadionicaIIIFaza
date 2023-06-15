using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using DedaMraz.Entiteti;
namespace DedaMraz.Mapiranja
{
    public class MagicnaVestinaMapiranja : ClassMap<MagicnaVestina>
    {
        public MagicnaVestinaMapiranja()
        {
            Table("MAGICNA_VESTINA");

            Id(x => x.ID, "NAZIV");

            //Map(x => x.Naziv, "NAZIV");

            //mapiranje svojstava.

            //DA LI OVAKO INVERSE
            /*HasManyToMany(x => x.ImajuVilenjaci)
                .Table("IMA")
                .ParentKeyColumn("NAZIV_VESTINE")
                .ChildKeyColumn("VIL_ID")
                .Cascade.All()
                .Inverse();*/

            /*HasManyToMany(x => x.PosedujuVilenjaci)
                .Table("POSEDUJE")
                .ParentKeyColumn("NAZIV_VES")
                .ChildKeyColumn("VILENJAK_ID")
                .Cascade.All()
                .Inverse();*/


            /*HasManyToMany(x => x.ZahtevanaZaRadionice)
                .Table("ZAHTEVA")
                .ParentKeyColumn("NAZIV_V")
                .ChildKeyColumn("RADIONICA_ID")
                .Cascade.All()
                .Inverse();*/

            //N:M

            HasMany(x => x.Zahteva).KeyColumn("NAZIV_V").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.VilenjakImaVestinu).KeyColumn("NAZIV_VESTINE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.VilenjakPosedujeVestinu).KeyColumn("NAZIV_VES").LazyLoad().Cascade.All().Inverse();
        }
    }
}