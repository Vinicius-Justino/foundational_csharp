Random d6 = new();

int rolagem1 = d6.Next(1, 7);
int rolagem2 = d6.Next(1, 7);
int rolagem3 = d6.Next(1, 7);
int total = rolagem1 + rolagem2 + rolagem3;

Console.WriteLine($"Rolagens: {rolagem1} + {rolagem2} + {rolagem3} = {total}");

if ((rolagem1 == rolagem2) && (rolagem2 == rolagem3)) {
    Console.WriteLine("Todos iguais! +6 pontos!");
    total += 6;
} else if ((rolagem1 == rolagem2) || (rolagem1 == rolagem3) || (rolagem2 == rolagem3)) {
    Console.WriteLine("Você rolou duplos! +2 pontos!");
    total += 2;
}

Console.WriteLine($"Total com os bônus: {total}");

if (total >= 16) {
    Console.WriteLine("Ganhou um carro!");
} else if (total >= 10) {
    Console.WriteLine("Ganhou um laptop!");
} else if (total == 7) {
    Console.WriteLine("Ganhou uma viagem!");
} else {
    Console.WriteLine("Ganhou um gatinho!");
}
