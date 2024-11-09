/*
string[] IDs_ordens_fraudulentas = new string[3];
IDs_ordens_fraudulentas[0] = "A123";
IDs_ordens_fraudulentas[1] = "B456";
IDs_ordens_fraudulentas[2] = "C789";
*/

string[] IDs_ordens_fraudulentas = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string id in IDs_ordens_fraudulentas) {
    if (id.StartsWith("B")) {
        Console.WriteLine(id);
    }
}
