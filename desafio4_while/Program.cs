string[] myStrings = {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};

foreach (string myString in myStrings) {
    int period_location = myString.IndexOf(".");
    int after_prev_period = 0;

    while (period_location != -1) {
        Console.WriteLine(myString.Substring(after_prev_period, period_location).TrimStart());

        after_prev_period += period_location + 1;
        period_location = myString.Substring(after_prev_period).IndexOf(".");
    }

    Console.WriteLine(myString.Substring(after_prev_period).TrimStart());
}