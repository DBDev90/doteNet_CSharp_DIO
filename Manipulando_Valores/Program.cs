using Manipulando_Valores.models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //obriga o sistema ser de uma cultura fixa

// UTILIZANDO CONSTRUTOR
Pessoa p1 = new Pessoa(nome: "Douglas", sobrenome: "Bordinassi");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Queiroz");

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();

// ***************
Console.WriteLine("****************************************");
// FORMATANDO VALORES MONERÁRIOS
decimal valorMonetario = 82.40M;
// Console.WriteLine($"{valorMonetario:c}");
Console.WriteLine(valorMonetario.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))); //faz com que o valor seja exibido em uma cultura específica, diferente da do sistema

// PORCENTAGEM
double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P"));

// FORMATAÇÃO PERSONALIZADA
int numero = 123456789;
Console.WriteLine(numero.ToString("###-###-###"));

Console.WriteLine("\n\n");
Console.WriteLine("****************************************");
Console.WriteLine("****************************************");
Console.WriteLine("\n\n");

// FORMATANDO DATETIME
DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/mm/yyy"));
Console.WriteLine(data.ToString("dd/MM/yyy HH:mm"));

Console.WriteLine("\n\n");
Console.WriteLine("****************************************");
Console.WriteLine("****************************************");
Console.WriteLine("\n\n");

string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2);

if (sucesso)
{
    Console.WriteLine($"Conversão com sucesso!\nData: {data2}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida!");
}