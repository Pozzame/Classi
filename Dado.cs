using System.Runtime.CompilerServices;

class Dado
{
    private Random rand = new Random();
    private int facce;

    public Dado( int facce = 4 )
    {
        this.facce = facce;
    }

    public int Lancia()
    {
        return rand.Next(0,facce+1);
    }
}