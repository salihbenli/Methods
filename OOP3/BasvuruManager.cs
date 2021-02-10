using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerServices loggerServices)
        {
            creditManager.Calculate();
            loggerServices.Log();
        }
        public void KrediOnBilgilendirme(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
