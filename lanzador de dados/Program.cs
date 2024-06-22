class program
{

    static Random random = new Random();

    static int LanzarDados()
    {
        return random.Next(1, 7);
    }

    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int dado1 = LanzarDados();
            int dado2 = LanzarDados();


            Console.WriteLine($"Dado 1: {dado1} | Dado 2: {dado2}");

            Console.Write("¿Quieres lanzar nuevamente? (s/n): ");
            string respuesta = Console.ReadLine();

            continuar = (respuesta.ToLower() == "s");
        }

        Console.WriteLine("¡Gracias por jugar!");
    }
}