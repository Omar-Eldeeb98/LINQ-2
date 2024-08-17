using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Serialization;
using static C42_G02_LINQ02.ListGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace C42_G02_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            //var res = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var res = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Select((name, index) => new { Name = name, Value = index })
            //    .Where(x => x.Name.Length < x.Value)
            //    .Select(x => x.Value);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            #endregion


            #endregion


            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            //var res  = ProductsList.First((p) => { return p.UnitsInStock == 0; });
            // Console.WriteLine(res);  // ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0


            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(result);

            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Where(x => x > 5).Skip(1);
            //Console.WriteLine(res);  // 8

            #endregion

            #endregion


            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Count(i => i % 2 != 0);
            //Console.WriteLine(res);
            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var res = CustomersList.Select((c) => { return new { CustomerID = c.CustomerID, Orders = c.Orders.Length }; });

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 3. Return a list of categories and how many products each has


            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Number_Of_Products_For_Each_Category = c.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("\n");

            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Sum();
            //Console.WriteLine(res);  //45

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt
            // (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //int totalNumbers = words.Sum(w => w.Length);
            //Console.WriteLine($"total number of characters = {totalNumbers}"); //total number of characters = 3494688

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt
            // (Read dictionary_english.txt into Array of String First).


            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Min(w => w.Length);  // 1
            //Console.WriteLine(res);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt
            // (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Max(w => w.Length); 
            //Console.WriteLine(res);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt
            // (Read dictionary_english.txt into Array of String First).

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var res = words.Average(w => w.Length);
            //Console.WriteLine(res);

            #endregion

            #region 9. Get the total units in stock for each product category.

            //var result2 = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Products_UnitsInstock = c.Sum(c => c.UnitsInStock) });


            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("\n");

            #endregion

            #region 10. Get the cheapest price among each category's products
            //var result2 = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Products_UnitsInstock_Total_Price = c.Sum(c => c.UnitPrice) })
            //    .Min(cc=> cc.Products_UnitsInstock_Total_Price);


            //Console.WriteLine(result2); // 128.4500
            //Console.WriteLine("\n");

            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var result2 = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Products_cheapest_Price = c.Min(c => c.UnitPrice) });

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            #endregion

            #region 12. Get the most expensive price among each category's products.

            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Products_UnitsInstock_Total_Price = c.Sum(c => c.UnitPrice) })
            //    .Max(cc => cc.Products_UnitsInstock_Total_Price);

            //Console.WriteLine(result); // 455.7500
            //Console.WriteLine("\n");



            #endregion

            #region 13. Get the products with the most expensive price in each category.


            //var result2 = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Products_expensive_Price = c.Max(c => c.UnitPrice) });

            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 14. Get the average price of each category's products.

            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .Select(c => new { catName = c.Key, Products_Avg_Price = c.Average(c => c.UnitPrice) });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion


            #endregion


            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var res =  ProductsList.OrderBy(p => p.ProductName);
            // foreach (var item in res)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("\n");
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //Array.Sort(Arr, new CaseInsensitiveComparer());
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.

            //var res =  ProductsList.OrderByDescending(p => p.UnitsInStock).Select(p => p.UnitsInStock);
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"Units In Stock :  { item}");
            //}
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            // 4.1 - sort by lenght of their name
            //var res = Arr.OrderBy(c => c.Length);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            // 4.2 - sort alphabetically by the name itself
            //Array.Sort(Arr);
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------

            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // 5.1 - Sort first by-word length
            //var res = Arr.OrderBy(i => i.Length);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("\n");


            // 5.2  case-insensitive sort
            //Array.Sort(Arr, new CaseInsensitiveComparer());
            //foreach (var item in Arr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            //-------------------------------------------------------------------

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var res = from p in ProductsList
            //          orderby p.Category
            //          select p
            //          into newProducts
            //          orderby newProducts.UnitPrice descending
            //          select newProducts;

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            // 7.1 - Sort first by-word length
            //var res = Arr.OrderByDescending(i => i.Length);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);

            //}
            //Console.WriteLine("\n");


            // 7.2 - case-insensitive descending sort
            //Array.Sort(Arr, new CaseInsensitiveComparer());

            //var descendingSortedArray = Arr.Reverse();


            //foreach (var item in descendingSortedArray)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");



            //-------------------------------------------------------------------
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i'  that is reversed from the order in the original array.


            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            //var filtered = Arr.Where(w => w.Length > 1 && w[1] == 'i').Reverse().ToList();
            //foreach (var item in filtered)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            #endregion

            #endregion


            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var res = ProductsList.Select(p => p.ProductName);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).

            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var res = words.Select(w => new { uppercase = w.ToUpper() , lowercase = w.ToLower() });
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"UpperCase: {item.uppercase} , lowercase: {item.lowercase}");

            // output :

            // UpperCase: APPLE , lowercase: apple
            // UpperCase: BLUEBERRY , lowercase: blueberry
            // UpperCase: CHERRY , lowercase: cherry
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var res = ProductsList.Select((p) => { return new { Product_Name = p.ProductName , Price = p.UnitPrice }; });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            #endregion

            #region 4. Determine if the value of int in an array match their position in the array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = Arr.Select((ele , index) => { return new {ele  , x = ele == index }; });
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.ele} : {item.x}");
            //}

            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };


            //var result = numbersA.SelectMany(a => numbersB.Where(b => a < b).Select(b => new { numberA = a, numberB = b }));
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item.numberA} is less than {item.numberB}");
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 6. Select all orders where the order total is less than 500.00.

            //var res = CustomersList.SelectMany(c => c.Orders).Where(cc => cc.Total < 500.00m);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.

            //var res = CustomersList.SelectMany(c => c.Orders).Where(cc=>cc.OrderDate.Year >= 1998);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


            #endregion


            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //IEnumerable<string> uniqueCategoryName = ProductsList.Select(p=> p.Category).Distinct();


            //foreach (var item in uniqueCategoryName)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var seq1 = ProductsList.Select(p => p.ProductName.First());
            //var seq2 = CustomersList.Select(c => c.CustomerName.First());


            //var res = seq1.Union(seq2);

            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");  // C A G U N M I Q K T P S R B J Z V F E W L O D H
            //}


            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var seq1 = ProductsList.Select(p => p.ProductName.First());
            //var seq2 = CustomersList.Select(c => c.CustomerName.First());


            //var res = seq1.Intersect(seq2);

            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");  // C A G N M I Q K T P S R B V F E W L O
            //}

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var seq1 = ProductsList.Select(p => p.ProductName.First());
            //var seq2 = CustomersList.Select(c => c.CustomerName.First());

            //var res = seq1.Except(seq2);
            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");  // U J Z
            //}

            #endregion

            #region  5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var seq1 = ProductsList.Select(p => p.ProductName).TakeLast(3);
            //var seq2 = CustomersList.Select(c => c.CustomerName).TakeLast(3);

            //var result = seq1.Concat(seq2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #endregion


            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var res = CustomersList.Where(c => c.City == "Washington").SelectMany(cc => cc.Orders).Take(3);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var res = CustomersList.Where(c => c.City.Equals("Washington")).SelectMany(cc => cc.Orders).Take(2);

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((num, index) => { return num > index; });

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item); // 5
            //}                            // 4

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int firstElementCanDividedBy_3 = Array.FindIndex(numbers, num => num % 3 == 0);   // this is the our starting index 

            //var res = numbers.Skip(firstElementCanDividedBy_3);

            //foreach (var item in res)
            //{
            //    Console.Write(item + " " );  // 3 9 8 6 7 2 0
            //}



            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var startingElement = numbers.Where((value,index) => value < index ).First(); // 1

            //var startElementIndex = Array.IndexOf(numbers, startingElement);  // 2

            //var res = numbers.Skip(startElementIndex);
            //foreach (var item in res)
            //{
            //    Console.Write(item + " "); // 1 3 9 8 6 7 2 0
            //}


            #endregion


            #endregion


            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //bool result = words.Contains("ei");

            //Console.WriteLine(result);  // false

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var res = ProductsList.GroupBy(p => p.Category).Where(pp => pp.Any(p => p.UnitsInStock == 0));

            // foreach (var item in res)
            // {
            //     Console.WriteLine(item.Key);
            //     foreach (var product in item)
            //     {
            //         Console.WriteLine(product );
            //     }
            //     Console.WriteLine("---------------------------");

            // }


            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var res = ProductsList.GroupBy(p => p.Category).Where(pp => pp.All(p => p.UnitsInStock > 0));

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("---------------------------");

            //}

            #endregion


            #endregion



            #region LINQ – Grouping Operators


            #region 1.Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var resault = numbers.GroupBy(n => n % 5);
            //foreach (var item in resault)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //    Console.WriteLine("\n");
            //}


            #endregion

            #region 2.Uses group by to partition a list of words by their first letter.

            //  Use dictionary_english.txt for Input

            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var groupedWords = words.GroupBy(w => w[0]);


            //foreach (var item in groupedWords)
            //{
            //    Console.WriteLine($"First Letter: {item.Key}");
            //    foreach (var word in item)
            //    {
            //        Console.WriteLine(word);
            //    }
            //    Console.WriteLine("--------------------------------------------");
            //}






            #endregion

            #region 3.Consider this Array as an Input , Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var groupedWords = Arr.GroupBy(w => w, new MatchCharsComparer()).ToList();


            //foreach (var item in groupedWords)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);

            //    }
            //    Console.WriteLine("--------");
            //}

            #endregion

            #endregion






        }
    }
}
