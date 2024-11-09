Random moeda = new();

// string lancamento = {"tails", "heads"}[moeda.Next(2)];
string lancamento = (moeda.Next(2) == 1) ? "heads" : "tails";

Console.WriteLine($"Lançamento: {lancamento}");
