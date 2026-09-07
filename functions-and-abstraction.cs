// no abstraction, concrete functions (not depending on any value)
static int squareRootOfSixteen()
{
  return 4;
}

// no abstraction, concrete functions
static int squareRootOfFour()
{
  return 2;
}

// some abstraktion (depending on some value, limited functionality)

static double square(int f)
{
  return f * f;
}

// more abstraktion (more functionality, more dependance)

static double calcTwo(double a, string op, double b)
{
  switch (op)
  {
    case "+":
      return a + b;
    case "-":
      return a - b;
    default:
      return 0;
  }
}

// making something less abstract

static double add(double a, double b)
{
  return a + b;
}

// 

double result = calcTwo(4, "-", 4);

Console.WriteLine(result);