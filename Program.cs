Console.Clear();

double milhas = 0.0, km = 0;

Console.WriteLine("Digite a medida em Milhas:");
milhas = Convert.ToDouble(Console.ReadLine()!);

km = milhas *  1.609;

Console.Write($"O valor convertido é: {km} Km");
