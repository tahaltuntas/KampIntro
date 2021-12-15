using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //farklı şekilde tanımlama yapabiliriz.
            Product product2 = new Product {Id = 2, CategoryId = 5,
            UnitInStock = 5, ProductName="Kalem", UnitPrice=35};

            //case sensitive : küçük büyük harf duyarlılığı
            //PascalCase   //camelCase
            ProductManager productManager = new ProductManager();
            //stack                         //heap
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); 


            //farkı anlamak için bu örneği veriyoruz.
            int sayi = 100;
            productManager.BirSeyYap(sayi);
            Console.WriteLine(sayi); // 100 
            
            //int,double,bool .... Değer Tip-- Atamalar tamamen değer üstünden olur
            //Array, Class , Abstract clas, interface ..... Referans Tip // Atamalar Bellekteki adresi ile yapılır
            //
        }
    }
}
