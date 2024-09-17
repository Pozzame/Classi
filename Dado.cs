using System.Runtime.CompilerServices;

class Dado
{
    private Random rand = new Random();
    private int facce;

    public Dado(int facce = 4)
    {
        this.Facce = facce;
    }

    public int Facce { get { return facce; } set { facce = value; } }

    public int Lancia()
    {
        return rand.Next(1, Facce + 1);
    }
}