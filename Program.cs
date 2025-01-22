
using Mission3;

System.Console.WriteLine("Welcome to the Food Bank!");

// Initializing variables for user to enter
string name = "";
string category = "";
int quantityNum = 0;
string quantityUnit = "";
string expiration = "";

// Creating food list
List<FoodItem> foods = new List<FoodItem>
        {
            new FoodItem("Apple", "Produce", 15, "apples", "01/29/2025"),
            new FoodItem("Milk", "Dairy", 20, "gallons", "02/12/2025"),
            new FoodItem("Crackers", "Snacks", 4, "boxes", "09/01/2025"),
        };

while (true)
{
    // Menu of options
    System.Console.WriteLine("\nSelect one of the following options:" +
        "\n\n1. Add a Food Item" +
        "\n\n2. Delete a Food Item" +
        "\n\n3. Print List of Current Food Items" +
        "\n\n4. Exit\n");

    string input = System.Console.ReadLine();
    int userChoice;

    // Error handling
    if (!int.TryParse(input, out userChoice))
    {
        System.Console.WriteLine("\nInvalid input. Please enter a number between 1 and 4.\n");
        continue;
    }

    // User enters info to add item
    if (userChoice == 1)
    {
        System.Console.WriteLine("\nYou have chosen: Add a Food Item\n");

        System.Console.WriteLine("What is the name of the food item (ex. Black Beans, Corn, etc.)? ");
        name = System.Console.ReadLine();

        System.Console.WriteLine("What is the category of the food item (ex. Canned Goods, Dairy, Produce, etc.)? ");
        category = System.Console.ReadLine();

        System.Console.WriteLine("What is the units of the food item (ex. boxes, gallons, etc.)? ");
        quantityUnit = System.Console.ReadLine();

        System.Console.WriteLine("What is the number of the food item units (ex. 1, 15, etc.)? ");
        quantityNum = int.Parse(System.Console.ReadLine());

        System.Console.WriteLine("What is the expiration date of the food item (ex. 01/29/2025, 02/02/2005, etc.)? ");
        expiration = System.Console.ReadLine();

        FoodItem food = new FoodItem(name, category, quantityNum, quantityUnit, expiration);

        foods.Add(food);

    //User selects name of item to delete
    } else if (userChoice == 2)
    {
        System.Console.WriteLine("\nYou have chosen: Delete a Food Item\n");

        System.Console.WriteLine("Enter the name of the food item would you like to delete: ");
        name = System.Console.ReadLine();

        foods.RemoveAll(food => food.name.Equals(name, StringComparison.OrdinalIgnoreCase));

    // Prints out list of food items
    } else if (userChoice == 3)
    {
        System.Console.WriteLine("\nYou have chosen: Print List of Current Food Items\n");

        System.Console.WriteLine("Here is the list: \n");

        foreach (FoodItem food in foods)
        {
            System.Console.WriteLine($"Name: {food.name}, Category: {food.category}, Quantity: {food.quantityNum} {food.quantityUnit}, Expiration: {food.expiration}");
        }

    // Exits program
    } else if (userChoice == 4)
    {
        System.Console.WriteLine("\nYou have chosen: Exit\n");

        System.Console.WriteLine("Goodbye.");

        break;

     // Error handling
    } else
    {
        System.Console.WriteLine("\nInvalid input. Please enter a number between 1 and 4.\n");
        continue;

    }
}
