using DataAccess.DTOs;
using DedaMraz.Entiteti;
using DedaMrazovaRadionica;
using NHibernate;
using NHibernate.Proxy;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NHibernate.Event.Default;
using System.Web;
using DataAccess;
using Antlr.Runtime.Tree;
using System.Runtime.InteropServices;

namespace DedaMraz
{
    public class DTOManager
    {
        #region DeoRadionice

        public static List<DeoRadioniceView> vratiSveDeloveRadioniceAsync()
        {
            List<DeoRadioniceView> deloviRadionice = new List<DeoRadioniceView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                
                deloviRadionice = s.Query<DeoRadionice>()
                                    .Select(v => new DeoRadioniceView(v)).ToList();


                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih delova radionice: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return deloviRadionice;
        }


        public async static Task<Result<int, string>> DodajDeoRadioniceAsync(DeoRadioniceView dr, int vilenjakID)
        {
            ISession? s = null;
            int id = default;
            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                DeoRadionice o = new DeoRadionice();

                o.Naziv = dr.Naziv;
                o.BrojVilenjaka = dr.BrojVilenjaka;
                o.TipIgracaka = dr.TipIgracaka;

                VilenjakIgracke sef = await s.LoadAsync<VilenjakIgracke>(vilenjakID);

                o.Sef = sef;

                sef.JeSef = o;
                sef.RasporedjenURadionicu = o;
                o.DatumPostavljanja = dr.DatumPostavljanja;
                await s.SaveOrUpdateAsync(o);

                await s.SaveOrUpdateAsync(sef);
                await s.FlushAsync();

                id = o.ID;

                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja dela radionice: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return id;
        }

        public async static Task<Result<bool, string>> azurirajDeoRadioniceAsync(DeoRadioniceView dr, int vilenjakID)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                DeoRadionice o = await s.LoadAsync<DeoRadionice>(dr.ID);
                o.Naziv = dr.Naziv;
                o.BrojVilenjaka = dr.BrojVilenjaka;
                o.TipIgracaka = dr.TipIgracaka;
                VilenjakIgracke sef = await s.LoadAsync<VilenjakIgracke>(vilenjakID);
                o.Sef = sef;
                sef.JeSef = o;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja dela radionice: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return true;
        }
        public async static Task<Result<DeoRadioniceView, string>> vratiDeoRadioniceAsync(int id)
        {
            DeoRadioniceView dr = default!;
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();

                DeoRadionice o = await s.LoadAsync<DeoRadionice>(id);
                dr = new DeoRadioniceView(o);


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja dela radionice: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return dr;
        }
        public async static Task<Result<bool, string>> obrisiDeoRadioniceAsync(int id)
        {
            ISession s = null;

            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                DeoRadionice deoRadionice = await s.LoadAsync<DeoRadionice>(id);


                IEnumerable<Zahteva> z = from o in s.Query<Zahteva>()
                                         where o.DeoRadionice == deoRadionice
                                         select o;
                foreach (Zahteva p in z)
                {
                    s.Delete(p);
                }


                deoRadionice.Sef.RasporedjenURadionicu = null;
                deoRadionice.RasporedjeniVilenjaci.Clear();

                await s.DeleteAsync(deoRadionice);
                await s.FlushAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja dela radionice: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }

            return true;
        }

        #endregion

        #region Dete

        public static async Task<DeteView> vratiDete(int id)
        {

            DeteView de = default;
            try
            {
                ISession s = DataLayer.GetSession();

                Dete d = await s.LoadAsync<Dete>(id);
                de = new DeteView(d);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja deteta: {ec.Message}");
            }

            return de;
        }
        public async static Task<Result<List<DeteView>, string>> vratiSvuDecu()
        {
            List<DeteView> deca = new List<DeteView>();
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();


                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                IEnumerable<Dete> svadeca = from o in s.Query<Dete>()
                                            select o;

                foreach (Dete d in svadeca)
                {
                    deca.Add(new DeteView(d));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja dece: {ec.Message}");
            }
            return deca;
        }
        public async static Task<Result<int, string>> DodajDeteAsync(DeteView d)
        {
            ISession s = null;
            int id = default;
            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Dete o = new Dete();

                o.Ime = d.Ime;
                o.Prezime = d.Prezime;
                o.ImeMajke = d.ImeMajke;
                o.ImeOca = d.ImeOca;
                o.DatumRodjenja = d.DatumRodjenja;
                o.Adresa = d.Adresa;
                o.Drzava = d.Drzava;
                o.Grad = d.Grad;



                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                id = o.ID;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja deteta: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return id;

        }
        public async static Task<Result<bool, string>> AzurirajDeteAsync(DeteView d)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Dete o = await s.LoadAsync<Dete>(d.ID);
                o.Ime = d.Ime;
                o.Adresa = d.Adresa;
                o.ImeMajke = d.ImeMajke;
                o.ImeOca = d.ImeOca;
                o.DatumRodjenja = d.DatumRodjenja;
                o.Drzava = d.Drzava;
                o.Grad = d.Grad;
                o.Prezime = d.Prezime;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja deteta: {ec.Message}");
            }

            return true;
        }
        public async static Task<Result<bool, string>> ObrisiDeteAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Dete d = await s.LoadAsync<Dete>(id);

                foreach (var p in d.SaljePisma)
                {
                    p.PoslaloDete = null;
                }

                await s.FlushAsync();

                await s.DeleteAsync(d);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja deteta: {ec.Message}");
            }
            return true;
        }
        #endregion

        #region Igracka
        public static async Task<Result<List<IgrackaView>, string>> VratiSveIgrackeAsync()
        {
            List<IgrackaView> igracke = new List<IgrackaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                

                IEnumerable<Igracka> sveIgracke = from o in s.Query<Igracka>()
                                                  select o;

                foreach (Igracka i in sveIgracke)
                {
                    igracke.Add(new IgrackaView(i));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih igracaka: {ex.Message}");
            }

            return igracke;
        }

        public async static Task<Result<IgrackaView, string>> vratiIgrackuAsync(int id)
        {
            IgrackaView igracka = default;
            try
            {
                ISession s = DataLayer.GetSession();

                Igracka i = await s.LoadAsync<Igracka>(id);

               
                igracka = new IgrackaView(i);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja igracke: {ex.Message}");
            }
            return igracka;
        }


        public async static Task<Result<int, string>> DodajIgrackuAsync(IgrackaView i, int zeljaID, int vilenjakID, int poklonID)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Igracka igracka = new Igracka();

                igracka.RedniBroj = i.RedniBroj;
                igracka.Opis = i.Opis;
                igracka.Tip = i.Tip;
                VilenjakIgracke vil = await s.LoadAsync<VilenjakIgracke>(vilenjakID);
                Poklon pok = await s.LoadAsync<Poklon>(poklonID);
                Zelja zelja = await s.LoadAsync<Zelja>(zeljaID);
                igracka.SpakovanaUPoklon = pok;
                igracka.IzradioJeVilenjak = vil;
                igracka.PoZelji = zelja;

                await s.SaveOrUpdateAsync(igracka);
                await s.FlushAsync();

                id = igracka.ID;
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja igracke: {ex.Message}");
            }
            return id;
        }
        public async static Task<Result<bool, string>> ObrisiIgrackuAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Igracka i = await s.LoadAsync<Igracka>(id);


                i.PoZelji.IDIgracke = null;

                i.SpakovanaUPoklon.SpakovaneIgracke.Remove(i);

                i.IzradioJeVilenjak.IzradjeneIgracke.Remove(i);

                await s.DeleteAsync(i);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja igracke: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajIgrackuAsync(IgrackaView i)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Igracka o = await s.LoadAsync<Igracka>(i.ID);
                o.Tip = i.Tip;
                o.Opis = i.Opis;
                o.RedniBroj = i.RedniBroj;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja irvasa: {ec.Message}");
            }

            return true;
        }
        #endregion

        #region Irvas
        public async static Task<Result<string, int>> DodajIrvasaAsync(IrvasView i)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Irvas o = new Irvas();

                o.Ime = i.Ime;
                o.Nadimak = i.Nadimak;
                o.Pol = i.Pol;
                o.DatumRodjenja = i.DatumRodjenja;

                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();

                id = o.ID;

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja irvasa: {ec.Message}");
            }
            return id;
        }
        public static List<IrvasView> vratiSveIrvase()
        {
            List<IrvasView> irvasi = new List<IrvasView>();
            try
            {
                ISession s = DataLayer.GetSession();
                

                IEnumerable<Irvas> sviIrvasi = from o in s.Query<Irvas>()
                                               select o;

                foreach (Irvas i in sviIrvasi)
                {
                    irvasi.Add(new IrvasView(i));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja irvasa : {ec.Message}");
            }

            return irvasi;
        }
        public async static Task<Result<bool, string>> ObrisiIrvasaAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Irvas i = await s.LoadAsync<Irvas>(id);

                var vilenjaci = s.Query<VilenjakIrvasi>().Where(v => v.ZaduzenZaIrvasa == i).ToList();

                foreach (VilenjakIrvasi vil in vilenjaci)
                {
                    vil.ZaduzenZaIrvasa = null;
                }

                await s.FlushAsync();

                await s.DeleteAsync(i);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja irvasa: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<IrvasView, string>> VratiIrvasaAsync(int id)
        {
            IrvasView ir = new IrvasView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Irvas o = await s.LoadAsync<Irvas>(id);
                ir = new IrvasView(o);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja irvasa: {ec.Message}");
            }

            return ir;
        }
        public async static Task<Result<bool, string>> AzurirajIrvasaAsync(IrvasView i)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Irvas o = await s.LoadAsync<Irvas>(i.ID);
                o.Ime = i.Ime;
                o.Nadimak = i.Nadimak;
                o.Pol = i.Pol;
                o.DatumRodjenja = i.DatumRodjenja;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja irvasa: {ec.Message}");
            }

            return true;
        }

        #endregion

        #region MagicnaVestina

        public static List<MagicnaVestinaView> VratiSveMagicneVestineZaDeoRadionice(int id)
        {
            List<MagicnaVestinaView> magicneVestine = new List<MagicnaVestinaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zahteva> zahteva = from o in s.Query<Zahteva>()
                                               where o.DeoRadionice.ID == id
                                               select o;
                foreach (Zahteva z in zahteva)
                {
                    magicneVestine.Add(new MagicnaVestinaView(z.MagicnaVestina));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih magicnih vestina: {ex.Message}");
            }
            return magicneVestine;
        }
        public static List<MagicnaVestinaView> VratiSveMagicneVestine()
        {
            List<MagicnaVestinaView> vestine = new List<MagicnaVestinaView>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<MagicnaVestina> sveVestine = from o in s.Query<MagicnaVestina>()
                                                         select o;
                foreach (MagicnaVestina m in sveVestine)
                {

                    vestine.Add(new MagicnaVestinaView(m));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih igracaka: {ex.Message}");
            }

            return vestine;
        }
        public async static Task<Result<MagicnaVestinaView, string>> vratiMagicnuVestinu(int id)
        {
            MagicnaVestinaView magicnaVestina = new MagicnaVestinaView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                MagicnaVestina mv = await s.LoadAsync<MagicnaVestina>(id);
                magicnaVestina = new MagicnaVestinaView(mv);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja magicne vestine: {ex.Message}");
            }
            return magicnaVestina;
        }
        public async static Task DodajMagicnuVestinuASync(MagicnaVestinaView magicnaVestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MagicnaVestina mv = new MagicnaVestina();

                mv.ID = magicnaVestina.ID;

                await s.SaveOrUpdateAsync(mv);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja magicne vestine: {ex.Message}");
            }
        }

        public async static Task<Result<bool, string>> AzurirajMagicnuVestinuAsync(MagicnaVestinaView magicnaVestina)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                MagicnaVestina mv = await s.LoadAsync<MagicnaVestina>(magicnaVestina.ID);

                mv.ID = magicnaVestina.ID;

                await s.SaveOrUpdateAsync(mv);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja magicne vestine: {ex.Message}");
            }
            return true;
        }

        public async static Task<Result<bool, string>> ObrisiMagicnuVestinuAsync(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                MagicnaVestina mv = await s.LoadAsync<MagicnaVestina>(id);

                foreach (var i in mv.VilenjakImaVestinu)
                {
                    await s.DeleteAsync(i);
                }

                foreach (var z in mv.Zahteva)
                {
                    await s.DeleteAsync(z);
                }

                foreach (var p in mv.VilenjakPosedujeVestinu)
                {
                    await s.DeleteAsync(p);
                }

                await s.DeleteAsync(mv);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja magicne vestine: {ex.Message}");
            }
            return true;
        }
        #endregion

        #region Pesma
        public async static Task<Result<PesmaView, string>> VratiPesmuAsync(int id)
        {
            PesmaView pe = new PesmaView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pesma p = await s.LoadAsync<Pesma>(id);
                pe = new PesmaView(p);

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pesme: {ec.Message}");
            }

            return pe;
        }
        public static List<PesmaView> VratiSvePesme()
        {
            List<PesmaView> pesme = new List<PesmaView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Pesma> svepesme = from o in s.Query<Pesma>()
                                              select o;

                foreach (Pesma p in svepesme)
                {
                    pesme.Add(new PesmaView(p));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pesama: {ec.Message}");
            }

            return pesme;
        }
        public async static Task<Result<List<PesmaView>, string>> vratiSvePesmeZaVilenjaka(VilenjakIrvasiView v)
        {
            List<PesmaView> pesme = new List<PesmaView>();
            List<VilenjakZnaPesmuView> zna = new List<VilenjakZnaPesmuView>();

            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakIrvasi vil = await s.LoadAsync<VilenjakIrvasi>(v.ID);

                IEnumerable<VilenjakZnaPesmu> znaPesme = from o in s.Query<VilenjakZnaPesmu>()
                                                         where o.VilenjakIrvasi == vil
                                                         select o;

                foreach (VilenjakZnaPesmu e in znaPesme)
                {
                    pesme.Add(new PesmaView(e.Pesma));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pesama: {ec.Message}");
            }

            return pesme;
        }
        public async static Task<Result<int, string>> DodajPesmuAsync(PesmaView p)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pesma o = new Pesma();
                o.Naziv = p.Naziv;
                o.Tekst = p.Tekst;



                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();

                id = o.ID;

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja pesme {ec.Message}");
            }
            return id;
        }
        public async static Task<Result<bool, string>> ObrisiPesmuAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pesma p = await s.LoadAsync<Pesma>(id);

                await s.DeleteAsync(p);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja pesme: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajPesmuAsync(PesmaView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pesma o = await s.LoadAsync<Pesma>(p.ID);
                o.Naziv = p.Naziv;
                o.Tekst = p.Tekst;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja pesme : {ec.Message}");
            }

            return true;
        }
        #endregion

        #region Pismo
        public static List<PismoView> VratiSvaPisma()
        {
            List<PismoView> pisma = new List<PismoView>();
            try
            {
                ISession session = DataLayer.GetSession();
                IEnumerable<Pismo> svaPisma = from o in session.Query<Pismo>()
                                              select o;

                foreach (Pismo p in svaPisma)
                {
                    pisma.Add(new PismoView(p));
                }
                session.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pisma: {ex.Message}");
            }
            return pisma;
        }

        

        public async static Task<Result<PismoView, string>> VratiPismoAsync(int id)
        {
            PismoView pismo = new PismoView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pismo p = await s.LoadAsync<Pismo>(id);
                pismo = new PismoView(p);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja pisma: {ex.Message}");
            }
            return pismo;
        }

        
        public async static Task<Result<int, string>> PosaljiPismoAsync(PismoView p, int deteID)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pismo o = new Pismo();
                Dete dete = await s.LoadAsync<Dete>(deteID);


                o.IndeksDobrote = p.IndeksDobrote;
                o.Tekst = p.Tekst;
                o.DatumPrijema = p.DatumPrijema;
                o.DatumSlanja = p.DatumSlanja;

                o.PoslaloDete = dete;

                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();
                id = o.ID;

                s.Close();                
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja pisma: {ec.Message}");
            }
            return id;
        }
        
        public async static Task<Result<bool, string>> ObrisiPismoAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pismo i = await s.LoadAsync<Pismo>(id);


                i.PoslaloDete.SaljePisma.Remove(i);

                foreach (var z in i.SadrziZelje)
                {
                    await DTOManager.ObrisiZeljuAsync(z.ID);
                }

                await s.FlushAsync();

                await s.DeleteAsync(i);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja igracke: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajPismoAsync(PismoView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Pismo o = await s.LoadAsync<Pismo>(p.ID);
                o.Tekst = p.Tekst;
                o.DatumPrijema = p.DatumPrijema;
                o.DatumSlanja = p.DatumSlanja;
                o.IndeksDobrote = p.IndeksDobrote;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja pisma: {ex.Message}");
            }
            return true;
        }
        #endregion

        #region Poklon
        public static List<PoklonView> VratiSvePoklone()
        {
            List<PoklonView> pokloni = new List<PoklonView>();
            try
            {
                ISession session = DataLayer.GetSession();

                IEnumerable<Poklon> sviPokloni = from o in session.Query<Poklon>()
                                                 select o;
                foreach (Poklon p in sviPokloni)
                {
                    pokloni.Add(new PoklonView(p));
                }

                session.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih poklona: {ex.Message}");
            }
            return pokloni;
        }
        
        

        public async static Task<Result<PoklonView, string>> vratiPoklon(int id)
        {
            PoklonView poklon = new PoklonView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }
                Poklon p = await s.LoadAsync<Poklon>(id);

                
                poklon = new PoklonView(p);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja poklona: {ex.Message}");
            }
            return poklon;
        }
        public async static Task<Result<int, string>> DodajPoklonAsync(PoklonView p, int tovarID, int vilenjakID)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();

                Poklon o = new Poklon();
                Tovar tov = await s.LoadAsync<Tovar>(tovarID);
                VilenjakPokloni vil = await s.LoadAsync<VilenjakPokloni>(vilenjakID);
                JePakovao jePakovao = new JePakovao();

                o.SeNalaziUTovaru = tov;
                o.Posveta = p.Posveta;
                o.Boja = p.Boja;
                jePakovao.VilenjakPokloni = vil;
                jePakovao.Poklon = o;



                await s.SaveOrUpdateAsync(o);
                await s.SaveOrUpdateAsync(jePakovao);

                await s.FlushAsync();
                id = o.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom pakovanja poklona {ec.Message}");
            }
            return id;
        }
        public async static Task<Result<bool, string>> ObrisiPoklonAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Poklon p = await s.LoadAsync<Poklon>(id);

                foreach (var v in p.JePakovao)
                {
                    await s.DeleteAsync(v);
                }

                foreach (var i in p.SpakovaneIgracke)
                {
                    await DTOManager.ObrisiIgrackuAsync(i.ID);
                }


                await s.FlushAsync();

                await s.DeleteAsync(p);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja poklona: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajPoklonAsync(PoklonView p)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Poklon o = await s.LoadAsync<Poklon>(p.ID);
                o.Boja = p.Boja;
                o.Posveta = p.Posveta;



                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja pisma: {ex.Message}");
            }
            return true;
        }
        #endregion

        #region Tim
        public async static Task<Result<TimView, string>> VratiTimAsync(int id)
        {
            TimView t = new TimView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tim tim = await s.LoadAsync<Tim>(id);
                
                t = new TimView(tim);

                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja tima: {ex.Message}");
            }
            return t;
        }

        public static List<TimView> VratiSveTimove()
        {
            List<TimView> tim = new List<TimView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Tim> sviTimovi = from o in s.Query<Tim>()
                                             select o;
                foreach (Tim t in sviTimovi)
                {
                    tim.Add(new TimView(t));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih timova: {ex.Message}");
            }
            return tim;
        }
        public async static Task<Result<int, string>> DodajTimAsync(TimView tim, int idKoord)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tim t = new Tim();
                VilenjakIgracke vil = await s.LoadAsync<VilenjakIgracke>(idKoord);
                t.Koordinator = vil;


                await s.SaveOrUpdateAsync(t);

                s.Flush();
                id = t.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja tima: {ec.Message}");
            }
            return id;
        }

        public async static Task<Result<bool, string>> ObrisiTimAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tim t = await s.LoadAsync<Tim>(id);

                t.Koordinator.Tim = null;

                IEnumerable<VilenjakIgracke> vilenjaci = from o in s.Query<VilenjakIgracke>()
                                                         where o.Tim.ID == id
                                                         select o;

                foreach (var vil in vilenjaci)
                {
                    vil.Tim = null;
                }


                await s.FlushAsync();

                await s.DeleteAsync(t);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja tima: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajTimAsync(TimView v, int idKoord)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tim o = await s.LoadAsync<Tim>(v.ID);
                VilenjakIgracke t = await s.LoadAsync<VilenjakIgracke>(idKoord);

                o.Koordinator = t;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja irvasa: {ec.Message}");
            }

            return true;
        }
        #endregion

        #region Tovar

        public static List<TovarView> VratiSveTovare()
        {
            List<TovarView> tovari = new List<TovarView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Tovar> sviTovari = from o in s.Query<Tovar>()
                                               select o;

                foreach (Tovar t in sviTovari)
                {
                    tovari.Add(new TovarView(t));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih tovara: {ex.Message}");
            }
            return tovari;
        }

        public async static Task<Result<TovarView, string>> VratiTovarAsync(int id)
        {
            TovarView t = new TovarView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tovar o = await s.LoadAsync<Tovar>(id);
                t = new TovarView(o);

                s.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja tovara: {ex.Message}");
            }
            return t;
        }
        public async static Task<Result<int, string>> DodajTovarAsync(TovarView t)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tovar o = new Tovar();

                o.Grad = t.Grad;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();
                id = o.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom slanja tovara {ec.Message}");
            }
            return id;
        }
        public async static Task<Result<bool, string>> ObrisiTovarAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tovar t = await s.LoadAsync<Tovar>(id);

                foreach (var isp in t.IrvasIsporucujeTovar)
                {
                    await s.DeleteAsync(isp);
                }

                foreach (var p in t.PokloniUTovaru)
                {
                    p.SeNalaziUTovaru = null;
                }

                await s.FlushAsync();

                await s.DeleteAsync(t);

                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja tovara: {ec.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajTovarAsync(TovarView t)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Tovar o = await s.LoadAsync<Tovar>(t.ID);
                o.Grad = t.Grad;

                await s.FlushAsync();
                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja tovara: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return true;
        }
        #endregion

        #region Vilenjak

        #region VilenjakIgracke
        public static List<VilenjakIgrackeView> VratiSveVilenjakeIgracke()
        {
            List<VilenjakIgrackeView> vilenjaciIgracke = new List<VilenjakIgrackeView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIgracke> sviVilenjaciIgracke = from o
                                                                   in s.Query<VilenjakIgracke>()
                                                                   select o;

                foreach (VilenjakIgracke r in sviVilenjaciIgracke)
                {
                    vilenjaciIgracke.Add(new VilenjakIgrackeView(r));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za igracke: {ex.Message}");
            }

            return vilenjaciIgracke;
        }

        
        public async static Task<Result<VilenjakIgrackeView, string>> VratiVilenjakaIgracke(int id)
        {
            VilenjakIgrackeView vIgr = new VilenjakIgrackeView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakIgracke vi = await s.LoadAsync<VilenjakIgracke>(id);
                vIgr = new VilenjakIgrackeView(vi);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za igracke: {ex.Message}");
            }
            return vIgr;
        }
        public async static Task<Result<bool, string>> ObrisiVilenjakaIgrackeAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakIgracke v = await s.LoadAsync<VilenjakIgracke>(id);

                if (v.JeSef != null)
                {
                    DeoRadionice d = await s.LoadAsync<DeoRadionice>(v.JeSef.ID);

                    d.Sef = null;
                    d.DatumPostavljanja = default;
                }

                if(v.RasporedjenURadionicu != null)
                {
                    v.RasporedjenURadionicu.RasporedjeniVilenjaci.Remove(v);
                    if (v.RasporedjenURadionicu.BrojVilenjaka > 0)
                    {
                        v.RasporedjenURadionicu.BrojVilenjaka--;
                    }
                }
                                

                foreach (var i in v.IzradjeneIgracke)
                {
                    i.IzradioJeVilenjak = null;
                }

                foreach (var p in v.VilenjakPosedujeVestinu)
                {
                    p.VilenjakIgracke = null;
                    await s.DeleteAsync(p);
                }
                if (v.IDMentor != null)
                {
                    v.IDMentor.ObucavaniVilenjaci.Remove(v);
                }
                if (v.Mentor == "Da")
                {
                    foreach (var vil in v.ObucavaniVilenjaci)
                    {
                        vil.IDMentor = null;
                    }
                    v.ObucavaniVilenjaci.Clear();
                }

                if (v.JeKoordinator != null)
                {
                    Tim t = await s.LoadAsync<Tim>(v.JeKoordinator.ID);

                    t.Koordinator = null;
                }

                await s.FlushAsync();
                await s.DeleteAsync(v);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za igracke: {ex.Message}");
            }
            return true;
        }
        public async static Task<Result<bool, string>> AzurirajVilenjakaIgrackeAsync(VilenjakIgrackeView vilIgr, int idVilenjaka, int idTima, int idMentora, int idRadionica)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakIgracke vIgr = await s.LoadAsync<VilenjakIgracke>(idVilenjaka);
                Tim tim = await s.LoadAsync<Tim>(idTima);
                VilenjakIgracke vilenjak = await s.LoadAsync<VilenjakIgracke>(idMentora);
                DeoRadionice deoradionice = await s.LoadAsync<DeoRadionice>(idRadionica);


                if (vIgr.IDMentor != null)
                {
                    if (vIgr.IDMentor.ID != idMentora)
                    {
                        vIgr.IDMentor.ObucavaniVilenjaci.Remove(vIgr);
                    }
                }
                vilenjak.ObucavaniVilenjaci.Add(vIgr);

                if (vIgr.RasporedjenURadionicu != null)
                {
                    if (vIgr.RasporedjenURadionicu.ID != idRadionica)
                    {
                        if (vIgr.RasporedjenURadionicu.BrojVilenjaka > 0)
                            vIgr.RasporedjenURadionicu.BrojVilenjaka--;

                        deoradionice.BrojVilenjaka++;
                    }
                }


                vIgr.Tim = tim;
                vIgr.IDMentor = vilenjak;
                vIgr.RasporedjenURadionicu = deoradionice;


                vIgr.Ime = vilIgr.Ime;
                vIgr.ZemljaPorekla = vilIgr.ZemljaPorekla;
                vIgr.RadniStaz = vilIgr.RadniStaz;
                vIgr.Ocena = vilIgr.Ocena;
                vIgr.TrajanjeObuke = vilIgr.TrajanjeObuke;
                vIgr.SpecijalizovanZa = vilIgr.SpecijalizovanZa;
                vIgr.Sef = vilIgr.Sef;
                vIgr.Mentor = vilIgr.Mentor;
                vIgr.Koordinator = vilIgr.Koordinator;
                await s.SaveOrUpdateAsync(vIgr);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja vilenjaka za igracke: {ex.Message}");
            }
            return true;
        }
        public async static Task<Result<int, string>> DodajVilenjakaIgrackeAsync(VilenjakIgrackeView v, int mentorID, int drID, int timID)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }
                DedaMraz.Entiteti.VilenjakIgracke o = new DedaMraz.Entiteti.VilenjakIgracke();

                o.Ime = v.Ime;
                o.Koordinator = v.Koordinator;
                o.Sef = v.Sef;
                o.SpecijalizovanZa = v.SpecijalizovanZa;
                o.TrajanjeObuke = v.TrajanjeObuke;
                o.RadniStaz = v.RadniStaz;
                o.Ocena = v.Ocena;
                o.ZemljaPorekla = v.ZemljaPorekla;
                o.Mentor = v.Mentor;
                VilenjakIgracke vil = await s.LoadAsync<VilenjakIgracke>(mentorID);
                DeoRadionice deo = await s.LoadAsync<DeoRadionice>(drID);
                Tim tim = await s.LoadAsync<Tim>(timID);
                o.RasporedjenURadionicu = deo;
                o.Tim = tim;
                o.IDMentor = vil;
                o.RasporedjenURadionicu.BrojVilenjaka++;

                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();
                id = o.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
            return id;
        }


        #endregion

        #region VilenjakIrvasi
        public static List<VilenjakIrvasiView> VratiSveVilenjakeIrvase()
        {
            List<VilenjakIrvasiView> vilenjaciirvas = new List<VilenjakIrvasiView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakIrvasi> sviVilenjaciIrvasi = from o in s.Query<VilenjakIrvasi>()
                                                                 select o;

                foreach (VilenjakIrvasi r in sviVilenjaciIrvasi)
                {
                    vilenjaciirvas.Add(new VilenjakIrvasiView(r));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za irvase: {ex.Message}");
            }

            return vilenjaciirvas;
        }
        
        public async static Task<Result<VilenjakIrvasiView, string>> VratiVilenjakaIrvasiAsync(int id)
        {
            VilenjakIrvasiView vilenjak = new VilenjakIrvasiView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakIrvasi v = await s.LoadAsync<VilenjakIrvasi>(id);
                vilenjak = new VilenjakIrvasiView(v);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za irvase: {ex.Message}");
            }
            return vilenjak;
        }
        public async static Task<Result<bool, string>> ObrisiVilenjakaIrvasAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakIrvasi r = await s.LoadAsync<VilenjakIrvasi>(id);

                foreach (var z in r.VilenjakZnaPesmu)
                {
                    await s.DeleteAsync(z);
                }

                foreach (var i in r.VilenjakImaVestinu)
                {
                    await s.DeleteAsync(i);
                }

                r.VilenjakZnaPesmu.Clear();
                r.VilenjakImaVestinu.Clear();
                await s.DeleteAsync(r);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za irvase: {ex.Message}");
            }
            return true;
        }
        public async static Task<Result<int, string>> DodajVilenjakaIrvasAsync(VilenjakIrvasiView v, int irvasID)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }
                VilenjakIrvasi o = new VilenjakIrvasi();
                Irvas irv = await s.LoadAsync<Irvas>(irvasID);
                o.ZaduzenZaIrvasa = irv;
                o.Ime = v.Ime;
                o.RadniStaz = v.RadniStaz;
                o.ZemljaPorekla = v.ZemljaPorekla;


                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();
                id = o.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za irvase {ec.Message}");
            }
            return id;
        }

        public async static Task<Result<bool, string>> AzurirajVilenjakaIrvasiAsync(VilenjakIrvasiView vilIrv, int irvID, int idVilenjaka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakIrvasi vIrv = await s.LoadAsync<VilenjakIrvasi>(idVilenjaka);
                vIrv.Ime = vilIrv.Ime;
                vIrv.ZemljaPorekla = vilIrv.ZemljaPorekla;
                vIrv.RadniStaz = vilIrv.RadniStaz;
                Irvas i = await s.LoadAsync<Irvas>(irvID);
                vIrv.ZaduzenZaIrvasa = i;



                await s.SaveOrUpdateAsync(vIrv);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja vilenjaka za irvase: {ex.Message}");
            }
            return true;
        }

        #endregion

        #region VilenjakPokloni
        public static List<VilenjakPokloniView> VratiSveVilenjakePoklone()
        {
            List<VilenjakPokloniView> vilenjacipokloni = new List<VilenjakPokloniView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakPokloni> sviVilenjaciPokloni = from o in s.Query<VilenjakPokloni>()
                                                                   select o;

                foreach (VilenjakPokloni r in sviVilenjaciPokloni)
                {
                    vilenjacipokloni.Add(new VilenjakPokloniView(r));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za poklone: {ex.Message}");
            }

            return vilenjacipokloni;
        }
        
        public async static Task<Result<VilenjakPokloniView, string>> VratiVilenjakaPokloniAsync(int id)
        {
            VilenjakPokloniView vilenjak = new VilenjakPokloniView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }
                VilenjakPokloni v = await s.LoadAsync<VilenjakPokloni>(id);

                vilenjak = new VilenjakPokloniView(v);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za poklone: {ex.Message}");
            }
            return vilenjak;
        }
        public async static Task<Result<bool, string>> ObrisiVilenjakaPokloniAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakPokloni r = await s.LoadAsync<VilenjakPokloni>(id);

                foreach (var p in r.JePakovao)
                {
                    await s.DeleteAsync(p);
                }

                await s.DeleteAsync(r);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za poklone: {ex.Message}");
            }
            return true;
        }
        public async static Task<Result<int, string>> DodajVilenjakaPoklonAsync(VilenjakPokloniView v)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();

                VilenjakPokloni o = new VilenjakPokloni();

                o.Ime = v.Ime;
                o.RadniStaz = v.RadniStaz;
                o.ZemljaPorekla = v.ZemljaPorekla;


                await s.SaveOrUpdateAsync(o);

                await s.FlushAsync();
                id = o.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za igracke: {ec.Message}");
            }
            return id;
        }

        public async static Task<Result<bool, string>> AzurirajVilenjakaPokloniAsync(VilenjakPokloniView vilPok, int idVilenjaka)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakPokloni v = await s.LoadAsync<VilenjakPokloni>(idVilenjaka);
                v.Ime = vilPok.Ime;
                v.ZemljaPorekla = vilPok.ZemljaPorekla;
                v.RadniStaz = vilPok.RadniStaz;

                await s.SaveOrUpdateAsync(v);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja vilenjaka za poklone: {ex.Message}");
            }
            return true;
        }

        #endregion

        #region VilenjakTovar
        public static List<VilenjakTovarView> VratiSveVilenjakeTovare()
        {
            List<VilenjakTovarView> vilenjacitovari = new List<VilenjakTovarView>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<VilenjakTovar> sviVilenjaciTovari = from o in s.Query<VilenjakTovar>()
                                                                select o;

                foreach (VilenjakTovar r in sviVilenjaciTovari)
                {
                    vilenjacitovari.Add(new VilenjakTovarView(r));
                }

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih vilenjaka za tovar: {ex.Message}");
            }

            return vilenjacitovari;
        }

        public async static Task<Result<VilenjakTovarView, string>> VratiVilenjakaTovarAsync(int id)
        {
            VilenjakTovarView vilenjak = new VilenjakTovarView();
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakTovar v = await s.LoadAsync<VilenjakTovar>(id);
                vilenjak = new VilenjakTovarView(v);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja vilenjaka za tovar: {ex.Message}");
            }
            return vilenjak;
        }


        public async static Task<Result<bool, string>> ObrisiVilenjakaTovarAsync(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakTovar r = await s.LoadAsync<VilenjakTovar>(id);

                r.PripremioTovar.PakovaliVilenjaci.Remove(r);

                await s.DeleteAsync(r);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja vilenjaka za tovar: {ex.Message}");
            }
            return true;
        }
        public async static Task<Result<int, string>> DodajVilenjakaTovarAsync(VilenjakTovarView v, int tovarID)
        {
            int id = default;

            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }
                VilenjakTovar o = new VilenjakTovar();
                Tovar tov = await s.LoadAsync<Tovar>(tovarID);
                o.Ime = v.Ime;
                o.RadniStaz = v.RadniStaz;
                o.ZemljaPorekla = v.ZemljaPorekla;
                o.PripremioTovar = tov;

                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();
                id = o.ID;
                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja vilenjaka za tovar: {ec.Message}");
            }
            return id;
        }
        public async static Task<Result<bool, string>> AzurirajVilenjakaZaTovarAsync(VilenjakTovarView v, int idVilenjaka, int idTovara)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakTovar o = await s.LoadAsync<VilenjakTovar>(idVilenjaka);
                Tovar t = await s.LoadAsync<Tovar>(idTovara);
                o.PripremioTovar = t;
                o.Ime = v.Ime;
                o.RadniStaz = v.RadniStaz;
                o.ZemljaPorekla = v.ZemljaPorekla;


                await s.SaveOrUpdateAsync(o);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ec)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja irvasa: {ec.Message}");
            }

            return true;
        }

        public async static Task<Result<bool, string>> AzurirajVilenjakaTovarAsync(VilenjakTovarView vilTov, int tovID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                VilenjakTovar v = await s.LoadAsync<VilenjakTovar>(vilTov.ID);
                v.Ime = vilTov.Ime;
                v.ZemljaPorekla = vilTov.ZemljaPorekla;
                v.RadniStaz = vilTov.RadniStaz;
                Tovar t = await s.LoadAsync<Tovar>(tovID);
                v.PripremioTovar = t;

                await s.SaveOrUpdateAsync(v);
                await s.FlushAsync();

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja vilenjaka za tovar: {ex.Message}");
            }
            return true;
        }

        #endregion

        #endregion

        #region Zelja
        public static List<ZeljaView> VratiSveZelje()
        {
            List<ZeljaView> listazelja = new List<ZeljaView>();

            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Zelja> zelje = from o in s.Query<Zelja>()
                                           select o;

                foreach (Zelja z in zelje)
                {
                    listazelja.Add(new ZeljaView(z));
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja svih zelja: {ex.Message}");
            }
            return listazelja;
        }

        public async static Task<Result<ZeljaView, string>> VratiZeljuAsync(int id)
        {
            ZeljaView zelja = new ZeljaView();
            try
            {
                ISession s = DataLayer.GetSession();

                Zelja z = await s.LoadAsync<Zelja>(id);


                zelja = new ZeljaView(z);

                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom vracanja zelje: {ex.Message}");
            }
            return zelja;
        }




        public async static Task<Result<int, string>> DodajZeljuAsync(ZeljaView zelja, int idPisma, int idIgracke, int sifraPoklona)
        {
            int id = default;
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Zelja z = new Zelja();
                Pismo pismo = await s.LoadAsync<Pismo>(idPisma);
                Igracka igracka = await s.LoadAsync<Igracka>(idIgracke);
                Poklon poklon = await s.LoadAsync<Poklon>(sifraPoklona);
                z.SeOdnosiNaPoklon = poklon;
                z.IDIgracke = igracka;

                z.Naziv = zelja.Naziv;
                z.PripadaPismu = pismo;



                pismo.SadrziZelje.Add(z);
                poklon.SeOdnosiNaZelje.Add(z);
                await s.SaveOrUpdateAsync(pismo);
                await s.SaveAsync(z);
                await s.FlushAsync();
                id = z.ID;
                s.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom dodavanja zelje: {ex.Message}");
            }
            return id;
        }
        public async static Task<Result<bool, string>> ObrisiZeljuAsync(int id)
        {
            ISession s = null;
            try
            {
                s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Zelja z = await s.LoadAsync<Zelja>(id);

                z.PripadaPismu.SadrziZelje.Remove(z);

                z.SeOdnosiNaPoklon.SeOdnosiNaZelje.Remove(z);

                await DTOManager.ObrisiIgrackuAsync(z.IDIgracke.ID);

                await s.DeleteAsync(z);
                await s.FlushAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom brisanja zelje: {ex.Message}");
            }
            finally
            {
                s?.Close();
                s?.Dispose();
            }
            return true;
        }

        public async static Task<Result<bool, string>> AzurirajZeljuAsync(ZeljaView z, int pismoID, int poklonID, int igrackaID)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                if (!(s?.IsConnected ?? false))
                {
                    return "Nemoguće otvoriti sesiju.";
                }

                Zelja zelja = await s.LoadAsync<Zelja>(z.ID);
                Pismo p = await s.LoadAsync<Pismo>(pismoID);
                Poklon po = await s.LoadAsync<Poklon>(poklonID);
                Igracka i = await s.LoadAsync<Igracka>(igrackaID);

                zelja.Naziv = z.Naziv;
                zelja.PripadaPismu = p;
                zelja.SeOdnosiNaPoklon = po;
                zelja.IDIgracke = i;

                await s.SaveOrUpdateAsync(zelja);
                await s.FlushAsync();

                s.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Doslo je do pojave izuzetka prilikom azuriranja zelje: {ex.Message}");
            }

            return true;
        }

        #endregion
    }
}















