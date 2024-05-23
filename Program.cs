using DesafioPOO.Models;

var nokia = new Nokia("21967716224", "123", 100);
var iphone = new Iphone("2197734213", "1232321", 120);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whats App");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");