using Propriedades_Metodos_Construtores.models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Douglas";
// p1.Sobrenome = "Bordinassi";

// Pessoa p2 = new Pessoa();
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Queiroz";

// Curso CursoDeIngles = new Curso();
// CursoDeIngles.Nome = "Ingles";
// CursoDeIngles.Alunos = new List<Pessoa>();

// UTILIZANDO CONSTRUTOR
Pessoa p1 = new Pessoa(nome: "Douglas", sobrenome: "Bordinassi");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Queiroz");

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();