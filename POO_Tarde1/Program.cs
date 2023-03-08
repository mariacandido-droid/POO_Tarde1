// See https://aka.ms/new-console-template for more information
using POO_Tarde1;

Produto p1 = new Produto(1,"Mouse xing ling", 10.9M);
Produto p2 = new Produto(2, "Teclado multilaser", 20.9M);

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
Console.WriteLine(p2.getDescricao() + " " + p2.getValor());

p1.setValor(29.9M);
p1.setDescricao("Mouse Razor");

Console.WriteLine(p1.getDescricao() + " " + p1.getValor());
