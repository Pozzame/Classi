﻿class Program
{
    static void Main(string[] args)
    {
        /*
        Dado d1 = new Dado();
        Dado d2 = new Dado();
        d2.Facce= 12;

        int n1 = d1.Lancia();
        int n2 = d2.Lancia();

        Console.WriteLine("Dado 1: " + n1);
        Console.WriteLine("Dado 2: " + n2);
        */

/*
        Persona p = new Persona("Mario", "Rossi", 30);
        p.Stampa();
        Studente s = new Studente("Matteo", "Bianchi", 43, "Informatica");
        s.Stampa();
        Professore c = new Professore("Pino", "Ciuccio", 33, "Lettere");
        
        Persona[] persone = [p, s, c];
        foreach (Persona persona in persone) persona.Parla();
        */
        List<Animale> zoo = [new Mucca(), new Maiale(), new Capra(),];
        foreach (Animale animale in zoo) animale.Parla();
    }
}