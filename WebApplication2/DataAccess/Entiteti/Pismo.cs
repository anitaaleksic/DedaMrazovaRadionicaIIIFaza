using System;
using System.Collections;
using System.Collections.Generic;

namespace DedaMraz.Entiteti
{
    public class Pismo
    {
        public virtual int ID { get; protected set; }
        public virtual DateTime DatumSlanja { get; set; }
        public virtual DateTime DatumPrijema { get; set; }
        public virtual float IndeksDobrote { get; set; }
        public virtual string Tekst { get; set; }

        public virtual Dete PoslaloDete { get; set; }

        public virtual IList<Zelja> SadrziZelje { get; set; }

        public Pismo()
        {
            SadrziZelje = new List<Zelja>();
        }
    }
}