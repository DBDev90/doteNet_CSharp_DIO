using ExemploFundamentos.Common.models;

// Pessoa pessoa = new Pessoa();

// pessoa.Nome = "Douglas Bordinassi";
// pessoa.Idade = 32;
// pessoa.Apresentar();

// // OPERADOR DE ATRIBUIÇÃO
// // int a = 10;
// // int b = 20;
// // int c = a + b;

// // // c = c + 5;
// // // c += 5;
// // // c -= 5;
// // // c *= 5;
// // c /= 5;
// // Console.WriteLine(c);

// // convertendo tipos
// int a = Convert.ToInt32("5");
// Console.WriteLine(a);

// int b = int.Parse("25");
// Console.WriteLine(a);

// // DIFERENTE ENTRE CONVERT E PARSE
// /*
//     Ao tratar "valores" NULL, o Convert irá retornar o valor 0, enquanto o Parse irá apresentar um erro que não possível converter.
//     Recomendável sempre utilizar o Convert.
// */

// // CONVERTENDO PARA STRING
// int interiro = 50;
// string c = interiro.ToString();

// Console.WriteLine(c);

// // CAST IMPLÍCITO
// int d = 30;
// double e = d;

// // double suporta valores inteiros, portanto não é necessário realizar a conversão.

// Console.WriteLine(e);

// // ORDEM DOS OPERADORES
// double aB = 4 / 2 + 2;
// double aBa = 4 / (2 + 2);
// Console.WriteLine(aB);
// Console.WriteLine(aBa);

// // CONVERTENDO DE MANEIRA SEGURA
// string bA = "15-";
// // int cD = Convert.ToInt32(bA);
// int cD = 0;

// int.TryParse(bA, out cD);

// Console.WriteLine(cD);

// // OPERADORES CONDICIONAIS
// int quantidadeEstoque = 10;
// int quantidadeCompra = 4;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");

// if (quantidadeEstoque >= quantidadeCompra)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("A quantidade em estoque é inferior a de compra");
// }

// // SWITCH CASE
// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Consoante");
//         break;
// }

// Calculadora calculadora = new Calculadora();

// calculadora.Soma(5, 5);
// calculadora.Multiplicacao(5, 5);
// calculadora.Subtracao(5, 4);
// calculadora.Divisao(25, 5);
// calculadora.Potencia(25, 5);
// calculadora.Seno(30);
// calculadora.Coseno(30);
// calculadora.Tangente(30);
// calculadora.RaizQuadrada(9);

// int numero = 16;


// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 72;
// arrayInteiros[1] = 62;
// arrayInteiros[2] = 50;

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// // COPIANDO UM ARRAY PARA OUTRO
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// for (int i = 0; i <= arrayInteiros.Length; i++)
// {
//     console.WriteLine($"Posição n {i} = {arrayInteiros[i]}");
// }

// foreach (int valor in arrayInteiros)
// {
//     console.WriteLine(valor);
// }

// LISTAS
List<string> listaString = new List<string>();
listaString.Add("SP", "BA", "MG");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"Posição n: {i} - {listaString[i]}");
}

int contador = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição n: {contador} - {item}");
    contador++;
}