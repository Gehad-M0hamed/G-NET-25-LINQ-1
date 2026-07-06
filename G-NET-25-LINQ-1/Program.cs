namespace G_NET_25_LINQ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:
            //var seafoodProducts = ProductList.Where(p => p.Category == "Seafood");
            //foreach (var product in seafoodProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice:C}");
            //}
            #endregion

            #region Q2:
            //var productNames = ProductList.Select(p => p.productName);
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Q3:
            //var sortedProducts = ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice:C}");
            //}
            #endregion

            #region Q4:
            //var filteredProducts = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var product in filteredProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Price: {product.UnitPrice:C}");
            //}
            #endregion



        }
    }
}
