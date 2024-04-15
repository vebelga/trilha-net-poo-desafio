using DesafioPOO.Models;

Console.WriteLine("Nokia");
Nokia nokia = new Nokia(numero: "123", modelo: "m1", imei: "1654as", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("Iphone");
Iphone iphone = new Iphone(numero: "321", modelo: "i1", imei: "dsa987", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");