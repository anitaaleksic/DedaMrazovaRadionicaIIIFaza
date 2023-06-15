using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DedaMraz.Mapiranja
{
    public class VilenjakIgrackeMapiranja : SubclassMap<VilenjakIgracke>
    {
        public VilenjakIgrackeMapiranja()
        {
            Table("VILENJAK_IGRACKE");

            Abstract();

            Map(x => x.Ocena).Column("OCENA");
            Map(x => x.TrajanjeObuke).Column("TRAJANJE_OBUKE");
            Map(x => x.SpecijalizovanZa).Column("SPECIJALIZOVAN_ZA");
            Map(x => x.Sef).Column("SEF");
            Map(x => x.Mentor).Column("MENTOR");
            Map(x => x.Koordinator).Column("KOORDINATOR");

            HasMany(x => x.IzradjeneIgracke).KeyColumn("ID_VILENJAK").LazyLoad().Cascade.All().Inverse();

            References(x => x.RasporedjenURadionicu).Column("ID_RAD").LazyLoad();

            References(x => x.IDMentor).Column("ID_MENT").LazyLoad();

            HasMany(x => x.ObucavaniVilenjaci).KeyColumn("ID_MENT").LazyLoad().Cascade.All().LazyLoad();

            References(x => x.Tim).Column("ID_TIM").LazyLoad();

            /*HasManyToMany(x => x.PosedujeVestine)
               .Table("POSEDUJE")
               .ParentKeyColumn("VILENJAK_ID")
               .ChildKeyColumn("NAZIV_VES")
               .Cascade.All();*/

            //m:n
            HasMany(x => x.VilenjakPosedujeVestinu).KeyColumn("VILENJAK_ID").LazyLoad().Cascade.All().Inverse(); //dodato inverse

            //1:1
            HasOne(x => x.JeSef).PropertyRef(x => x.Sef);

            HasOne(x => x.JeKoordinator).PropertyRef(x => x.Koordinator);
        }
    }
}
