// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Fundamentos.Models;

Calculadora calc = new Calculadora();

calc.Somar(10, 30);
calc.Subtrair(50, 20);
calc.Multiplicar(10, 20);
calc.Dividir(50, 5);
calc.Potencia(3, 3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);

Console.WriteLine("Incrementando o 10");
//numero = 10 + 1;
//numero = numero + 1;
numeroIncremento ++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine("Decrementado o 20");
//numero = 10 - 1;
numeroDecremento = numeroDecremento - 1;
//numero --;
Console.WriteLine(numeroDecremento);

calc.RaizQuadrada(100);

