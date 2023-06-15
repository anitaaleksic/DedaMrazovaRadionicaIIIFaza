//using DedaMraz.Entiteti;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DedaMraz
//{

//    #region DeoRadionice

//    public class DeoRadioniceBasic
//    {
//        public int ID { get; set; }
//        public string Naziv { get ; set; }
//        public int BrojVilenjaka { get; set; }
//        public string TipIgracaka { get; set; }
//        public DateTime DatumPostavljanja { get; set; }
//        public VilenjakIgrackeBasic Sef { get; set; }
//        public virtual IList<VilenjakIgrackeBasic> RasporedjeniVilenjaci { get; set; }
//        public IList<MagicnaVestinaBasic> ZahtevaneVestine;
//        public DeoRadioniceBasic()
//        {
//            RasporedjeniVilenjaci = new List<VilenjakIgrackeBasic>();
//            ZahtevaneVestine = new List<MagicnaVestinaBasic>();
//        }
//        public DeoRadioniceBasic(int id, string naziv, int brojVilenjaka, string tipIgracaka, DateTime datumPostavljanja, VilenjakIgrackeBasic sef)
//        {
//            this.ID = id;
//            this.Naziv = naziv;
//            this.BrojVilenjaka = brojVilenjaka;
//            this.TipIgracaka = tipIgracaka;
//            this.DatumPostavljanja = datumPostavljanja;
//            this.Sef = sef;
//        }

//        public DeoRadioniceBasic(int id, string naziv, int brojVilenjaka, string tipIgracaka, DateTime datumPostavljanja)
//        {
//            this.ID = id;
//            this.Naziv = naziv;
//            this.BrojVilenjaka = brojVilenjaka;
//            this.TipIgracaka = tipIgracaka;
//            this.DatumPostavljanja = datumPostavljanja;
//        }
//    }
//    public class DeoRadionicePregled
//    {
//        public override string ToString()
//        {
//            return $"{ID} - {Naziv}";
//        }
//        public int ID { get; set; }
//        public string Naziv { get; set; }
//        public int BrojVilenjaka { get; set; }
//        public string TipIgracaka { get; set; }
//        public VilenjakIgrackeBasic Sef { get; set; }

//        //public DeoRadionicePregled() { }
//        public DeoRadionicePregled(int id, string naziv, int brojVilenjaka, string tipIgracaka, VilenjakIgrackeBasic sef)
//        {
//            this.ID = id;
//            this.Naziv = naziv;
//            this.BrojVilenjaka = brojVilenjaka;
//            this.TipIgracaka = tipIgracaka;
//            this.Sef = sef;
//        }
//    }



    

//    #endregion

//    #region Dete
//    public class DeteBasic
//    {
//        public int ID;
//        public string Ime;
//        public string Prezime;
//        public DateTime DatumRodjenja;
//        public string Drzava;
//        public string Grad;
//        public string Adresa;
//        public string ImeMajke;
//        public string ImeOca;

//        public virtual IList<PismoBasic> SaljePisma { get; set; }

//        public DeteBasic()
//        {
//            SaljePisma = new List<PismoBasic>();
//        }
//        public DeteBasic(int iD, string ime, string prezime, DateTime datumRodjenja, string drzava, string grad, string adresa, string imeMajke, string imeOca)
//        {
//            ID = iD;
//            Ime = ime;
//            Prezime = prezime;
//            DatumRodjenja = datumRodjenja;
//            Drzava = drzava;
//            Grad = grad;
//            Adresa = adresa;
//            ImeMajke = imeMajke;
//            ImeOca = imeOca;
//        }

//        public override string ToString()
//        {
//            return Ime + " " + Prezime;
//        }
//    }

//    public class DetePregled
//    {
//        public override string ToString()
//        {
//            return Ime;
//        }
//        public int ID;
//        public string Ime;
//        public string Prezime;
//        public DateTime DatumRodjenja;
//        public string Drzava;
//        public string Grad;
//        public string Adresa;

//        public DetePregled() { }
//        public DetePregled(int iD, string ime, string prezime, DateTime datumRodjenja, string drzava, string grad, string adresa)
//        {
//            ID = iD;
//            Ime = ime;
//            Prezime = prezime;
//            DatumRodjenja = datumRodjenja;
//            Drzava = drzava;
//            Grad = grad;
//            Adresa = adresa;
//        }
//    }


    
//    #endregion

//    #region Igracka

//    public class IgrackaBasic
//    {
//        public virtual int ID { get; set; }
//        public virtual int RedniBroj { get; set; }
//        public virtual string Tip { get; set; }
//        public virtual string Opis { get; set; }
//        public virtual PoklonBasic SpakovanaUPoklon { get; set; }
//        public virtual VilenjakIgrackeBasic IzradioJeVilenjak { get; set; }

//        public IgrackaBasic() { }

//        public IgrackaBasic(int iD, int redniBroj, string tip, string opis, PoklonBasic spakovanaUPoklon, VilenjakIgrackeBasic izradioJeVilenjak)
//        {
//            this.ID = iD;
//            this.RedniBroj = redniBroj;
//            this.Tip = tip;
//            this.Opis = opis;
//            this.SpakovanaUPoklon = spakovanaUPoklon;
//            this.IzradioJeVilenjak = izradioJeVilenjak;
//        }
//        public IgrackaBasic(int iD, int redniBroj, string tip, string opis)
//        {
//            this.ID = iD;
//            this.RedniBroj = redniBroj;
//            this.Tip = tip;
//            this.Opis = opis;
//        }
//    }
//    public class IgrackaPregled
//    {
//        public virtual int ID { get; set; }
//        public virtual int RedniBroj { get; set; }
//        public virtual string Tip { get; set; }
//        public virtual string Opis { get; set; }
//        public virtual PoklonBasic SpakovanaUPoklon { get; set; }
//        public virtual VilenjakIgrackeBasic IzradioJeVilenjak { get; set; }

//        public IgrackaPregled() { }

//        public IgrackaPregled(int iD, int redniBroj, string tip, string opis, PoklonBasic spakovanaUPoklon, VilenjakIgrackeBasic izradioJeVilenjak)
//        {
//            this.ID = iD;
//            this.RedniBroj = redniBroj;
//            this.Tip = tip;
//            this.Opis = opis;
//            this.SpakovanaUPoklon = spakovanaUPoklon;
//            this.IzradioJeVilenjak = izradioJeVilenjak;
//        }
//        public IgrackaPregled(int iD, int redniBroj, string tip, string opis)
//        {
//            this.ID = iD;
//            this.RedniBroj = redniBroj;
//            this.Tip = tip;
//            this.Opis = opis;
//        }
//    }


    

//    #endregion

//    #region Irvas

//    public class IrvasBasic
//    {
//        public int ID;
//        public string Ime;
//        public string Nadimak;
//        public char Pol;
//        public DateTime DatumRodjenja;

//        public virtual IList<VilenjakIrvasiBasic> ZaduzeniVilenjaci { get; set; }
//        public virtual IList<TovarBasic> IsporucujeTovare { get; set; }

//        public IrvasBasic()
//        {
//            ZaduzeniVilenjaci = new List<VilenjakIrvasiBasic>();
//            IsporucujeTovare = new List<TovarBasic>();
//        }
//        public IrvasBasic(int iD, string ime, string nadimak, char pol, DateTime datumRodjenja)
//        {
//            ID = iD;
//            Ime = ime;
//            Nadimak = nadimak;
//            Pol = pol;
//            DatumRodjenja = datumRodjenja;
//        }
//    }

//    public class IrvasPregled
//    {
//        public override string ToString()
//        {
//            return Ime;
//        }
//        public int ID;
//        public string Ime;
//        public string Nadimak;
//        public char Pol;
//        public DateTime DatumRodjenja;
//        public IrvasPregled() { }
//        public IrvasPregled(int iD, string ime, string nadimak, char pol, DateTime datumRodjenja)
//        {
//            ID = iD;
//            Ime = ime;
//            Nadimak = nadimak;
//            Pol = pol;
//            DatumRodjenja = datumRodjenja;
//        }
//    }

    

//    #endregion

//    #region MagicnaVestina

//    public class MagicnaVestinaBasic
//    {
//        public string ID;
//        public IList<VilenjakIrvasiBasic> ImajuVilenjaci;
//        public IList<VilenjakIgrackeBasic> PosedujuVilenjaci;
//        public IList<DeoRadioniceBasic> ZahtevanaZaRadionice;
//        public MagicnaVestinaBasic()
//        {
//            ImajuVilenjaci = new List<VilenjakIrvasiBasic>();
//            PosedujuVilenjaci = new List<VilenjakIgrackeBasic>();
//            ZahtevanaZaRadionice = new List<DeoRadioniceBasic>();
//        }
//        public MagicnaVestinaBasic(string ID)
//        {
//            this.ID = ID;
//        }
//    }

//    public class MagicnaVestinaPregled
//    {
//        public string ID;
//        public MagicnaVestinaPregled() { }
//        public MagicnaVestinaPregled(string iD)
//        {
//            this.ID = iD;
//        }
//    }

//    /*public class MagicnaVestinaView
//    {
//        public string ID;
//        public IList<VilenjakIrvasiView> ImajuVilenjaci;
//        public IList<VilenjakIgrackeView> PosedujuVilenjaci;
//        public IList<DeoRadioniceView> ZahtevanaZaRadionice;
//        public MagicnaVestinaView()
//        {
//            ImajuVilenjaci = new List<VilenjakIrvasiView>();
//            PosedujuVilenjaci = new List<VilenjakIgrackeView>();
//            ZahtevanaZaRadionice = new List<DeoRadioniceView>();
//        }
//        public MagicnaVestinaView(string ID)
//        {
//            this.ID = ID;
//        }
//    }*/
//    #endregion

//    #region Pesma

//    public class PesmaBasic
//    {
//        public int ID;
//        public string Naziv;
//        public string Tekst;

//        public virtual IList<VilenjakIrvasiBasic> ZnajuVilenjaci { get; set; }

//        public PesmaBasic()
//        {
//            ZnajuVilenjaci = new List<VilenjakIrvasiBasic>();
//        }
//        public PesmaBasic(int iD, string naziv, string tekst)
//        {
//            ID = iD;
//            Naziv = naziv;
//            Tekst = tekst;
//        }
//    }

//    public class PesmaPregled
//    {
//        public int ID;
//        public string Naziv;
//        public PesmaPregled() { }
//        public PesmaPregled(int iD, string naziv)
//        {
//            ID = iD;
//            Naziv = naziv;
//        }
//    }


//    /*public class PesmaView
//    {
//        public int ID;
//        public string Naziv;
//        public string Tekst;

//        public virtual IList<VilenjakIrvasiView> ZnajuVilenjaci { get; set; }

//        public PesmaView()
//        {
//            ZnajuVilenjaci = new List<VilenjakIrvasiView>();
//        }
//        public PesmaView(Pesma pesma)
//        {
//            ID = pesma.ID;
//            Naziv = pesma.Naziv;
//            Tekst = pesma.Tekst;
//        }
//    }*/
//    #endregion

//    #region Pismo

//    public class PismoBasic
//    {
//        public virtual int ID { get; set; }
//        public virtual DateTime DatumSlanja { get; set; }
//        public virtual DateTime DatumPrijema { get; set; }
//        public virtual float IndeksDobrote { get; set; }
//        public virtual string Tekst { get; set; }
//        public virtual DeteBasic PoslaloDete { get; set; }
//        public virtual IList<ZeljaBasic> SadrziZelje { get; set; }

//        public PismoBasic()
//        {
//            SadrziZelje = new List<ZeljaBasic>();
//        }
//        public PismoBasic(int iD, DateTime datumSlanja, DateTime datumPrijema, float indeksDobrote, string tekst, DeteBasic poslaloDete)
//        {
//            ID = iD;
//            DatumSlanja = datumSlanja;
//            DatumPrijema = datumPrijema;
//            IndeksDobrote = indeksDobrote;
//            Tekst = tekst;
//            PoslaloDete = poslaloDete;
//        }
//        public PismoBasic(int iD, DateTime datumSlanja, DateTime datumPrijema, float indeksDobrote, string tekst)
//        {
//            ID = iD;
//            DatumSlanja = datumSlanja;
//            DatumPrijema = datumPrijema;
//            IndeksDobrote = indeksDobrote;
//            Tekst = tekst;
//        }
//    }

//    public class PismoPregled
//    {
//        public virtual int ID { get; set; }
//        public virtual DateTime DatumSlanja { get; set; }
//        public virtual DateTime DatumPrijema { get; set; }
//        public virtual float IndeksDobrote { get; set; }
//        public virtual string Tekst { get; set; }
//        public virtual DeteBasic PoslaloDete { get; set; }

//        public PismoPregled() { }
//        public PismoPregled(int iD, DateTime datumSlanja, DateTime datumPrijema, float indeksDobrote, string tekst, DeteBasic poslaloDete)
//        {
//            ID = iD;
//            DatumSlanja = datumSlanja;
//            DatumPrijema = datumPrijema;
//            IndeksDobrote = indeksDobrote;
//            Tekst = tekst;
//            PoslaloDete = poslaloDete;
//        }
//        public PismoPregled(int iD, DateTime datumSlanja, DateTime datumPrijema, float indeksDobrote, string tekst)
//        {
//            ID = iD;
//            DatumSlanja = datumSlanja;
//            DatumPrijema = datumPrijema;
//            IndeksDobrote = indeksDobrote;
//            Tekst = tekst;
//        }
//    }

//   /* public class PismoView
//    {
//        public virtual int ID { get; set; }
//        public virtual DateTime DatumSlanja { get; set; }
//        public virtual DateTime DatumPrijema { get; set; }
//        public virtual float IndeksDobrote { get; set; }
//        public virtual string Tekst { get; set; }
//        public virtual DeteView PoslaloDete { get; set; }
//        public virtual IList<ZeljaView> SadrziZelje { get; set; }

//        public PismoView()
//        {
//            SadrziZelje = new List<ZeljaView>();
//        }
//        public PismoView(Pismo pismo)
//        {
//            ID = pismo.ID;
//            DatumSlanja = pismo.DatumSlanja;
//            DatumPrijema = pismo.DatumPrijema;
//            IndeksDobrote = pismo.IndeksDobrote;
//            Tekst = pismo.Tekst;
//            // PoslaloDete = pismo.PoslaloDete;
//        }

//    }*/



//    #endregion

//    #region Poklon

//    public class PoklonBasic
//    {
//        public override string ToString()
//        {
//            return $"{ID}";
//        }
//        public virtual int ID { get; set; }
//        public virtual string Boja { get; set; }
//        public virtual string Posveta { get; set; }

//        public virtual IList<ZeljaBasic> SeOdnosiNaZelje { get; set; }
//        public virtual IList<IgrackaBasic> SpakovaneIgracke { get; set; }
//        public virtual TovarBasic SeNalaziUTovaru { get; set; }

//        public virtual IList<VilenjakPokloniBasic> PakovaliVilenjaci { get; set; }

//        public PoklonBasic()
//        {
//            SeOdnosiNaZelje = new List<ZeljaBasic>();
//            SpakovaneIgracke = new List<IgrackaBasic>();
//            PakovaliVilenjaci = new List<VilenjakPokloniBasic>();
//        }

//        public PoklonBasic(int iD, string boja, string posveta, TovarBasic seNalaziUTovaru)
//        {
//            ID = iD;
//            Boja = boja;
//            Posveta = posveta;
//            SeNalaziUTovaru = seNalaziUTovaru;
//        }
//        public PoklonBasic(int iD, string boja, string posveta)
//        {
//            ID = iD;
//            Boja = boja;
//            Posveta = posveta;
//        }
//    }

//    public class PoklonPregled
//    {
//        public virtual int ID { get; set; }
//        public virtual string Boja { get; set; }
//        public virtual string Posveta { get; set; }
//        public virtual TovarBasic SeNalaziUTovaru { get; set; }

//        public PoklonPregled() { }

//        public PoklonPregled(int iD, string boja, string posveta, TovarBasic seNalaziUTovaru)
//        {
//            ID = iD;
//            Boja = boja;
//            Posveta = posveta;
//            SeNalaziUTovaru = seNalaziUTovaru;
//        }
//        public PoklonPregled(int iD, string boja, string posveta)
//        {
//            ID = iD;
//            Boja = boja;
//            Posveta = posveta;
//        }
//    }

//    #endregion

//    #region Tim

//    public class TimBasic
//    {
//        public virtual int ID { get; set; }
//        public virtual VilenjakIgrackeBasic Koordinator { get; set; }

//        public virtual IList<VilenjakIgrackeBasic> ClanoviTima { get; set; }

//        public TimBasic()
//        {
//            ClanoviTima = new List<VilenjakIgrackeBasic>();
//        }
//        public TimBasic(int iD, VilenjakIgrackeBasic koordinator)
//        {
//            ID = iD;
//            Koordinator = koordinator;
//        }
//    }

//    public class TimPregled
//    {
//        public override string ToString()
//        {
//            return ID.ToString();
//        }
//        public virtual int ID { get; set; }
//        public virtual VilenjakIgrackeBasic Koordinator { get; set; }

//        public TimPregled() { }
//        public TimPregled(int iD, VilenjakIgrackeBasic koordinator)
//        {
//            ID = iD;
//            Koordinator = koordinator;
//        }
//        public TimPregled(int iD)
//        {
//            ID = iD;
//        }
//    }

//    #endregion

//    #region Tovar

//    public class TovarBasic
//    {
//        public int ID;
//        public string Grad;

//        public virtual IList<PoklonBasic> PokloniUTovaru { get; set; }
//        public virtual IList<VilenjakIgrackeBasic> PakovaliVilenjaci { get; set; }
//        public virtual IList<IrvasBasic> IsporucujuIrvasi { get; set; }

//        public TovarBasic()
//        {
//            PokloniUTovaru = new List<PoklonBasic>();
//            PakovaliVilenjaci = new List<VilenjakIgrackeBasic>();
//            IsporucujuIrvasi = new List<IrvasBasic>();
//        }

//        public TovarBasic(int iD, string grad)
//        {
//            ID = iD;
//            Grad = grad;
//        }
//    }

//    public class TovarPregled
//    {
//        public override string ToString()
//        {
//            return ID.ToString();
//        }
//        public int ID;
//        public string Grad;

//        public TovarPregled() { }

//        public TovarPregled(int iD, string grad)
//        {
//            ID = iD;
//            Grad = grad;
//        }
//    }

//    #endregion

//    #region Vilenjaci
    
//    #region Vilenjak

//    public class VilenjakBasic
//    {
//        public virtual int ID { get; protected set; }
//        public virtual string Ime { get; set; }
//        public virtual string ZemljaPorekla { get; set; }
//        public virtual string RadniStaz { get; set; }

//        public VilenjakBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz)
//        {
//            this.ID = ID;
//            this.Ime = Ime;
//            this.ZemljaPorekla = ZemljaPorekla;
//            this.RadniStaz = RadniStaz;
//        }
//        public VilenjakBasic() { }
//    }
//    public class VilenjakPregled
//    {
//        public int ID { get; set; }
//        public string Ime { get; set; }
//        public virtual string ZemljaPorekla { get; set; }
//        public virtual string RadniStaz { get; set; }

//        public VilenjakPregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz)
//        {
//            this.ID = ID;
//            this.Ime = Ime;
//            this.RadniStaz = RadniStaz;
//            this.ZemljaPorekla = ZemljaPorekla;
//        }

//        public VilenjakPregled() { }
//    }
//    #endregion

//    #region VilenjakIgracke
//    public class VilenjakIgrackeBasic : VilenjakBasic
//    {
//        public override string ToString()
//        {
//            return $"{ID} - {Ime}";
//        }
//        public virtual float Ocena { get; set; }
//        public virtual string TrajanjeObuke { get; set; }
//        public virtual string SpecijalizovanZa { get; set; }
//        public virtual string Sef { get; set; }
//        public virtual string Mentor { get; set; }
//        public virtual string Koordinator { get; set; }
//        public virtual IList<IgrackaBasic> IzradjeneIgracke { get; set; }

//        public DeoRadioniceBasic RasporedjenURadionicu;

//        public virtual DeoRadioniceBasic JeSef { get; set; }

//        public VilenjakIgrackeBasic IDMentor;

//        public IList<VilenjakIgrackeBasic> ObucavaniVilenjaci;
//        public virtual IList<MagicnaVestinaBasic> PosedujeVestine { get; set; }

//        public virtual TimBasic Tim { get; set; }

//        public VilenjakIgrackeBasic()
//        {
//            IzradjeneIgracke = new List<IgrackaBasic>();
//            ObucavaniVilenjaci = new List<VilenjakIgrackeBasic>();
//            PosedujeVestine = new List<MagicnaVestinaBasic>();
//        }
//        public VilenjakIgrackeBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz, float ocena, string trajanjeObuke, string specijalizovanZa, string sef, string mentor, string koordinator, DeoRadioniceBasic rasporedjenURadionicu, VilenjakIgrackeBasic iDMentor, TimBasic tim) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            this.Ocena = ocena;
//            this.TrajanjeObuke = trajanjeObuke;
//            this.SpecijalizovanZa = specijalizovanZa;
//            this.Sef = sef;
//            this.Mentor = mentor;
//            this.Koordinator = koordinator;
//            this.RasporedjenURadionicu = rasporedjenURadionicu;
//            this.IDMentor = iDMentor;
//            this.Tim = tim;
//        }
//        public VilenjakIgrackeBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz, float ocena, string trajanjeObuke, string specijalizovanZa, string sef, string mentor, string koordinator) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            this.Ocena = ocena;
//            this.TrajanjeObuke = trajanjeObuke;
//            this.SpecijalizovanZa = specijalizovanZa;
//            this.Sef = sef;
//            this.Mentor = mentor;
//            this.Koordinator = koordinator;
//        }
//    }
//    public class VilenjakIgrackePregled : VilenjakPregled
//    {
//        public virtual float Ocena { get; set; }
//        public virtual string TrajanjeObuke { get; set; }
//        public virtual string SpecijalizovanZa { get; set; }
//        public virtual string Sef { get; set; }
//        public virtual string Mentor { get; set; }
//        public virtual string Koordinator { get; set; }

//        public DeoRadioniceBasic RasporedjenURadionicu;

//        public VilenjakIgrackeBasic IDMentor;

//        public virtual TimBasic Tim { get; set; }


//        public VilenjakIgrackePregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz, float ocena, string trajanjeObuke, string specijalizovanZa, string sef, string mentor, string koordinator, DeoRadioniceBasic rasporedjenURadionicu, VilenjakIgrackeBasic iDMentor, TimBasic tim) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            Ocena = ocena;
//            TrajanjeObuke = trajanjeObuke;
//            SpecijalizovanZa = specijalizovanZa;
//            Sef = sef;
//            Mentor = mentor;
//            Koordinator = koordinator;
//            RasporedjenURadionicu = rasporedjenURadionicu;
//            IDMentor = iDMentor;
//            Tim = tim;
//        }
//        public VilenjakIgrackePregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz, float ocena, string trajanjeObuke, string specijalizovanZa, string sef, string mentor, string koordinator) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            Ocena = ocena;
//            TrajanjeObuke = trajanjeObuke;
//            SpecijalizovanZa = specijalizovanZa;
//            Sef = sef;
//            Mentor = mentor;
//            Koordinator = koordinator;
//        }
//        public VilenjakIgrackePregled() { }

//    }
//    #endregion

//    #region VilenjakIrvasi
//    public class VilenjakIrvasiBasic : VilenjakBasic
//    {
//        public virtual IrvasBasic ZaduzenZaIrvasa { get; set; }
//        public virtual IList<PesmaBasic> ZnaPesme { get; set; }
//        public virtual IList<MagicnaVestinaBasic> ImajuVestine { get; set; }

//        public VilenjakIrvasiBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz, IrvasBasic ZaduzenZaIrvasa) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            this.ZaduzenZaIrvasa = ZaduzenZaIrvasa;
//        }
//        public VilenjakIrvasiBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz) : base(ID, Ime, ZemljaPorekla, RadniStaz) { }
//        public VilenjakIrvasiBasic()
//        {
//            ZnaPesme = new List<PesmaBasic>();
//            ImajuVestine = new List<MagicnaVestinaBasic>();
//        }
//    }
//    public class VilenjakIrvasiPregled : VilenjakPregled
//    {
//        public virtual IrvasBasic ZaduzenZaIrvasa { get; set; }

//        public VilenjakIrvasiPregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz, IrvasBasic ZaduzenZaIrvasa) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            this.ZaduzenZaIrvasa = ZaduzenZaIrvasa;
//        }
//        public VilenjakIrvasiPregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz) : base(ID, Ime, ZemljaPorekla, RadniStaz) { }
//        public VilenjakIrvasiPregled() { }
//    }
//    #endregion

//    #region VilenjakPokloni
//    public class VilenjakPokloniBasic : VilenjakBasic
//    {
//        public override string ToString()
//        {
//            return $"{Ime}";
//        }
//        public virtual IList<PoklonBasic> SpakovaoPoklone { get; set; }
//        public VilenjakPokloniBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz) : base(ID, Ime, ZemljaPorekla, RadniStaz) { }
//        public VilenjakPokloniBasic()
//        {
//            SpakovaoPoklone = new List<PoklonBasic>();
//        }
//    }

//    public class VilenjakPokloniPregled : VilenjakPregled
//    {
//        public override string ToString()
//        {
//            return $"{Ime}";
//        }
//        public VilenjakPokloniPregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz) : base(ID, Ime, ZemljaPorekla, RadniStaz) { }

//        public VilenjakPokloniPregled() { }
//    }
//    #endregion

//    #region VilenjakTovar
//    public class VilenjakTovarBasic : VilenjakBasic
//    {
//        public virtual TovarBasic PripremioTovar { get; set; }

//        public VilenjakTovarBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz, TovarBasic PripremioTovar) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            this.PripremioTovar = PripremioTovar;
//        }
//        public VilenjakTovarBasic(int ID, string Ime, string ZemljaPorekla, string RadniStaz) : base(ID, Ime, ZemljaPorekla, RadniStaz) { }
//        public VilenjakTovarBasic() { }
//    }
//    public class VilenjakTovarPregled : VilenjakPregled
//    {
//        public virtual TovarBasic PripremioTovar { get; set; }
//        public VilenjakTovarPregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz, TovarBasic PripremioTovar) : base(ID, Ime, ZemljaPorekla, RadniStaz)
//        {
//            this.PripremioTovar = PripremioTovar;
//        }
//        public VilenjakTovarPregled(int ID, string Ime, string ZemljaPorekla, string RadniStaz) : base(ID, Ime, ZemljaPorekla, RadniStaz) { }
//        public VilenjakTovarPregled() { }
//    }

//    #endregion

//    #endregion

//    #region Zelja

//    public class ZeljaBasic
//    {
//        public override string ToString()
//        {
//            return $"{Naziv}";
//        }
//        public virtual int ID { get; set; }

//        public virtual string Naziv { get; set; }

//        public virtual PismoBasic PripadaPismu { get; set; }

//        public virtual PoklonBasic SeOdnosiNaPoklon { get; set; }
//        public virtual IgrackaBasic IDIgracke { get; set; }

//        public ZeljaBasic() { }

//        public ZeljaBasic(int iD, string naziv, PismoBasic pripadaPismu, PoklonBasic seOdnosiNaPoklon, IgrackaBasic iDIgracke)
//        {
//            ID = iD;
//            Naziv = naziv;
//            PripadaPismu = pripadaPismu;
//            SeOdnosiNaPoklon = seOdnosiNaPoklon;
//            IDIgracke = iDIgracke;
//        }
//        public ZeljaBasic(int iD)
//        {
//            ID = iD;
//        }
//    }

//    public class ZeljaPregled
//    {
//        public virtual int ID { get; set; }

//        public virtual string Naziv { get; set; }

//        public virtual PismoBasic PripadaPismu { get; set; }

//        public virtual PoklonBasic SeOdnosiNaPoklon { get; set; }
//        public virtual IgrackaBasic IDIgracke { get; set; }

//        public ZeljaPregled() { }

//        public ZeljaPregled(int iD, string naziv, PismoBasic pripadaPismu, PoklonBasic seOdnosiNaPoklon, IgrackaBasic iDIgracke)
//        {
//            ID = iD;
//            Naziv = naziv;
//            PripadaPismu = pripadaPismu;
//            SeOdnosiNaPoklon = seOdnosiNaPoklon;
//            IDIgracke = iDIgracke;
//        }
//        public ZeljaPregled(int iD)
//        {
//            ID = iD;
//        }
//    }

//    #endregion

//    #region Zahteva
//    public class ZahtevaBasic
//    {
//        public virtual int ID { get; set; }
//        public virtual DeoRadionice DeoRadionice { get; set; }
//        public virtual MagicnaVestina MagicnaVestina { get; set; }
//        public ZahtevaBasic() { }

//        public ZahtevaBasic(int id) { ID = id; }
//    }

//    public class ZahtevaPregled
//    {
//        public virtual int ID { get; set; }
//        public virtual DeoRadionice DeoRadionice { get; set; }
//        public virtual MagicnaVestina MagicnaVestina { get; set; }
//        public ZahtevaPregled() { }

//        public ZahtevaPregled(int id) { ID = id; }
//    }
//    #endregion

//    #region Zna
//    public class VilenjakZnaPesmuBasic
//    {
//        public virtual int ID { get; set; }

//        public virtual Pesma Pesma { get; set; }

//        public virtual VilenjakIrvasi VilenjakIrvasi { get; set; }
//        public VilenjakZnaPesmuBasic() { }
//        public VilenjakZnaPesmuBasic(int id) { ID = id; }

//    }
//    public class VilenjakZnaPesmuPregled 
//    {
//        public virtual int ID { get; set; }

//        public virtual Pesma Pesma { get; set; }

//        public virtual VilenjakIrvasi VilenjakIrvasi { get; set; }
//        public VilenjakZnaPesmuPregled() { }
//        public VilenjakZnaPesmuPregled(int id) { ID = id; }
//    }

//    #endregion
//}
