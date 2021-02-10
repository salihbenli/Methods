using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndivialCostumer costumer1 = new IndivialCostumer();
            costumer1.CostumerNo = "12340";
            costumer1.Name = "Salih";
            costumer1.LastName = "Benli";
            costumer1.TcNo = "5454";
            costumer1.Id = 4564;

            CoorporateCostumer costumer2 = new CoorporateCostumer();
            costumer2.CostumerNo = "12340";
            costumer2.Id = 4564;
            costumer2.CompanyName = "Dolgit";
            costumer2.VergiNo = "4569887";


            Costumer costumer3 = new IndivialCostumer();
            Costumer costumer4 = new CoorporateCostumer();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer2);



        }
    }
}
