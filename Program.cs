
using Mission3;

System.Console.WriteLine("Welcome to the Food Bank!");

int userChoice = 0;
string name = "";
string category = "";
string quantity = "";
string expiration = "";
List<FoodItem> foods = new List<FoodItem>
        {
            new FoodItem("Apple", "Produce", "15 apples", "01/29/2025"),
            new FoodItem("Milk", "Dairy", "20 gallons", "02/12/2025"),
            new FoodItem("Crackers", "Snacks", "4 boxes", "09/01/2025"),
        };

while (true)
{

    System.Console.WriteLine("\nSelect one of the following options:" +
        "\n\n1. Add a Food Item" +
        "\n\n2. Delete a Food Item" +
        "\n\n3. Print List of Current Food Items" +
        "\n\n4. Exit\n");

    userChoice = int.Parse(System.Console.ReadLine());

    if (userChoice == 1)
    {
        System.Console.WriteLine("\nYou have chosen: Add a Food Item\n");

        System.Console.WriteLine("What is the name of the food item (ex. Black Beans)? ");
        name = System.Console.ReadLine();

        System.Console.WriteLine("What is the category of the food item (ex. Canned Goods, Dairy, Produce, etc.)? ");
        category = System.Console.ReadLine();

        System.Console.WriteLine("What is the quantity of the food item (ex. 15 units)? ");
        quantity = System.Console.ReadLine();

        System.Console.WriteLine("What is the expiration date of the food item (ex. 01/29/2025)? ");
        expiration = System.Console.ReadLine();

        FoodItem food = new FoodItem(name, category, quantity, expiration);

        foods.Add(food);

    } else if (userChoice == 2)
    {
        System.Console.WriteLine("\nYou have chosen: Delete a Food Item\n");

        System.Console.WriteLine("Enter the name of the food item would you like to delete: ");
        name = System.Console.ReadLine();

        foods.RemoveAll(food => food.name.Equals(name, StringComparison.OrdinalIgnoreCase));

    } else if (userChoice == 3)
    {
        System.Console.WriteLine("\nYou have chosen: Print List of Current Food Items\n");

        System.Console.WriteLine("Here is the list: \n");

        foreach (FoodItem food in foods)
        {
            System.Console.WriteLine($"Name: {food.name}, Category: {food.category}, Quantity: {food.quantity}, Expiration: {food.expiration}");
        }

    } else if (userChoice == 4)
    {
        System.Console.WriteLine("\nYou have chosen: Exit\n");

        System.Console.WriteLine("Goodbye.");

        break;

    } else
    {
        System.Console.WriteLine("\nPlease enter a valid choice.\n");
        continue;

    }
}
