using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovOO2
{
    class Vozilo
    {
        string vrsta;
        int maxBrzina;
        int brojKotaca;

        public Vozilo(string vrsta, int maxBrzina, int brojKotaca)
        {
            this.vrsta = vrsta;
            this.maxBrzina = maxBrzina;
            this.brojKotaca = brojKotaca;
        }

        public Vozilo(string vrsta, int brojKotaca)
        {
            this.vrsta = vrsta;
            this.brojKotaca = brojKotaca;
        }
        public void setMaxBrzina(int maxBrzina)
        {
            this.maxBrzina = maxBrzina;
        }
    }
}
