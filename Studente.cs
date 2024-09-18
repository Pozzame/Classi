class Studente : Persona
{
    public string? corso;

    public Studente(string nome, string cognome, int age, string corso) : base(nome, cognome, age)
    {
        this.corso = corso;
    }

    public override void Stampa()
    {
        base.Stampa();
        Console.WriteLine("Corso: " + corso);
    }

    public override void Parla()
    {
        Console.WriteLine("I Love C#!!");
    }
}