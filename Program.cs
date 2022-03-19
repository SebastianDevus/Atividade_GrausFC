double grausF, grausC;

Console.Write("Insira a temperatura (°F): ");
grausF = Convert.ToDouble(Console.ReadLine()!);

grausC = (grausF - 32) / 1.8;

Console.WriteLine($"O equivalente em °C é {grausC:N2}");