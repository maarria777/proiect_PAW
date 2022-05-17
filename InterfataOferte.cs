using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_PAW
{
    interface InterfataOferte
    {
        List<Servicii>GetServicii();
        void Add(Servicii servicii);
    }
}
