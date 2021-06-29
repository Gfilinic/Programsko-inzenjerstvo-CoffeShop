using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2021_Kafic
{
    public partial class Stavka_racuna
    {
        public override string ToString()
        {
            Stavka_racuna stavka;
            using (var context = new Entities())
            {
                var query = from s in context.Stavka_racuna.Include("Artikl")
                            where s.Artikl_ID == this.Artikl_ID && s.Racun_ID == this.Racun_ID
                            select s;
                if (query.ToList().Count > 0) {
                stavka = query.Single();
                return stavka.Artikl.Naziv + " "+"x"+stavka.Količina+" " + stavka.Artikl.Cijena + "kn";

                }
                
                return "Error";
            }
           
        }
    }
}
