using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ıhtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager tasitCreditManager = new TasitCreditManager();  
            ICreditManager konutCreditManager = new KonutCreditManager();

            BasvuruManager basvuruManager = new BasvuruManager();
             basvuruManager.BasvuruYap(ıhtiyacCreditManager, new DatabaseLoggerServices());

            List<ICreditManager> credits = new List<ICreditManager>() {ıhtiyacCreditManager,tasitCreditManager };
            //basvuruManager.KrediOnBilgilendirme(credits);
  
        }
    }
}
