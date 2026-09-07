public static class Menu
{

  static List<string> drinks = ["cola", "fanta", "milk"];

  public static void Main()
  {
    // run our application
    Console.WriteLine("\nWelcome to the Soda Pop Bar"); // \n = newline
    string orderFromAsk = Ask();
    Fetch(orderFromAsk);
  }

  static string Ask()
  {
    Console.WriteLine("What would you like to drink?");
    string order = Console.ReadLine();
    Console.WriteLine("\tYou want a " + order); // \t = tab
    return order;
  }

  static void Fetch(string orderIn)
  {
    if (!drinks.Contains(orderIn.ToLower())) // cola, fanta, milk == Milk -> milk
    {
      Console.WriteLine("\tSorry, we dont have any " + orderIn);
    }
    else
    {
      Console.WriteLine("\tHere's your " + orderIn);
    }

    Main();
    //Fetch(Ask());
  }


}