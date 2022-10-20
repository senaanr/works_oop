using work_3;
public class Program
{
    public static void Main(string[] args)
    {
        Product Ulker = new Product(1, 10, "Kraker");
        Product Algida = new Product(2, 30, "Dondurma");
        Product Mcdonals = new Product(3, 68, "Pizza");

        CartItem cartItem_1 = new CartItem(1, Ulker, 10);

        CartItem cartItem_2 = new CartItem(2, Algida, 3);

        CartItem cartItem_3 = new CartItem(3, Mcdonals, 6);


        ShoppingCart Box = new ShoppingCart();

        Box.Add(cartItem_1);
        Box.Add(cartItem_2);
        Box.Add(cartItem_3);
        Console.WriteLine(Box.GetBalance());
        Box.Remove(3);
        Box.GetList();


    }
}