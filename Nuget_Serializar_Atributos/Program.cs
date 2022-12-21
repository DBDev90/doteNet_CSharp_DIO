using Nuget_Serializar_Atributos.models;
using Newtonsoft.Json;

// DateTime dataVenda = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material", 25.00M, dataVenda);
// Venda v2 = new Venda(2, "Material", 225.00M, dataVenda);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVendas);

// File.WriteAllText("archives/vendas.json", serializado);

// Console.WriteLine(serializado);

string conteudoArquivo = File.ReadAllText("archives/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda item in listaVenda)
{
    Console.WriteLine($"Id: {item.Id}\n Produto: {item.Produto}\n Preço: {item.Preco}\n Data de Compra: {item.DataVenda.ToString("dd/MM/yyy HH:mm")}");
}