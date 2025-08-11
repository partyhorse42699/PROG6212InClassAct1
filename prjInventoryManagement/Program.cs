namespace prjInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            Product[] productArray =
            {
                new Product { id = 1, name = "Calculator", quantity = 1, price = 400 },
                new Product { id = 2, name = "Scissors", quantity = 2, price = 230},
                new Product { id = 3, name = "Pens", quantity = 8, price = 8}
            };
            Product[] products = productArray.Where(s => s.quantity < 2).ToArray();

            foreach (var product in products)
            {
                Console.WriteLine("Name: " + product.name + " Quantity: " + product.quantity + " Price: " + product.price);
            }

        }

        public void lowStock()
        {

        }
    }
}
