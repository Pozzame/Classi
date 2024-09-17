class Persona
{
    private string? nome;
    private string? cognome;
    private int age;

    public string Nome { get { return nome!; } set { nome = value; } }
    public string Cognome { get { return cognome!; } set { cognome = value; } }
    public int Age { get { return age; } set { age = value; } }

    public Persona(string nome, string cognome, int age)
    {
        this.Nome = nome;
        this.Cognome = cognome;
        this.Age = age;
    }

    public void Stampa()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cognome: {Cognome}");
        Console.WriteLine($"Età: {Age}");
    }

    public virtual void Parla()
    {
        Console.WriteLine("Ciao!");
    }
}