using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_2021_Kafic
{
    public partial class Stavka_normativa
    {
        public override string ToString()
        {
            Stavka_normativa odabranaStavka=this;
            using (var context= new Entities())
            {
                context.Stavka_normativa.Attach(this);
                var query = from s in context.Stavka_normativa.Include("Namirnica")
 
                            select s;
                List<Stavka_normativa> lista = query.ToList();
                foreach  (Stavka_normativa stavka in lista)
                {
                    if (stavka.ID_Stavka_normativa == this.ID_Stavka_normativa)
                    {
                        return stavka.Namirnica.Naziv_Namirnice + " " + stavka.Kolicina.ToString();
                    }
                }
                return this.Namirnica.ToString();
            }
        }
    }
}
