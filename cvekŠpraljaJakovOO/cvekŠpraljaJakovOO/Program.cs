using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder(200, 10);
            Tower.SetVisina(Tower.GetVisina() + 10);
            Tower.SetBrojKatova(Convert.ToInt32(Tower.GetBrojKatova())+ 1);
            Tower.ToString();
            Console.ReadKey();
            
        }
    }
}
