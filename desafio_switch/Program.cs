// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "Other";
switch (product[0]) {
    case "01":
        type = "Sweat shirt";
        break;
    
    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;
}

string color = "White";
switch (product[1]) {
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;
}

string size = "One Size Fits All";
switch (product[2]) {
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");