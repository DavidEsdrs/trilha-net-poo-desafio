using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new("3123123132", "Nokia N1", "9021090583284312");
Iphone p1 = new("3123123132", "Iphone 11", "9021090583284312");

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Facebook");

p1.Ligar();
p1.ReceberLigacao();
p1.InstalarAplicativo("Instagram");