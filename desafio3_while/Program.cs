string[] cargos = {"administrator", "manager", "user"};
string? entrada;
bool entrada_valida = false;

do {
    Console.WriteLine("Enter you role name (Administrator, Manager, User):");
    entrada = Console.ReadLine();
    entrada_valida = cargos.Contains(entrada.Trim().ToLower());

    if (!entrada_valida) {
        Console.WriteLine($"The role name that you entered, \"{entrada}\" is not valid.");
    }
} while (!entrada_valida);

Console.WriteLine($"You input value ({entrada}) has been accepted.");
