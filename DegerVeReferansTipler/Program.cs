﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değer Tip : int, decimal, floati double, bool 
            //Referans Tip : Array, Class, İnterface

            // Değer tipte olanlar "stack" tanımlanıyor
            // Referans tipte olanlar "heap" tanımlanıyor.

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1??? - 30
            Console.WriteLine(sayi1);

            // new demek bellekte yeni bir adres oluştur anlamına geliyor
            // int bile olsa arrayler referans tiplidir.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1  = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]?? -  999
            Console.WriteLine(sayilar1[0]);
           

        }
    }
}
