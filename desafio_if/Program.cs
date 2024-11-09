Random d12 = new();

int dias_ate_expirar = d12.Next(12);
float percentual_desconto = 0f;

if ((dias_ate_expirar > 5) && (dias_ate_expirar <= 10)) {
    Console.WriteLine("Your subscription expires soon. Renew now!");
} else if (dias_ate_expirar > 1) {
    Console.WriteLine($"Your subscription expires in {dias_ate_expirar} days.");
    percentual_desconto = 0.1f;
} else if (dias_ate_expirar == 1) {
    Console.WriteLine("Your Subscription expires within a day!");
    percentual_desconto = 0.2f;
} else {
    Console.WriteLine("Your subscription has expired.");
}

if (percentual_desconto > 0) {
    Console.WriteLine($"Renew now and save {(int)(percentual_desconto * 100)}%!");
}