
static void Repeat()
{
    Console.WriteLine("Would you like to repeat (y/n)");

    if (char.TryParse(Console.ReadLine(), out char result))
    {
        char response = char.Parse(Console.ReadLine().ToLower());
        if (response == 'y')
        {
            Main();
        }
        else if (response == 'n')
        {
            Console.WriteLine("Goodbye");
        }
    }
    else
    {
        Console.WriteLine("I'm sorry, I didn't understand. Would you like to learn about another student?(y/n)");
        Repeat();
    }
}
