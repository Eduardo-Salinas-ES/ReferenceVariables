//main
using ReferenceVariables;


Elephant lucinda = new Elephant() { EarSize = 33, Name = "Lucinda" };
Elephant lloyd = new Elephant() { EarSize = 40, Name = "Lloyd" };

Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");

while (true)
{
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("You pressed 1\nCalling lloyd.WhoAmI");
        lloyd.WhoAmI();

    }
    else if (choice == "2")
    {
        Console.WriteLine("You pressed 2\nCalling lucinda.WhoAmI");
        lloyd.WhoAmI();
    }
    else if (choice == "3")
    {
        Elephant tempElephant = lucinda;
        lloyd = tempElephant;
        lucinda = lloyd;
     
        Console.WriteLine("You pressed 3\nReferences have been swapped");
        
    }
    else
    {
        Console.WriteLine("Your entry was invalid, press space to try again or enter to quit");
        string chooseAgain =  Console.ReadLine();
        if (chooseAgain == "") { return; }
        else { Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap"); }

    }
}


