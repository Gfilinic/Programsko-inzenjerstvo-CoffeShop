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
             poruka+= $"\nKako biste pristupili stolu ili se ulogirajte kao konobar za stalno ili ulogirajte aktivnog konobara pritiskom na okvir stola \n";
            poruka += $"\nUkoliko nemate stolove, morate se ulogirati kao moderator te ih dodati pod upravljanje stolovima \n";
            poruka += $"\nTakođer ostala upravljanja možete napraviti kao moderator!";
            MessageBox.Show(poruka,"Glavna forma help");


             }
        public static void HelpLoginKonobar()
        {
            string poruka = $"Login za konobare \n";
            poruka += $"\n Konobari moraju biti dodani u sustav sa vlastitom sifrom kako bi su se ulogirali \n";
            poruka += $"\n Konobare može dodati moderator kafića \n";

            poruka += $"\n Ukoliko je unesena sifra koja ne postoji, sučelje se zatvara \n";
            
            MessageBox.Show(poruka, "Login konobar help");
        }
        public static void HelpLoginModerator()
        {
            string poruka = $"Login za moderatore help \n";
            poruka += $"\n Moderatore dodaje superadmin, svaki moderator ima vlastito korisnicko ime i sifru \n";
            poruka += $"\n Ukoliko nemate moderatora, obratite nam se na broj ili na e-mail kako bismo vam ga dodijelili \n";

            poruka += $"\n Ukoliko je unesena sifra koja ne postoji, sučelje se zatvara \n";
            MessageBox.Show(poruka, "Login modetaor help");
        }
        
        public static void HelpFormNamirnice()
        {
            string poruka = $"Forma za upravljanje namirnica help \n";
            poruka += $"\n Ova forma sadrži jednostavne funkcije za dodavanje, brisanje i uređivanje namirnica.  \n";
            poruka += $"\n Klikom na listu namirnica možete istu obrisati ili urediti \n";
            poruka += $"\n Klikom na dodaj novu namirnicu otvara se forma koja se ispuni da bi se dodala nova namirnica \n";
            MessageBox.Show(poruka, "Forma za upravljanje namirnica");



        }
        
        public static void HelpDodajNamirnicu()
        {
            string poruka = $"Forma za dodavanje namirnica help";
            poruka += $"\n Oba polja moraju biti popunjena kako bi ste spremili novu namirnicu  \n";
            poruka += $"\n Komad se odnosi na komad namirnice kao npr boca coca cole \n";
            MessageBox.Show(poruka, "Forma za dodavanje namirnica");

        }
    }
}
