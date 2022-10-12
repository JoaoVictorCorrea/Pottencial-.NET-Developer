using ExemploExplorandoC_.Models;

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Corrêa");
Pessoa p2 = new Pessoa(nome: "Vitor", sobrenome: "Pereira");

Curso cursoDeIngles = new Curso(nome: "Inglês");

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();