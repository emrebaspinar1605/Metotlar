// See https://aka.ms/new-console-template for more information
int a=2,b=3;
string yazi="Deneme";
int sonuc=Topla(a,b);

    System.Console.WriteLine(a+b);
    System.Console.WriteLine(sonuc);

Metotlar ornek= new Metotlar();
    ornek.EkranaYazdir(yazi);

static int Topla(int deger1,int deger2)
{
    return deger1+deger2;
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        System.Console.WriteLine(veri);
    }
}