Random d10 = new();

string[] nomes = {"Hero", "Monster"};
int[] vidas = {10, 10};
int jogador_atual = 0;

while (vidas[0] > 0 && vidas[1] > 0) {
    int alvo = (jogador_atual + 1) % 2;
    int dano = d10.Next(1, 11);
    
    vidas[alvo] -= dano;

    Console.WriteLine($"{nomes[alvo]} was damaged and lost {dano} health and now has {vidas[alvo]} health.");

    jogador_atual = alvo;
}

Console.WriteLine($"{nomes[(jogador_atual + 1) % 2]} wins!");
