using System;
using System.Collections.Generic;
using System.Text;
using sales_system_2;

namespace sales_system_2
{
    class Reports
    {

        Product[] arrproduct = new Product[3];
        int productsCount = 0;

        Seller[] arrsellers = new Seller[3];
        int sellersCount = 0;

        Sale[] arrsales = new Sale[3];
        int salesCount = 0;

        public void Addarrproduct(Product newProduct)
        {
            arrproduct[productsCount] = newProduct;
            productsCount++;
        }

        public void Addarrsellers(Seller newSeller)
        {
            arrsellers[sellersCount] = newSeller;
            sellersCount++;
        }
        public void Addarrsales(Sale newSale)
        {
            arrsales[salesCount] = newSale;
            salesCount++;
        }
        public void themostexpensiveproduct()
        {
            Product aux = null;
            for (int i = 0; i < arrproduct.Length; i++)
            {
                if (i == 0)
                {
                    aux = arrproduct[i];
                }
                else
                {
                    if (arrproduct[i].value > aux.value)
                    {
                        aux = arrproduct[i];
                    }

                }

            }
            Console.WriteLine("The most expensive product is: " + aux.nameProduct);

            

        }


        public void themostcheapestproduct()
        {
            Product aux=null ;

            for (int i = 0; i < arrproduct.Length; i++)
            {

                if (i == 0)
                {
                    aux = arrproduct[i];
                }
                else
                {
                    if (arrproduct[i].value < aux.value)
                    {
                        aux = arrproduct[i];
                    }

                }

            }
            for (int i = 0; i < arrsales.Length; i++)
            {
                if (arrsales[i].product.nameProduct.Equals(aux.nameProduct))
                {
                    Console.WriteLine("The Seller with the cheapest product is: " + arrsales[i].seller.nameSeller);
                }
            }
            
        }

        public void averageproductcost()
        {
            int aux = 0;
            for (int i = 0; i < arrsales.Length; i++)
            {
                aux += arrsales[i].product.value;
            }
            aux /= arrproduct.Length;
            Console.WriteLine("The avarage is:" + aux);
        }

        public void quantityProduct()
        {
            int auxrice = 0;
            int auxeraser = 0;
            int auxpeanut = 0;

            for(int i=0; i<arrsales.Length;i++)
            {
                switch (arrsales[i].product.nameProduct)
                {
                    case "eraser":
                        auxrice++;
                        break;
                    case "rice":
                        auxrice++;
                        break;
                    case "peanut":
                        auxpeanut++;
                        break;
                }
            }

            if(auxeraser>auxrice && auxeraser>auxpeanut)
            {
                Console.WriteLine("There is more quantity of eraser product");
            }
            else if(auxrice>auxeraser&&auxrice>auxpeanut)
            {
                Console.WriteLine("There is more quantity of rice product");
            }
            else
            {
                Console.WriteLine("There is more quantity of peanut product");
            }
        }
    }
}
