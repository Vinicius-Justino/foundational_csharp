Random dice = new();
int roll = dice.Next(1, 7);

Console.WriteLine(roll);
Console.WriteLine(dice.Next());
Console.WriteLine(dice.Next(101));

Console.WriteLine($"\n{Math.Max(500, 600)}");