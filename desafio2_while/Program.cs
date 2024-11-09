int num = 0;

Console.WriteLine("Enter an integer value between 5 and 10");

do {
    if (!int.TryParse(Console.ReadLine(), out num)) {
        Console.WriteLine("Sorry, you entered an invalid number, please try again.");
    } else if (num < 5 || 10 < num) {
        Console.WriteLine($"You entered {num}. Please enter a number between 5 and 10.");
    }
} while (num < 5 || 10 < num);

Console.WriteLine($"Your input value ({num}) has been accepted.");