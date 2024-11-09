for (int n = 1; n <= 100; n++) {
    string saida = "" + n.ToString();

    if ((n % 5 == 0) || (n % 3 == 0)) {
        saida += " - ";

        saida += (n % 3 == 0) ? "Fizz" : "";
        saida += (n % 5 == 0) ? "Buzz" : "";
    }

    Console.WriteLine(saida);
}