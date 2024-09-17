class Dado
{
    private Random rand = new Random();

    public int Lancia()
    {
        return rand.Next(0,7);
    }
}