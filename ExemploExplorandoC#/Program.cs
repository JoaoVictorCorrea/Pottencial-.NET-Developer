using ExemploExplorandoC_.Models;
using Newtonsoft.Json;

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

//------------------------------------------------------

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

//------------------------------------------------------

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

Console.WriteLine();

//---------------------- Treinando Serialização e Deserialização --------------------------------


//Serialização

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Caneta Bic", 1.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented); //escrevendo em JSON

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);


//Deserialização

string conteudoArquivo = File.ReadAllText("Arquivos/vendasLeitura.json"); //lendo um arquivo em JSON

List<Venda> listaLeituraVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaLeituraVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto} - Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
}

Console.WriteLine();

//---------------------- Treinando Tipos Especias --------------------------------

var listaAnonimo = listaVendas.Select(x => new { x.Produto, x.Preco });

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
}

Console.WriteLine();

//------------------------------------------------------

dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Teste";
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

Console.WriteLine();

//------------------------------------------------------

MeuArray<int> arrayInteiro = new MeuArray<int>();

arrayInteiro.AdicionarElementoArray(30);

Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new MeuArray<string>();

arrayString.AdicionarElementoArray("Brasil");

Console.WriteLine(arrayString[0]);

Console.WriteLine();

//------------------------------------------------------

int numero = 15;

string mensagem = $"O número {numero} é {(numero.VerificarPar() ? "par" : "impar")}";

Console.WriteLine(mensagem);