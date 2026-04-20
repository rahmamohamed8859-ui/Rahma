namespace LINQ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
var result = products
    .OrderByDescending(p => p.UnitPrice)
    .Take(3);
-----------------------------------------------------

var result = products
    .Skip(5)
    .Take(5);
----------------------------------------

var result = products
    .OrderBy(p => p.UnitPrice)
    .TakeWhile(p => p.UnitPrice < 25);
-----------------------------------------------



bool result = products
    .Where(p => p.Category == "Seafood")
    .All(p => p.UnitsInStock > 0);
-----------------------------------

int[] ids = { 3, 9, 13, 18 };

bool result = ids.Contains(9);
------------------------------------


var result = products
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        Category = g.Key,
        Count = g.Count()
    });
----------------------------------

var result = products
    .GroupBy(p => p.Category)
    .Select(g => new
    {
        Category = g.Key,
        Products = g.Select(p => p.ProductName)
    });

-----------------------------------------

var result = products
    .GroupBy(p => p.Category)
    .Where(g => g.Count() > 3)
    .Select(g => g.Key);
---------------------------------------------------



var result = from c in customers
             group c by c.Country into g
             select new
             {
                 Country = g.Key,
                 Count = g.Count(),
                 TotalOrderValue = g.Sum(x => x.Orders.Sum(o => o.Total))
             };

--------------------------------------------------------------------------------------

int total = products.Sum(p => p.UnitsInStock);
---------------------------------------------------------


var min = products.Min(p => p.UnitPrice);
var max = products.Max(p => p.UnitPrice);
----------------------------------------------


var result = products
    .Select(p => p.Category)
    .Distinct();
---------------------------------------------------



int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
int[] setB = { 3, 6, 9, 12, 15, 13 };

var result = setA.Except(setB);
----------------------------------------------------



var result = list1
    .Except(list2, StringComparer.OrdinalIgnoreCase);

-------------------------------------------------------------


var dict = products.ToDictionary(p => p.ProductID);

var product = dict[18];
-------------------------------------------------------



var result = products.First(p => p.UnitPrice > 50);
----------------------------------------------------------



var result = products.FirstOrDefault(p => p.UnitPrice > 500);
---------------------------------------------------------------


var result = Enumerable.Range(1, 10)
    .Select(x => 7 * x);
--------------------------------------------------------


var result = Enumerable.Range(1, 30)
    .Where(x => x % 2 == 0);
---------------------------------------------------



var result = products.Take(3)
    .Select(p => p.ProductName)
    .Concat(customers.Take(3).Select(c => c.CompanyName));
----------------------------------------------------------------


var result = products.Zip(customers,
    (p, c) => $"{p.ProductName} sold to {c.CompanyName}");