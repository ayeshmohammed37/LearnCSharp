

int num1 = default;
int num2 = default;
int operation = default;

Console.WriteLine("Welcome to the Calculator Program!");

Console.Write("Please Enter your first Number: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Please Enter your second Number: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Enter number of Operation:\n1) +\n2) -\n3) *\n4) /\noperation: ");
operation = int.Parse(Console.ReadLine());

Console.ReadKey();

