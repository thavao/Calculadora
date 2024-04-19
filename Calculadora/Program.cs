double a, b;

Console.WriteLine("Digite o 1º numero");
a = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o 2º numero");
b = double.Parse(Console.ReadLine());

Console.WriteLine($"{a} + {b} = {a + b}");
Console.WriteLine($"{a} - {b} = {a - b}");
Console.WriteLine($"{a} * {b} = {a * b}");
Console.WriteLine($"{a} / {b} = {a / b}");

Console.WriteLine("Pressione Enter para encerrar...");

Console.ReadLine();