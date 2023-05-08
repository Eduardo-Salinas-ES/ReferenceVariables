//main
using ReferenceVariables;

Elephant lucinda = new Elephant() { EarSize = 33, Name = "Lucinda" };
Elephant lloyd = new Elephant() { EarSize = 40, Name = "Lloyd" };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap, 4 improper swap, 5 send message");

while (true)
{
    //string choice = Console.ReadLine();
    Char choice = Console.ReadKey(true).KeyChar;
    Console.WriteLine("You pressed " + choice);

    if (choice == '1')
    {
        Console.WriteLine("Calling lloyd.WhoAmI");
        lloyd.WhoAmI();

    }
    else if (choice == '2')
    {
        Console.WriteLine("Calling lucinda.WhoAmI");
        lucinda.WhoAmI();
    }
    else if (choice == '3')
    {
        Elephant tempElephant;
        tempElephant = lloyd;
        lloyd = lucinda;
        lucinda = tempElephant;
        
        Console.WriteLine("References have been swapped");
    }
    else if(choice == '4')
    {
        lloyd = lucinda;
        lloyd.EarSize = 4321;
        lloyd.WhoAmI();

    }
    else if (choice == '5')
    {
        lucinda.SpeakTo(lloyd, "Hi, Lloyd");

    }
    else
    {
        return;

    }
    Console.WriteLine();
}

