using DedaMraz.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DedaMraz.Mapiranja
{
    public class VilenjakTovarMapiranja : SubclassMap<VilenjakTovar>
    {
        public VilenjakTovarMapiranja()
        {
            Table("VILENJAK_TOVAR");

            
            Abstract();


            References(x => x.PripremioTovar).Column("TOVAR_SIFRA").LazyLoad();
        }
    }
}
