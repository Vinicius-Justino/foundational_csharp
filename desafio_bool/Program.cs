string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin")) {
    string tipo_adm = (level > 55) ? "Super Admin" : "Admin";
    Console.WriteLine($"Welcome, {tipo_adm} user.");
} else if (permission.Contains("Manager")) {
    string boas_vindas = (level >= 20) ? "Contact and Admin for access." : "You do not have sufficient privileges";
    Console.WriteLine(boas_vindas);
} else {
    Console.WriteLine("You do not have sufficient privileges.");
}