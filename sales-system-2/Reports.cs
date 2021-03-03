using System;
using System.Collections.Generic;
using System.Text;
using sales_system_2;

namespace sales_system_2
{
    class Reports
    {
        Product aux = null;

        Product[] arrproduct = new Product[3];
        int productsCount = 0;

        Seller[] arrsellers = new Seller[3];
        int sellersCount = 0;

        Sale[] arrsales = new Sale[3 * 3];
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
            for (int k = 0; k < arrsales.Length; k++)
            {
                if (arrsales[k].product.nameProduct.Equals(aux.nameProduct))
                {
                    Console.WriteLine("The Seller with the cheapest product is: " + arrsales[k].seller.nameSeller);
                }
            }
            
        }

        public void averageproductcost()
        {
            int aux1 = 0;
            for (int i = 0; i< arrsales.Length; i++)
            {
                aux1 += arrsales[i].product.value;
            }
            Console.WriteLine("The avarage is:" + aux1);
        }
    }
}
