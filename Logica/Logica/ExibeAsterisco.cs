class ExibeAsteriscos
{
    static void Main(string[] args)
    {
        for (int contador = 0; contador <=100 ; contador++)
        {
            int resto = contador % 2;
            if(resto == 1)
            {
                System.Console.WriteLine("*");
            }
            else
            {
                System.Console.WriteLine("**");
            }
        }
    }
}