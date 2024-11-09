int employee_level = 200;
string employee_name = "John Smith";
string title = "Associate";

string[] titles = {"Junior Associate", "Senior Associate", "Manager", "Senior Manager"};
if ((employee_level <= titles.Length * 100) && ((employee_level % 100) == 0)) {
    title = titles[(employee_level / 100) - 1];
}

Console.WriteLine($"{employee_name}, {title}");