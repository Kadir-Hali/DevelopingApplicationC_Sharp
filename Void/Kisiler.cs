using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void
{
    public class Kisiler
    {
        public void kisilerListesi(string adsoyad,int yas,string meslek)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{adsoyad} {yas} {meslek}");
            }
        }
    }
}
