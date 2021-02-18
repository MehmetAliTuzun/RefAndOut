using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //Buradaki yazdığımız kodda Add metodu n1 için "30" değerini kullanıyor.
        //Ama kod kendi içersinde sadece n1 değerini yazdırmak istese "40" değerini kullanır.

        int n1 = 40;
        int n2 = 60;
        var r1 = Add(n1, n2);
        Console.WriteLine(r1);
        Console.WriteLine(n1);

        Console.WriteLine("-------------------------------------------------------");
       


        //Eğer yazılımcı n1 değerini tek başına "30" olarak yazdırmak istiyorsa "ref" anahtar kelimesini kullanmalıdır.
        //Aşağıdaki kodda n1 için çıktı "30" olacaktır.

        int n11 = 40;
        int n22 = 60;
        var r11 = Add2(ref n11, n22);
        Console.WriteLine(r11);
        Console.WriteLine(n11);

        Console.WriteLine("-------------------------------------------------------");


        //"ref" anahtar kelimesi kod içersinde n1 değeri için bir değer erilmiş olmasını ister. (bkz. "int n1 = 40")

        //Eğer yazılımcı ref anahtar kelimesindeki işlemin aynısını yapmak istiyor ama kod içersinde n1 değişkenine bir değer atamak istemiyorsa "out" anahtar kelimesini kullanmalıdır.
        // "out" anahtar kelimesi de ref anahtar kelimesinin aynısını yapar fakat farkı n1 değişkenine değer atama zorunluluğunu kaldırmasıdır.

        int n222 = 60;
        var r111 = Add3(out int n111, n222);
        Console.WriteLine(r111);
        Console.WriteLine(n111);
        Console.ReadLine();


    }



    static int Add(int n1, int n2)
    {
        n1 = 30;
        return n1 + n2;

    }

    static int Add2(ref int n11, int n22)
    {
        n11 = 30;
        return n11 + n22;

    }

    static int Add3(out int n111, int n222)
    {
        n111 = 30;
        return n111 + n222;

    }



}