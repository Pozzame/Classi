class Program
{
    static void Main(string[] args)
    {
        Persona p = new Persona("Mario", "Rossi", 30);
        p.Stampa();
        Studente s = new Studente("Mateo", "Bianchi", 43, "Informatica");
        s.Stampa();
        s.StampaCorso();
    }
}