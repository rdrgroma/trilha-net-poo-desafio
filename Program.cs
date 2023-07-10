using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Zapzap");

Console.WriteLine("\n\n");

Smartphone iphone = new Nokia("654321", "Modelo 2", "222222222", 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("VaptVupt");