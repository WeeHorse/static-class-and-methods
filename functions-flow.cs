
static void HelloWorld()
{
  Console.WriteLine("Hello World");
}

static void GoodbyeCruelWeb()
{
  Console.WriteLine("Goodbye");
  //Console.ReadLine();
  //GoodbyeCruelWeb(); // The function can call itself, to create a loop-like structure (recursion)
}

// the functions must be called to for their code to run, and we decide the order
GoodbyeCruelWeb();
HelloWorld();


// consider how the loop is similar to the function calling itself
while (false) // true to run forever
{
  Console.WriteLine("Again?");
  Console.ReadLine();
}