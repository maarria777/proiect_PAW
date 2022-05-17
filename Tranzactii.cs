using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_PAW
{
    public class Tranzactii
    {
        public Guid IdTranzactie { get; set; }
        public string Client { get; set; } //nume, prenume, adresa, email, nr telefon..
        public string DetaliiTranzactie { get; set; } //sejur 2 pers in grecia, 7 nopti...etc
        public double ValoareTranzactie { get; set; } 
        public string StatusTranzactie { get; set; } //plata neprocesata, in curs de procesare, procesata
        
    }
}
