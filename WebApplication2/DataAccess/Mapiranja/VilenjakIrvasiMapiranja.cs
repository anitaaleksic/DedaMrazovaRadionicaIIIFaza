using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakIrvasiMapiranja : SubclassMap<VilenjakIrvasi>
    {
        public VilenjakIrvasiMapiranja()
        {
            Table("VILENJAK_IRVASI");

            Abstract();

            References(x => x.ZaduzenZaIrvasa).Column("ID_IRVAS").LazyLoad();

            //da li ovde inverse il tamo
            /*HasManyToMany(x => x.ZnaPesme)
                .Table("ZNA")
                .ParentKeyColumn("ID_VIL")
                .ChildKeyColumn("ID_PES")
                .Cascade.All();*/

            //n:m
            HasMany(x => x.VilenjakZnaPesmu).KeyColumn("ID_VIL").LazyLoad().Cascade.All().Inverse();//dodato inverse
            HasMany(x => x.VilenjakImaVestinu).KeyColumn("VIL_ID").LazyLoad().Cascade.All().Inverse();//dodato inverse

            //DA LI OVAKO INVERSE
            /*HasManyToMany(x => x.ImajuVestine)
                .Table("IMA")
                .ParentKeyColumn("VIL_ID")
                .ChildKeyColumn("NAZIV_VESTINE")
                .Cascade.All();*/
        }
    }
}
