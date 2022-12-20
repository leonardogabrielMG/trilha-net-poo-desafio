using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("NOKIA");
Nokia nokia = new Nokia("987654321", "G21", "1234", 32);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Clash of Clans");

Console.WriteLine("\nIphone");

Iphone iphone = new Iphone("912345678", "X", "9630", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Plague Inc");