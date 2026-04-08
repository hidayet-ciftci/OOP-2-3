using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    public class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            // Basvuru yap ama hangi kredi türüne göre ?
            // bunuda ortak olan interface'i kullanacağız.
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirme(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
