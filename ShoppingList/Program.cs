Dictionary<string, decimal> menu = new Dictionary<string, decimal>();
menu.Add("apple", .99m);
menu.Add("banana", .59m);
menu.Add("cauliflower", 1.59m);
menu.Add("dragonfruit", 2.19m);
menu.Add("elderberry", 1.79m);
menu.Add("figs", 2.09m);
menu.Add("grapefruit", 1.99m);
menu.Add("honeydew", 3.49m);

List<string> order = new List<string>();

Console.WriteLine("Welcome to Grand Circus Market!\n");

while (true)
{
    Console.WriteLine("" +
                    "Item\t\tPrice\n" +
                    "=======\t\t=======");

    foreach (KeyValuePair<string, decimal> s in menu)
    {
        Console.WriteLine($"{s.Key}:   \t${s.Value}");
    }
    Console.WriteLine();

    while (true)
    {
        Console.Write("What item would you like to order? ");
        string input = Console.ReadLine();
        Console.WriteLine();
        if (menu.ContainsKey(input))
        {
            order.Add(input);
            break;
        }
        else
        {
            Console.WriteLine("Sorry, we don't have those.. Please try again.\n");
        }
    }
    Console.WriteLine();

    static bool GetContinue()
    {
        while (true)
        {

        }
    }
    Console.Write("Would you like to order anything else? (y/n): ");
    string choice = Console.ReadLine().ToLower().Trim();
    Console.WriteLine();
    if (choice == "y")
    {
    }
    else if (choice == "n")
    {
        break;
    }
}
Console.WriteLine("Thank you for your order!");
decimal sum = 0;
foreach (string f in order)
{
    Console.WriteLine($"{f}:   \t${menu[f]}");
    sum += menu[f];
}
Console.WriteLine();
Console.WriteLine($"Your total cost is ${sum}.");