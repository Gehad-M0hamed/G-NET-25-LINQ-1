namespace G_NET_25_LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:
            var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");

            foreach (var product in seafoodProducts)
            {
                Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice:C}");
            }
            #endregion




        }
    }
}
