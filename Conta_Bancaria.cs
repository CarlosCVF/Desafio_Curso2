// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
class Conta
{
    public int IndicatorNumber{get;set;}
    public string? Holder{get;set;}
    public double Balance{get;set;}
    public int Password{get;set;}

    public void Informations()
    {
        System.Console.WriteLine($"Número de indicador: {IndicatorNumber}");
        System.Console.WriteLine($"Titular: {Holder}");
        System.Console.WriteLine($"Saldo: {Balance}");
        System.Console.WriteLine($"Senha: {Password}");
    }
}