using System;

namespace quizz
{
    class Program
    {
        static void Main(string[] args)
        {
            product ürün1 = new product();
            ürün1.cinsi = "Kazak";
            ürün1.beden = "Large";
            ürün1.fiyat = 150;

            product ürün2 = new product();
            ürün2.cinsi = "Kaban";
            ürün2.beden = "Medium";
            ürün2.fiyat = 250;

            product ürün3 = new product();
            ürün3.cinsi = "Gömlek";
            ürün3.beden = "Small";
            ürün3.fiyat = 100;

            product[] ürünler = new product[] { ürün1, ürün2, ürün3 };
            foreach (var product in ürünler)
            {
                Console.WriteLine(ürün1.cinsi + " : " + ürün1.beden + " : " + ürün1.fiyat);
            }
           // Console.WriteLine(ürün1.cinsi + " : " + ürün1.beden + " : " + ürün1.fiyat);
        }
           
            class product
        {
            public string cinsi { get; set; }
            public string beden { get; set; }
            public int fiyat { get; set; }

        }
        
    }
}
