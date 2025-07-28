

Console.WriteLine("HESAPLAMA UYGULAMASI");


Console.Write("1. sayıyı giriniz: " );  
double number1 = int.Parse(Console.ReadLine());
 
 
Console.Write("2. sayıyı giriniz: ");
double number2 = int.Parse(Console.ReadLine());
 
Console.Write("İşlem seçiniz ( +, -, *, /): ");
string islem = Console.ReadLine();

double sonuc;

if (islem == "+")
{
    sonuc = number1 + number2;
    Console.WriteLine(sonuc);
}

if (islem == "-")
{
    sonuc = number1 - number2;
    Console.WriteLine(sonuc);
}

if (islem == "*")
{
    sonuc = number1 * number2;
    Console.WriteLine(sonuc);
}

if (islem == "/")
{
    sonuc = number1 / number2;
    Console.WriteLine(sonuc);
}
