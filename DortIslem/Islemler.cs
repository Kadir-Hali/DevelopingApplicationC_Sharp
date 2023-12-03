using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DortIslem
{
    
    public class Islemler
    {
        public int topla(int sayi1,int sayi2)
        { 
            int sayi3;
            sayi3 = sayi1 + sayi2;
            Console.WriteLine("Toplam:" +sayi3);
            return sayi3;
        }
        public int cikar(int sayi1, int sayi2)
        {
            int sayi3;
            sayi3 = sayi1 - sayi2;
            Console.WriteLine("Fark:" + sayi3);
            return sayi3;
        }
        public int carp(int sayi1, int sayi2)
        {
            int sayi3;
            sayi3 = sayi1 * sayi2;
            Console.WriteLine("Çarpım:" + sayi3);
            return sayi3;
        }
        public int böl(int sayi1, int sayi2)
        {
            int sayi3;
            sayi3 = sayi1 / sayi2;
            Console.WriteLine("Bölüm:" + sayi3);
            return sayi3;
        }
    }
}