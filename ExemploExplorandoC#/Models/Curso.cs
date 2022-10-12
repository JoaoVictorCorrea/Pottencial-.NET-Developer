using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorandoC_.Models
{
    public class Curso
    {
        public Curso(){

        }

        public Curso(string nome){

            Nome = nome;
            Alunos = new List<Pessoa>();
        }
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){

            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados(){

            int quantidade = Alunos.Count;

            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno){

            return Alunos.Remove(aluno);;
        }

        public void ListarAlunos(){

            Console.WriteLine($"Alunos do curso de {Nome}:");

            for (int i = 0; i < Alunos.Count; i++){

                string texto = $"{i + 1} - {Alunos[i].NomeCompleto}";

                Console.WriteLine(texto);
            }
        }
    }
}