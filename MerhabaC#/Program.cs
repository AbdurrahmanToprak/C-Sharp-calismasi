﻿//karşılaştırma
int yas1;

Console.Write("Yasiniz: ");
yas1 = Convert.ToInt32(Console.ReadLine());

if(yas1 >=18){
    Console.WriteLine("Siteye Girebilirsiniz");
}
else if(yas1 <= 0){
    Console.WriteLine("Hatali deger!");
}
else{
        Console.WriteLine("Siteye Giremezsiniz");

}
//dongu
int sayi = 1;
while(sayi <= 5 ){
    Console.WriteLine(sayi);
    sayi++;
}

//Kullanıcıdan isim ve yaş al ekrana yazdır
string ad;
int yas;

Console.Write("isminiz: ");
ad = Console.ReadLine();
Console.Write("Yas : ");
yas = Convert.ToInt32(Console.ReadLine());
Console.Write(ad + " " + yas + " Yasinda");


//Kullanıcıdan iki sayı al kalanı ekrana yazdır
int x;
int y;

Console.Write("1.sayi: ");
x = Convert.ToInt32(Console.ReadLine());
Console.Write("2.sayi : ");
y = Convert.ToInt32(Console.ReadLine());
Console.Write(x % y);

//Matematik işlemleri

Console.WriteLine(Math.Pow(2,4)); //us alma
Console.WriteLine(Math.Sqrt(4)); //karekok
Console.WriteLine(Math.Abs(4)); //0 a Uzaklık
Console.WriteLine(Math.Round(4.3)); //Yuvarlama
Console.WriteLine(Math.Min(4,3)); //min sayı
Console.WriteLine(Math.Max(4,3)); //max sayı



