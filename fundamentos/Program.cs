// using fundamentos.models;

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