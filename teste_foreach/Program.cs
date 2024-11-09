int[] inventario = {200, 450, 700, 175, 250};

int total_itens = 0;
int compartimento = 0;
foreach (int itens in inventario) {
    compartimento++;
    total_itens += itens;

    Console.WriteLine($"Compartimento {compartimento}: {itens} itens (total: {total_itens})");
}

Console.WriteLine($"Há {total_itens} itens no inventário.");