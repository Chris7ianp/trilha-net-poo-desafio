using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "654321", modelo: "C21", imei: "111122222", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Iphone(numero: "654321", modelo: "5s", imei: "222221111", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");