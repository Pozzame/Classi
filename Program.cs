﻿class Program
{
    static void Main(string[] args)
    {
        Persona p = new Persona("Mario", "Rossi", 30);
        p.Stampa();
        Studente s = new Studente("Matteo", "Bianchi", 43, "Informatica");
        s.Stampa();
        s.StampaCorso();

        Dado d1 = new Dado();
        Dado d2 = new Dado();

        int n1 = d1.Lancia();
        int n2 = d2.Lancia();

        Console.WriteLine("Dado 1: " + n1);
        Console.WriteLine("Dado 2: " + n2);
    }
}