Console.Clear();
double numero1,numero2,numero3,Média;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Média Aritmética de 3 números");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Digite o primeiro número: ");
numero1 = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Digite o segundo número: ");
numero2 = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Digite o terceiro número: ");
numero3 = Convert.ToDouble(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkMagenta;

Média = (numero1 + numero2 + numero3) / 3;
Console.WriteLine($"\nMédia: {Média:n1}");
Console.ResetColor();