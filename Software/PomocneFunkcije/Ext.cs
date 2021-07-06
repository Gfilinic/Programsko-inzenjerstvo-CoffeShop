using System;
using System.Windows.Forms;

namespace PomocneFunkcije
{
    public static class PomocneFunkcije
    {


        public static double IzracunajProsjek(double a, double n)
        {
            return a / n;
        }
        public static void HelpMain() {
            string poruka = $"Ovo je glavna forma \n";
            poruka += $"\nKako biste pristupili stolu ili se ulogirajte kao konobar za stalno ili ulogirajte aktivnog konobara pritiskom na okvir stola \n";
            poruka += $"\nUkoliko nemate stolove, morate se ulogirati kao moderator te ih dodati pod upravljanje stolovima \n";
            poruka += $"\nTakođer ostala upravljanja možete napraviti kao moderator!";
            MessageBox.Show(poruka, "Glavna forma help");


        }
        public static void HelpLoginKonobar()
        {
            string poruka = $"Login za konobare \n";
            poruka += $"\nKonobari moraju biti dodani u sustav sa vlastitom sifrom kako bi su se ulogirali \n";
            poruka += $"\nKonobare može dodati moderator kafića \n";

            poruka += $"\nUkoliko je unesena sifra koja ne postoji, sučelje se zatvara \n";

            MessageBox.Show(poruka, "Login konobar help");
        }
        public static void HelpLoginModerator()
        {
            string poruka = $"Login za moderatore help \n";
            poruka += $"\nModeratore dodaje superadmin, svaki moderator ima vlastito korisnicko ime i sifru \n";
            poruka += $"\nUkoliko nemate moderatora, obratite nam se na broj ili na e-mail kako bismo vam ga dodijelili \n";

            poruka += $"\nUkoliko je unesena sifra koja ne postoji, sučelje se zatvara \n";
            MessageBox.Show(poruka, "Login modetaor help");
        }

        public static void HelpFormNamirnice()
        {
            string poruka = $"Forma za upravljanje namirnica help \n";
            poruka += $"\nOva forma sadrži jednostavne funkcije za dodavanje, brisanje i uređivanje namirnica.  \n";
            poruka += $"\nKlikom na listu namirnica možete istu obrisati ili urediti \n";
            poruka += $"\nKlikom na dodaj novu namirnicu otvara se forma koja se ispuni da bi se dodala nova namirnica \n";
            MessageBox.Show(poruka, "Forma za upravljanje namirnica");



        }

        public static void HelpDodajNamirnicu()
        {
            string poruka = $"Forma za dodavanje namirnica help\n";
            poruka += $"\nOba polja moraju biti popunjena kako bi ste spremili novu namirnicu  \n";
            poruka += $"\nKomad se odnosi na komad namirnice kao npr boca coca cole \n";
            MessageBox.Show(poruka, "Forma za dodavanje namirnica");

        }

        public static void HelpNormativMain()
        {
            string poruka = $"Forma za upravljanje normativima help\n";
            poruka += $"\nSa lijeve strane vidi se popis normativa, odabirom normativa isti se može izmijeniti ili obrisati\n";
            poruka += $"\nNormativi služe kako bi se mogla voditi automatska evidencija skladišta \n";
            poruka += $"\nPritiskom dodaj normativ unosi se novi normativ \n";
            MessageBox.Show(poruka, "Forma za upravljanje normativima");


        }
        public static void HelpDodajNormativ()
        {
            string poruka = $"Forma za dodavanje normativa help\n";
            poruka += $"\nKako biste formirali novi normativ morate ga posložiti od nekoliko stavki\n";
            poruka += $"\nJedna stavka se sastoji od jedne Namirnice (koje moraju biti postavljene u skladištu) i količine iste \n";
            poruka += $"\nPrimjer normativa: U slučaju kave s mlijekom imali bismo 2 stavke: \n";
            poruka += $"\n-mlijeko 0,1 l \n -kava 30g \n";
            poruka += $"\nStavke se mogu ukloniti pritiskom na tipku 'ukloni stavku' \n";

            MessageBox.Show(poruka, "Forma za dodavanje normativa");


        }
        public static void HelpArtiklMain() {
            string poruka = $"Forma za upravljanje artiklima help\n";
            poruka += $"\nLista pokazuje artikle\n";
            poruka += $"\nArtikli se mogu filtrirati po kategoriji ili se mogu prikazati svi\n";
            poruka += $"\nMože se brisati ili uređivati artikl\n";

            MessageBox.Show(poruka, "Forma za upravljanje normativima");

        }
        public static void HelpArtiklManager() {
            string poruka = $"Forma za izmjenjivanje/dodavanje artikla help\n";
            poruka += $"\nPopunite artikl sa potrebnim podacima\n";
            poruka += $"\nMorate za artikl staviti normativ ukoliko želite da vam se evidentira stanje na skladištu ovisno o artiklima i otpisu\n";
            
            MessageBox.Show(poruka, "Forma za izmijeniti/dodati artikl");

        }

        public static void HelpOtpis()
        {
            string poruka = $"Forma za otpis help\n";
            poruka += $"\nArtikle možete filtrirati po kategoriji ili ih sve prikazati\n";
            poruka += $"\nOdaberite željeni artikl i odaberite količinu koju želite otpisati\n";
            poruka += $"\nOtpisom artikla automatski se ažurira stanje na skladištu ovisno o definiramon normativu\n";
            MessageBox.Show(poruka, "Forma za otpis");

        }

        public static void HelpPotrosnja()
        {
            string poruka = $"Forma za potrošnju help\n";
            poruka += $"\nPredviđanje potrošnje se temelji na prosjeku potrošnje u zadanom periodu forme računi.\n" +
                $"\nOdaberite period kroz koji želite vidjeti kada ćete ostati bez namirnica na temelju predviđanja\n" +
                $"\nGenerira se i izvještaj koji se onda može printati ili exportati.\n";
            MessageBox.Show(poruka, "Forma za potrošnju");
        }

        public static void HelpRacuni()
        {
            string poruka = $"Forma za račune help\n" +
                $"\nOdaberite period u kojem želite vidjeti račune\n" +
                $"\nPrvi prikaz prikazuje račune danog perioda\n" +
                $"\nDrugi prikaz prikazuje stavke računa\n" +
                $"\nNa desnoj strani forme može se napraviti predviđanje po namirnici ili artiklu odabirom iz selekcije\n" +
                $"\nKliknom na tipku 'Pregled namirnica za nadopuniti' otvara se forma sa izvještajem koji se može isprintati\n ";
            MessageBox.Show(poruka, "Forma za račune");
        }
        public static void HelpStanjeSkladista()
        {
            string poruka = $"Forma za stanje skladišta help \n" +
                $"\nOdaberite Artikl iz popisa artikla, odabranom artiklu možete direktno promijneiti stanje" +
                $"pritiskom na tipku spremi novo stanje\n" +
                $"\nMože se i samo nadodati nova količina na trenutno stanje odabirom druge opcije\n";
            MessageBox.Show(poruka, "Forma za stanje skladišta");
        }
        public static void HelpUpravaljanjeStolovima()
        {
            string poruka = $"Forma za upravljanje stolovima help \n" +
                $"Popunite naziv stola i broj mjesta na stolu te dodajte još jedan stol koji će se automatski ažurirati kad zatvorite ovu formu" +
                $"\nStolove možete i brisati\n";
        }

        public static void HelpUpravljanjeKonobarima()
        {
            string poruka = $"Forma za upravljanje konobarima help \n" +
                $"\nOdaberite konobara s lijeve strane te uredite njegove podatke ili dodajte novog konobara\n" +
                $"\nKonobare koje postavite kao voditelji imaju dodatne funkcionalnosti kao otpis i pregled racuna\n" +
                $"\nKonobari se mogu i brisati\n";
            MessageBox.Show(poruka, "Forma za upravljanje konobarima");
        }
        public static void HelpNarudzbe()
        {
            string poruka=$"Forma za narudzbe help\n" +
                $"\nUlogirani konbar ovdje postavlja stavke racuna koje onda može ili printati ili staviti na stol\n" +
                $"\nKlikom na artikl 2 puta se dodaje na listu, stavke racuna se također brišu sa 2 klika\n" +
                $"\nKategorija pića se mijenja sa ikonicama\n" +
                $"\nTipka izdaj račun sprema račun u bazu podataka\n";
            MessageBox.Show(poruka, "Forma narduzbe za stol");
        }
    }
}
