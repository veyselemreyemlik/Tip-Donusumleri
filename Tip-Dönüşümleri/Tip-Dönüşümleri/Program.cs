using System;

namespace Tip_Dönüşümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Dönüşüm (İmplicit Conversion)

            byte a= 5;

            short b = 10;

            sbyte c = 40;

            int d = a + b+ c;

            long x = d;

            float f = x;

            string e = "Veysel";
            char v = 'V';

            object o = e+v + c + d;


            Console.WriteLine(" O' nun değeri : " + o);
            Console.WriteLine(" F ' in değeri : "+ x);

            //  Bilinçli Dönüşüm (Explicit Conversion)

            int i = 100; 

            byte j = (byte)i;

            short q = (short)i;

            Console.WriteLine("q: " + q);


            float n = 145f;

            byte p = (byte)n ;

            Console.WriteLine("p : " + p);

            // ToString Metodu 
            int xx = 66;

            string yy = xx.ToString();

            Console.WriteLine("yy :" + xx);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz : " + zz);

            // System.Convert

            string s1 = "10", s2 = "30 ";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            toplam = sayi1 + sayi2;

            Console.WriteLine("Toplam : "+toplam);

            // Parse Methodu 
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin1 = "102";
            string metin2 = "101";
            int rakam1;
            double double1;

            rakam1  =  Int32.Parse(metin1);
            double1 =  Double.Parse(metin2);

            Console.WriteLine("Rakam :" + rakam1);
            Console.WriteLine("Double :" + double1);

        
        }
    }
}
