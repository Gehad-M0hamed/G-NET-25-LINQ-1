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

            #region Q5:
            //var inStockCondiments = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var product in inStockCondiments)
            //{
            //    Console.WriteLine($"Product: {product.ProductName}, Category: {product.Category}, In Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region Q6:
            //var productStatusList = ProductList.Select(p => new {
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});

            //foreach (var item in productStatusList)
            //{
            //    Console.WriteLine($"Product: {item.Name} | Price: {item.Price:C} | Status: {item.StockStatus}");
            //}
            #endregion

            #region Q7:
            //var numberedProducts = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");

            //foreach (var item in numberedProducts)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q8:
            //var sortedProducts = ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Category: {product.Category} | Product: {product.ProductName} | Price: {product.UnitPrice:C}");
            //}
            #endregion

            #region Q9:
            //var sortedBeverages = ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //foreach (var product in sortedBeverages)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName} | Units In Stock: {product.UnitsInStock}");
            //}
            #endregion

            #region Q10:
            //var ordersQuery = from customer in CustomerList
            //                  from order in customer.Orders  
            //                  where order.OrderDate.Year >= 1997
            //                  select new
            //                  {
            //                      customer.CustomerID,
            //                      order.OrderDate
            //                  };

            //foreach (var orderInfo in ordersQuery)
            //{
            //    Console.WriteLine($"Customer ID: {orderInfo.CustomerID} | Order Date: {orderInfo.OrderDate:yyyy-MM-dd}");
            //}
            #endregion


        }
    }
}
