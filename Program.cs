using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("12345", "Nokia G21", "Nokia", 128);
        Smartphone iphone = new Iphone("67890", "iPhone 13", "Apple", 256);

        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
