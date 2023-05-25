const string MEAL = "Schnitzel";
int maxPrice = 0;
int minPrice = 1000;
string minPriceRestaurant = "";
string maxPriceRestaurant = "";
string restaurantName = "";
System.Console.WriteLine($"Where to get {MEAL}?");

string[] menues = Directory.GetFiles(@"C:\Users\Leona\OneDrive - HTBLA Leonding\Desktop\Programmieren\übungen\057-SchnitzelHunt\MenuCards");

foreach (string menuePath in menues)
{
    string[] singleMenueCards = File.ReadAllLines(menuePath);
    foreach (string singleMenueCard in singleMenueCards)
    {
        if (singleMenueCard.Contains(MEAL))
        {
            PrintMenueWithSchnitzel(menuePath, singleMenueCard, ref restaurantName);
            FindMostAndLeastExpenciveMeal(singleMenueCard, ref maxPrice, ref minPrice, ref maxPriceRestaurant, ref minPriceRestaurant, restaurantName);
        }
    }
}
PrintCeapestAndMostExpencive(minPrice, maxPrice, minPriceRestaurant, maxPriceRestaurant);


void PrintMenueWithSchnitzel(string menuePath, string singleMenueCard, ref string restaurantName)
{
    int index1 = menuePath.LastIndexOf('\\');
    string fileName = menuePath.Substring(index1 + 1);
    int index2 = fileName.LastIndexOf('.');
    restaurantName = fileName.Substring(0, index2);
    System.Console.WriteLine(restaurantName);
    System.Console.WriteLine($"     {singleMenueCard}");
}

void FindMostAndLeastExpenciveMeal(string mealInMenue, ref int maxPrice, ref int minPrice, ref string maxPriceRestaurant, ref string minPriceRestaurant, string restaurant)
{
    int price;
    if (mealInMenue.Contains("Seitan"))
    {
        string helper = mealInMenue.Substring(mealInMenue.LastIndexOf(": ") + 1);
        string priceWithZeichen = helper.Substring(0, helper.IndexOf('€'));
        price = int.Parse(priceWithZeichen);
        if (price < minPrice)
        {
            minPrice = price;
            minPriceRestaurant = restaurant;
        }
        else if (price > maxPrice)
        {
            maxPrice = price;
            maxPriceRestaurant = restaurant;
        }
    }
}

void PrintCeapestAndMostExpencive(int minPrice, int maxPrice, string minPriceRestaurant, string maxPriceRestaurant)
{
    System.Console.WriteLine();
    System.Console.WriteLine("WHERE TO GET THE CHEAPEST SEITAN SCHNITZEL?");
    System.Console.WriteLine($"{minPriceRestaurant}, {minPrice}€");
    System.Console.WriteLine();
    System.Console.WriteLine("WHERE TO GET THE MOUST EXPENCIVE SEITAN SCHNITZEL?");
    System.Console.WriteLine($"{maxPriceRestaurant}, {maxPrice}€");
}