using ExemploPOO.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "João Victor";
p1.Idade = 19;

p1.Apresentar();

Console.WriteLine("");

ContaCorrente c1 = new ContaCorrente(123, 1000);

c1.ExibirSaldo();
c1.Sacar(5000);
c1.ExibirSaldo();

Console.WriteLine("");

Aluno a1 = new Aluno();

a1.Nome = "Yuri";
a1.Idade = 21;
a1.Nota = 9.99;

a1.Apresentar();

Console.WriteLine("");

Professor prof1 = new Professor();

prof1.Nome = "Anderson";
prof1.Idade = 33;
prof1.Salario = 10.000M;

prof1.Apresentar();