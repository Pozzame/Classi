class Professore : Studente
{
    public Professore(string nome, string cognome, int age, string corso) : base(nome, cognome, age, corso)
    {

    }

    public override void Parla(){
        Console.WriteLine("Ti do DDUE!!!");
    }
}