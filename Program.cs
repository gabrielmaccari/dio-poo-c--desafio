using DesafioPOO.Models;

Iphone xr = new Iphone("99999999999", "XR", "1234567890", 64);
xr.InstalarAplicativo("WhatsApp");
xr.Ligar();
xr.ReceberLigacao();

Nokia nokia = new Nokia("88888888888", "3310", "0987654321", 16);
nokia.InstalarAplicativo("Snake");
nokia.Ligar();
nokia.ReceberLigacao();