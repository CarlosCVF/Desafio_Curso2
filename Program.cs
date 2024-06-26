﻿// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

// class Conta
// {
//     public int IndicatorNumber{get;set;}
//     public string? Holder{get;set;}
//     public double Balance{get;set;}
//     public int Password{get;set;}

//     public void Informations()
//     {
//         System.Console.WriteLine($"Número de indicador: {IndicatorNumber}");
//         System.Console.WriteLine($"Titular: {Holder}");
//         System.Console.WriteLine($"Saldo: {Balance}");
//         System.Console.WriteLine($"Senha: {Password}");
//     }
// }

// Conta conta = new Conta();

// Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.

// conta.indicatorNumber = 3223;
// conta.holder = "Robertito";
// conta.balance = 32132.23;
// conta.password = 11029300;

// System.Console.WriteLine($"Número de indicador: {indicatorNumber}");
// System.Console.WriteLine($"Titular: {holder}");
// System.Console.WriteLine($"Saldo: {balance}");
// System.Console.WriteLine($"Senha: {password}");

// Desenvolver um método da classe Conta que exibe suas informações.

// conta.Informations();

// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

// class Carro()
// {
//     private int year;
//     public int Velocity {get; set;}
//     public string? Manufacturer { get; set; }
//     public string? CarModel { get; set; }
//     public int Year 
//     { 
//         get => year;

//         set
//         {
//             if (value < 1960 || value > 2023)
//             {
//                 System.Console.WriteLine("Ano inválido!!");
//             }
//             else
//             {
//                 year = value;
//             }
//         } 
//     }

//     public string Description => 
//         $"O carro {this.CarModel} da marca {this.Manufacturer} foi feito no ano de {this.Year}";

//     public void Acelerate()
//     {
//         Velocity += 1;
//         System.Console.WriteLine(Velocity);
//     }
//     public void Brake()
//     {
//         Velocity -= 1;
//         System.Console.WriteLine(Velocity);
//     }
//     public void Honk()
//     {
//         System.Console.WriteLine("BIIIIIIIIIIIIIIIIIIIIIIIIIII");
//     }
// }

// Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.

// conta.IndicatorNumber = 3223;
// conta.Holder = "Robertito";
// conta.Balance = 32132.23;
// conta.Password = 11029300;

// Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

//Done

// Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

//Done

// Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque. Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.
// class Produto
// {
//     private double price;
//     private int stock;
//     public string? name;
//     public string? brand;
//     public double Price
//     {
//         get => price;
//         set
//         {
//             if (value < 0)
//             {
//                 System.Console.WriteLine("Preço inválido!!");
//             }
//             else
//             {
//                 price = value;
//             }
//         }
//     }
//     public int Stock
//     {
//         get => stock;
//         set
//         {
//             if(value < 0 )
//             {
//                 System.Console.WriteLine("Número de estoque inválido!!");
//             }
//             else
//             {
//                 stock = value;
//             }
//         }
//     }

//     public string? DetailedDescription => 
//     $"Tem {stock} {name} da marca {brand} no estoque, o preço de cada um é de {price}";
// }

// No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções. Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma, como mostra o trecho de código a seguir:

// public int Somar(int a, int b)
// {
//     int resultado = a + b;
//     return resultado;
// }]
//Agora é sua vez! Refaça esse método Somar() usando uma função lambda retornando o resultado da operação.

// public int Somar(int a, int b)=> a + b;

// Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.

// class Titular
// {
//     public string nome;
//     public long cpf;
//     public Titular(string nome, long cpf)
//     {
//         this.nome = nome;
//         this.cpf = cpf;
//     }
// }

// class Conta
// {
//     public Titular? titular;
//     public string? agencia;
//     public int numeroConta;
//     public double saldo;
//     public double limite;

//     public void ExibirDetalhes(Titular titular, Conta conta)
//     {
//         System.Console.WriteLine($"Nome do titular: {titular.nome}\nCPF do titular: {titular.cpf}");
//         System.Console.WriteLine($"Agência: {conta.agencia}\nNúmero da conta: {conta.numeroConta}");
//         System.Console.WriteLine($"Saldo disponível: {conta.saldo}\nLimite disponível: {conta.limite}");
//     }
// }

// Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
// class Program
// {
//     static void Main(string[] args)
//     {
//         Conta conta = new Conta();
//         Titular titular = new Titular("João", 34855713613);
//         conta.agencia = "007";
//         conta.numeroConta = 123013;
//         conta.saldo = 65481.20;
//         conta.limite = 2000000.00;
//         conta.ExibirDetalhes(titular,conta);
//     }
// }

// Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

// class Produto
// {
//     private double preco;
//     private int stock;
//     public string Nome {get;set;}
//     public double Preco
//     {
//         get => preco;
//         set
//         {
//             if(value > 0)
//             {
//                 preco = value;
//             }
//             else
//             {
//                 preco = 10;
//             }
//         }
//     }
//     public int Stock
//     {
//         get => stock;
//         set
//         {
//             if (value > 0)
//             {
//                 stock = value;
//             }
//             else
//             {
//                 stock = 0;
//             }
//         }
//     }
//     public string? Marca {get;set;}
//     public string Descricao => $"{this.Nome} {this.Marca} - {this.Preco} - Quantidade: {this.Stock}";
// }
// public class EstoqueDeProdutos
// {
//     List<Produto> Produtos {get;set;} = new List<Produto>();
//     public void AdicionarProduto(Produto produto)
//     {
//         Produtos.Add(produto);
//         System.Console.WriteLine("Produto adicionado com sucesso");
//     }
//     public void ExibirProdutos ()
//     {
//         if (Produtos.Count == 0)
//         {
//             System.Console.WriteLine("Nenhum produto encontrado");
//         }
//         else
//         {
//             Console.WriteLine("Produtos encontrados no estoque:");
//             foreach (var produto in Produtos)
//             {
//                 System.Console.WriteLine(produto);
//             }
//         }
//     }
// }

// Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.

// public class Aluno
// {
//     public string nome;
//     public int idade;
//     public double nota;

// }
// public class Professor
// {
//     public string nome;
//     pulbic List<Disciplina> disciplinas = new List<Disciplina>();

// }
// public class Disciplina
// {
//     public string nome;
//     public List<Aluno> alunos = new List<Aluno>(); 
// }

// Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.
// class Restaurante
// {
//     public string nome;
//     public List<Mesa> Mesas { get; set; } = new List<Mesa>();
//     public Cardapio Cardapio { get; set; } = new Cardapio();
// }
// class Mesa
// {
//     public int numeroDaMesa;
//     public List<Pedido> pedidos = new List<Pedido>();
// }
// class Pedido
// {
//     public ProdutoRestaurante Produto { get; set; }
//     public int Quantidade { get; set; }
// }
// class Cardapio
// {
//     List<ProdutoRestaurante> Produtos {get;set;}= new List<Produto>();
// }
// class ProdutoRestaurante
// {
//     public string nomeDoProduto;
//     public double valorProduto;
// }

// //Criar um construtor para a classe Titular, que inicialize todas suas propriedades:
// class Titular
// {
//     public Titular(string nome, string cpf, string endereco)
//     {
//         Nome = nome;
//         Cpf = cpf;
//         Endereco = endereco;
//     }

//     public string Nome {get;}
//     public string Cpf {get;}
//     public string Endereco {get;}
// }

//Criar um construtor para a classe Conta, que inicialize todas suas propriedades:
// class Conta
// {
//     public Conta(Titular titular, int agencia, int numeroDaConta, double saldo, double limite)
//     {
//         Titular = titular;
//         Agencia = agencia;
//         NumeroDaConta = numeroDaConta;
//         Saldo = saldo;
//         Limite = limite;
//     }

//     public Titular Titular {get;}
//     public int Agencia {get;}
//     public int NumeroDaConta {get;}
//     public double Saldo {get;}
//     public double Limite {get;}

//     public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
//}
//Instanciar uma Conta e exibir suas informações na tela, utilizando construtores.
// class Program {
//     public static void Main (string[] args) 
//     {
//         Titular titular1 = new("Rodrigo", "35186461", "Rua Monte Negro");
//         Conta conta = new(titular1, 012, 65181, 600.54, 8000.20);
//         System.Console.WriteLine(conta.Informacoes);
//     }
// }
//Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

// class Game
// {
//     public Game(string name, string genre, int releaseYear)
//     {
//         Name = name;
//         Genre = genre;
//         ReleaseYear = releaseYear;
//     }

//     public string Name{get;}
//     public string Genre{get;}
//     public int ReleaseYear{get;}
// }
// class GameList
// {
//     private List<Game> Games {get; set;}
//     public bool EmptyList => Games.Count == 0;
//     public GameList()
//     {
//         Games = new List<Game>();
//     }
//     public void AddGame(string name, string genre, int releaseYear)
//     {
//         Game newGame = new Game(name,genre,releaseYear);
//         Games.Add(newGame);
//         System.Console.WriteLine("Novo Jogo adicionado");
//     }
//     public void ShowGames()
//     {
//         if (EmptyList)
//         {
//             System.Console.WriteLine("O catálogo de jogos esta vazio");
//         }
//         else
//         {
//             System.Console.WriteLine("Catálogo de Jogos:\n");
//             foreach(var game in Games)
//             {
//                 System.Console.WriteLine($"Nome: {game.Name}\nGênero: {game.Genre}\nLançado em: {game.ReleaseYear}");
//             }
//         }
//     }
// }