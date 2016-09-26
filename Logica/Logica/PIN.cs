class PIN
{
    static void Main(string[] args)
    {
        for (int contador = 0; contador <= 100; contador++)
        {
            int resto = contador % 4;
            if(resto == 0)
            {
                System.Console.WriteLine("PI");
            }
            else
            {
                System.Console.WriteLine(contador);
            }
        }
    }
}