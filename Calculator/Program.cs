

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

switch (operation)
{
    case 1:
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case 4:
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
}

Console.ReadKey();

