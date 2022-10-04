using ExemploFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();
Calculadora calculadora = new Calculadora();

pessoa1.Nome = "João";
pessoa1.Idade = 19;
pessoa1.Apresentar();

calculadora.Somar(30, 10);
calculadora.Subtrair(30, 10);
calculadora.Multiplicar(30, 10);
calculadora.Dividir(30, 10);
calculadora.Potencia(2, 10);
calculadora.Seno(45);
calculadora.Coseno(45);
calculadora.Tangente(45);
calculadora.RaizQuadrada(49);