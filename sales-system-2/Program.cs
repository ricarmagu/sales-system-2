using System;

namespace sales_system_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Reports report = new Reports();

            Seller v1 = new Seller();
            v1.nameSeller = "juan";
            v1.age = 23;
            report.Addarrsellers(v1);

            Seller v2 = new Seller();
            v2.nameSeller = "pedro";
            v2.age = 26;
            report.Addarrsellers(v2);

            Seller v3 = new Seller();
            v3.nameSeller = "juan camilo";
            v3.age = 22;
            report.Addarrsellers(v3);

            Product p1 = new Product();
            p1.nameProduct = "eraser";
            p1.value = 500;
            report.Addarrproduct(p1);

            Product p2 = new Product();
            p2.nameProduct = "rice";
            p2.value = 600;
            report.Addarrproduct(p2);

            Product p3 = new Product();
            p3.nameProduct = "peanut";
            p3.value = 150;
            report.Addarrproduct(p3);

            Sale sale1 = new Sale();
            sale1.product = p1;
            sale1.seller = v1;
            sale1.commentary = "Thanks for your purchase";
            report.Addarrsales(sale1);

            Sale sale2 = new Sale();
            sale2.product = p2;
            sale2.seller = v2;
            sale2.commentary = "Thanks for your purchase";
            report.Addarrsales(sale2);

            Sale sale3 = new Sale();
            sale3.product = p3;
            sale3.seller = v3;
            sale3.commentary = "Thanks for your purchase";
            report.Addarrsales(sale3);

           // report.themostcheapestproduct();

            report.averageproductcost();

            //report.themostexpensiveproduct();
        }
    }
}
