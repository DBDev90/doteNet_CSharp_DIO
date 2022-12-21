using Tuplas_OpeTernario_Destructuring.models;
// // TUPLAS
// (int id, string nome, string sobrenome, decimal altura) tupla = (1, "Douglas", "Bordinassi", 1.82M);

// Console.WriteLine($"ID: {tupla.id}");
// Console.WriteLine($"Nome: {tupla.nome}");
// Console.WriteLine($"Sobrenome: {tupla.sobrenome}");
// Console.WriteLine($"Altura: {tupla.altura}");

LeituraArquivo arquivo = new LeituraArquivo();

var (Sucesso, linhasArquivo, QuantidadeLinhas) = arquivo.LerArquivo("archives/arquivoLeitura.txt");

if (Sucesso)
{
    Console.WriteLine($"Quantidade de linhas: {QuantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}