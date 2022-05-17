using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_PAW
{
    public class AdaugaOferta : InterfataOferte
    {


        public void Add(Servicii servicii)
        {
            Oferte2022.Servicii.Add(servicii);
        }

        public List<Servicii> GetServicii()
        {
            return Oferte2022.Servicii;
        }
    }
}
