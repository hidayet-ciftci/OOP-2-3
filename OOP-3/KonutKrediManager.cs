using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class KonutKrediManager : IKrediManager
    {
        public void Hesapla2()
        {
            Console.WriteLine("Konut kredisi interface'siz hesaplandı");
        }
        public void BiseyYap()
        {
            Console.WriteLine("bir şey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı");
        }
    }
}
