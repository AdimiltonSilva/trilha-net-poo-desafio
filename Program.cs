using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(81)98837-4804", modelo: "Nokia G11 Plus NK095", imei: "202401101", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "(81)98837-4804", modelo: "iPhone 15 Pro Max", imei: "202401102", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");