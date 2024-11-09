Random d10 = new();
int rolagem = d10.Next(1, 11);

/*
while (rolagem >= 3) {
    Console.WriteLine(rolagem);
    rolagem = d10.Next(1, 11);
}
*/


do {
    rolagem = d10.Next(1, 11);
    if (rolagem >= 8) {
        continue;
    }

    Console.WriteLine(rolagem);
} while (rolagem != 7);
