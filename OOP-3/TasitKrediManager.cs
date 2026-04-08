using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("bir şey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt hesaplandi");
        }
    }
}
