using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new(numero: "21999999999", modelo: "Nokia teste", imei: "222222", memoria: 128);

nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");

Iphone iphone = new(numero: "21999999999", modelo: "Nokia teste", imei: "222222", memoria: 128);

iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
