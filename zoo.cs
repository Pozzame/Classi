abstract class Animale
{
    internal string? specie;
    public string Specie { get => specie!; }
    public virtual void Parla(){
        Console.Write($"{Specie} fa: ");
    }
}

class Mucca : Animale
{
    public Mucca(){
        specie = "Mucca";
    }
    public override void Parla(){
        base.Parla();
        Console.Write("Muu.\n");
    }
}

class Maiale : Animale{
    public Maiale(){
        specie = "Maiale";
    }
    public override void Parla()
    {
        base.Parla();
        Console.Write("Oink.\n");
    }
}
class Capra : Animale
{
    public Capra()
    {
        specie = "Capra";
    }
    public override void Parla()
    {
        base.Parla();
        Console.Write("Bee.\n");
    }
}