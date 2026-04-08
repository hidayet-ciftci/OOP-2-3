using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class IhtiyacKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Bir sey yapıldı");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi hesaplandi");
        }
    }
}
