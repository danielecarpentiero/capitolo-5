int num1;
int num2;
bool exit = false;
Console.WriteLine("Inserisci due numeri e una lettera");
while (!exit)
{
    if (int.TryParse(Console.ReadLine(), out num1) && int.TryParse(Console.ReadLine(), out num2))
    {
        char c = char.ToUpper(Console.ReadKey().KeyChar);
        switch (c)
        {
            case 'S':
                Console.WriteLine($"la somma è {num1 + num2}");
                break;
            case 'M':
                Console.WriteLine($"la moltiplicazione è {num1 * num2}");
                break;
            case 'X':
                exit = true;
                break;
            default:
                Console.WriteLine("Inserire S per somma, M per moltiplicare, X per uscire");
                break;
        }
    }
    else
    {
        char c = char.ToUpper(Console.ReadKey().KeyChar);
        if (c == 'x')
        {
            exit = true;
        }
        else
        {
            Console.WriteLine("Input non valido");
        }
    }
}
