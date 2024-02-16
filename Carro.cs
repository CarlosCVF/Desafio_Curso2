// Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada, que mostra o fabricante, modelo e ano do carro.

// Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

class Carro()
{
    private int year;
    public int Velocity {get; set;}
    public string? Manufacturer { get; set; }
    public string? CarModel { get; set; }
    public int Year 
    { 
        get => year;
        
        set
        {
            if (value < 1960 || value > 2023)
            {
                System.Console.WriteLine("Ano inválido!!");
            }
            else
            {
                year = value;
            }
        } 
    }

    public string Description => 
        $"O carro {this.CarModel} da marca {this.Manufacturer} foi feito no ano de {this.Year}";

    public void Acelerate()
    {
        Velocity += 1;
        System.Console.WriteLine(Velocity);
    }
    public void Brake()
    {
        Velocity -= 1;
        System.Console.WriteLine(Velocity);
    }
    public void Honk()
    {
        System.Console.WriteLine("BIIIIIIIIIIIIIIIIIIIIIIIIIII");
    }
}