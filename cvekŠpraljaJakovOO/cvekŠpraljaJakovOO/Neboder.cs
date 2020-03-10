using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovOO
{
    class Neboder
    {
        double visina;
        int brojKatova;
        string ispis;

        public Neboder(double visina, int brojKatova)
        {
            this.visina = visina;
            this.brojKatova = brojKatova;
        }
        
        public double GetVisina()
        {
            return visina;
        }

        public double GetBrojKatova()
        {
            return brojKatova;
        }

        public void SetVisina(double visina)
        {
            this.visina = visina;
        }

        public void SetBrojKatova(int brojKatova)
        {
            this.brojKatova = brojKatova;
        }

        public override string ToString()
        {
            Console.WriteLine("Visina je " + GetVisina() + "\nBroj katova je " + GetBrojKatova());
            return base.ToString();
        }
    }
}
