using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kapmpı";
            string kurs2 = "Programlamaya başlangı için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            // array - dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kapmpı",
                "Programlamaya başlangı için temel kurs",
                "Java", "Python", "C++" };


            for (int i = 0; i<kurslar.Length; i=i+1)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");

            string[] kurs = new string[] { "Yazılım Geliştirici Yetiştirme Kapmpı",
                "Programlamaya başlangı için temel kurs",
                "Java", "Python", "C++" };

            //foreach: dizi temelli yapıları tek tek dönmeye yarıyor.
            //kursları dolaş
            //ortadaki kurs yerine istediğimizide yazabiliriz.
            //buradaki kurs alias oluyor
            //yukaradaki for döngüsüyle aynı sonucu alıyoruz.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");

        }
    }
}
