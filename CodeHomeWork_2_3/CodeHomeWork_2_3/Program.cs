namespace CodeHomeWork_2_3;

internal class Program
{
    static void Main(string[] args) 
    {
        var shop = new Shop();
        var items = shop.GetItems();
        var user = new User() {FirstName =" Daniil", LastName = "Gryshyn"};
        var bucket = new Bucket();

        for (int i = 0; i < 10; i++)
        {
            var random = new Random().Next(0, 20);
            shop.GetOrderedItems[i] = shop.GetItems()[random
                ];
            bucket.Add(shop.GetOrderedItems[i]);
        }
        user.Notify(bucket.GetOrderItems());
    }
}

