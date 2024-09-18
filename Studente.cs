class Studente : Persona
{
    private string? corso;

    public string? Corso { get => corso; set => corso = value; }

    public Studente(string nome, string cognome, int age, string corso) : base(nome, cognome, age)
    {
        this.Corso = corso;
    }

    public override void Stampa()
    {
        base.Stampa();
        Console.WriteLine("Corso: " + Corso);
    }

    public override void Parla()
    {
        Console.WriteLine("I Love C#!!");
    }
}