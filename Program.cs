// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.

Conta conta = new Conta();

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

conta.Informations();

// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

//Done

// Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.

conta.IndicatorNumber = 3223;
conta.Holder = "Robertito";
conta.Balance = 32132.23;
conta.Password = 11029300;

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

public int Somar(int a, int b)=> a + b;
