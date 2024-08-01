using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klavyeden_girilen_mevsimin_hangi_aylarda_olduğu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mevsimi girin");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "kış": Console.WriteLine("Aralık, Ocak, Şubat"); break;
                case "ilkbahar": Console.WriteLine("Mart, Nisan, Mayıs"); break;
                case "yaz": Console.WriteLine("Haziran, Temmuz, Ağustos"); break;
                case "sonbahar": Console.WriteLine("Eylül, Ekim, Kasım"); break;

                default: Console.WriteLine("Böyle bir mevsim yok"); break;
            }

            Console.ReadLine();
        }
    }
}
