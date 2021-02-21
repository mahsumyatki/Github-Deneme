using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //değer tipler : sayısal veri tipleri (int,double,float,...), boolean veri tipleri
            //referans tipler : array,class,interface

            /*
             Bellekte stack ve heap diye iki alan vardır. Şimdi değer tip tanımlandığında ve ona bir değer verildiğinde stack içerisinde gerçekleşir.
             number1=20 ve number2=50 olur. number1 = number2 dendiğinde number1=50 olur. Sonra number2=80 olur.
             Düz mantık gibi çalışır. Ama referans tiplerde işler böyle değildir.
             */

            int number1 = 20;
            int number2 = 50;
            number1 = number2;
            number2 = 80;
            Console.WriteLine(number1); //number1=50

            /*
             * 
             Referans tiplerde ise hem stack hem de heap kullanılır. Burada int numbers1 denildiğinde stack içerisinde numbers1 diye bir değişken oluşur.
             Devamında new denildiğinde heap içerisinde yeni bir alan oluştur ve değerleri oraya yaz demek olur. Bu heap içerisinde bir adrese sahip olur.
             Sonra numbers2 dizisi tanımlandığında stack içerisinde numbers2 adında bir değişken oluşur ve new dendiği gibi aynı şekilde heap içerisinde yeni bir alan
             oluşur ve değerleri içerisine yazılır. Örneğin numbers1 in heap içerisindeki adresi 150, numbers2 nin adresi ise 200 olsun. 

            numbers1=numbers2 (referans bazlı atama) dediğimiz anda numbers2 nin adresi ve içindeki değerler numbers1 içerisine atanır.
            Artık numbers1 in adresi 200 dür ve o adreste yapılan değişiklikler numbers1 için de geçerli olacaktır.
            numbers2[0]=555 yapıldığında o adresteki ilk eleman 555 olacaktır ve otomatik olarak numbers1 o adresten referans aldığı için numbers1 in
            ilk elemanı olacaktır.
             */

            int[] numbers1 = new int[] { 15, 25, 35 };
            int[] numbers2 = new int[] { 150, 250, 350 };
            numbers1 = numbers2;
            numbers2[0] = 555;
            Console.WriteLine(numbers1[0]);// numbers1[0]=555
            Console.ReadLine();
        }
    }
}
