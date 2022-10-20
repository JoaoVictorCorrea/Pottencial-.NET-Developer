using ExemploExplorandoC_.Models;

//---------------------- Treinando Propriedades, Métodos e Construtores --------------------------------

Pessoa p1 = new Pessoa(nome: "João", sobrenome: "Corrêa");
Pessoa p2 = new Pessoa(nome: "Vitor", sobrenome: "Pereira");

Curso cursoDeIngles = new Curso(nome: "Inglês");

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

//---------------------- Treinando Exceções(Leitura de um arquivo) --------------------------------

try{

    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach(string linha in linhas){

        Console.WriteLine(linha);
    }
}
catch(FileNotFoundException ex){

    Console.WriteLine($"Ocorreu um erro ao ler arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex){

    Console.WriteLine($"Ocorreu um erro ao ler arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex){

    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
finally{

    Console.WriteLine("Fim da leitura do arquivo.");
}

new ExemploExcecao().Metodo1();

//---------------------- Treinando Coleções --------------------------------

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(7);
fila.Enqueue(12);

foreach(int item in fila){

    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach(int item in fila){

    Console.WriteLine(item);
}

Console.WriteLine();

Stack<int> pilha = new Stack<int>();

pilha.Push(55);
pilha.Push(12);
pilha.Push(10);
pilha.Push(108);

foreach(int item in pilha){

    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

foreach(int item in pilha){

    Console.WriteLine(item);
}

Console.WriteLine();

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

foreach (KeyValuePair<string, string> item in estados){

    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
Console.WriteLine();

foreach (KeyValuePair<string, string> item in estados){

    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados["SP"] = "São Paulo - valor alterado";
Console.WriteLine();

foreach (KeyValuePair<string, string> item in estados){

    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine();

string chave = "SP";
Console.WriteLine($"Verificando o elemento: {chave}");

if(estados.ContainsKey(chave))
    Console.WriteLine($"Valor existente: {chave}");
else
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");

Console.WriteLine();

Console.WriteLine(estados["MG"]);