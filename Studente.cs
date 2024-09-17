class Studente : Persona
{
    public string? corso;

    public Studente(string nome, string cognome, int age, string corso) : base(nome, cognome, age)
    {
        this.corso = corso;
    }

    public void StampaCorso()
    {
        Console.WriteLine("Corso: " + corso);
    }
}