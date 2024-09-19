using SistemaCelular.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia  = new Nokia("27997826942", "Lumia 920", "WW-XXXXXX-YYYYYY-Z", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("27997826952", "iPhone 16 Pro Max", "WW-XXXXXX-YYYYYY-Z", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");