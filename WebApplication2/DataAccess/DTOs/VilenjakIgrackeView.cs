using DedaMraz;
using DedaMraz.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTOs
{
    public class VilenjakIgrackeView : VilenjakView
    {
        public virtual float Ocena { get; set; }
        public virtual string TrajanjeObuke { get; set; }
        public virtual string SpecijalizovanZa { get; set; }
        public virtual string Sef { get; set; }
        public virtual string Mentor { get; set; }
        public virtual string Koordinator { get; set; }
        public virtual IList<IgrackaView> IzradjeneIgracke { get; set; }

        public DeoRadioniceView RasporedjenURadionicu;

        //public DeoRadioniceView JeSef;

        public VilenjakIgrackeView IDMentor;

        public IList<VilenjakIgrackeView> ObucavaniVilenjaci { get; set; }
        public virtual IList<MagicnaVestinaView> PosedujeVestine { get; set; }

        public TimView Tim;

        public VilenjakIgrackeView()
        {
            IzradjeneIgracke = new List<IgrackaView>();
            ObucavaniVilenjaci = new List<VilenjakIgrackeView>();
            PosedujeVestine = new List<MagicnaVestinaView>();
        }
        public VilenjakIgrackeView(VilenjakIgracke v) : base(v)
        {
            if(v != null)
            {
                this.Ocena = v.Ocena;
                this.TrajanjeObuke = v.TrajanjeObuke;
                this.SpecijalizovanZa = v.SpecijalizovanZa;
                this.Sef = v.Sef;
                this.Mentor = v.Mentor;
                this.Koordinator = v.Koordinator;
                //RasporedjenURadionicu = new DeoRadioniceView(v.RasporedjenURadionicu);
                //IDMentor = new VilenjakIgrackeView(v.IDMentor);
                //Tim = new TimView(v.Tim);
            }
            
        }
        //internal VilenjakIgrackeView(VilenjakIgracke v, DeoRadionice d) : this(v)
        //{
        //    RasporedjenURadionicu = new DeoRadioniceView(d);
        //}
       /* internal VilenjakIgrackeView(VilenjakIgracke v, DeoRadionice d) : this(v)
        {
            JeSef = new DeoRadioniceView(d);
        }*/

        //internal VilenjakIgrackeView(VilenjakIgracke v, VilenjakIgracke vMentor) : this(v)
        //{
        //    IDMentor = new VilenjakIgrackeView(vMentor);
        //}

        //internal VilenjakIgrackeView(VilenjakIgracke v, Tim t)  : this(v)
        //{
        //    Tim = new TimView(t);
        //}
    }
}
