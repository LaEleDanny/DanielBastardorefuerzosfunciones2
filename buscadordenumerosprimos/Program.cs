class program
{

    static void Main()
    {
        Console.Write("Ingresa el inicio del rango: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el fin del rango: ");
        int fin = int.Parse(Console.ReadLine());

        List<int> primosEncontrados = new List<int>();

        for (int num = inicio; num <= fin; num++)
        {
            if (EsPrimo(num))
            {
                primosEncontrados.Add(num);
            }
        }

        Console.WriteLine("Números primos encontrados:");
        foreach (int primo in primosEncontrados)
        {
            Console.Write(primo + " ");
        }
    }
    public static bool EsPrimo(int numero)
{
    if (numero <= 1)
        return false; 

    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
            return false; 
    }

    return true;
}
}