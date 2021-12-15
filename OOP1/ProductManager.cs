using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        // Product türünde bana bir şey ver. --> string isim gibi düşün

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }

        //void ne işe yarıyor : emir kipinde çağırıyor.
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        //farkı anlamak için bu örneği veriyoruz.
        public void BirSeyYap(int sayi)
        {
            sayi = 99;
        }

        
        
    }
}
