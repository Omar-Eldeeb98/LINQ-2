
using static LINQ_2.ListGenerator;

namespace LINQ_2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Friend!");
            //Console.WriteLine("\n");

            Console.WriteLine(ListGenerator.ProductsList[0]); // ProductID:1,ProductName:Chai,CategoryBeverages,UnitPrice:18.00,UnitsInStock:100
            Console.WriteLine(ListGenerator.CustomersList[0]);// 212, Ahmed Ali, Obere Str. 57, Berlin, , 12209, Germany, 030-0074321, 030-0076545
            Console.WriteLine("\n");

            #region (1) Filteration Operators: [where , ofType]

            // filteration operators ---> [where , ofType] , is a (Differed) execution

            #region where operator

            // [where]

            // :  EX01
            //1 - fluent synax
            //var outOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            // foreach (var item in outOfStock)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("\n");


            // 2 - query syntax
            //outOfStock = from p in ListGenerator.ProductsList where p.UnitsInStock == 0 select p;
            //foreach (var item in outOfStock)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            //---------------------------------------------------------------

            // EX02
            // 1 - fluent syntax
            //var res = ProductsList.Where(p => { return p.Category == "Meat/Poultry" && p.UnitsInStock > 0; });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            // 2 - query sentax
            //res = from p in ProductsList where p.Category == "Meat/Poultry" && p.UnitsInStock > 0 select p;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");



            #endregion

            #region indexed where

            //[ indexed where]

            // EX01
            // 1 - fluent syntax
            //var result = ProductsList.Where((p, i) => { return p.UnitsInStock == 0 && i < 20; });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            // 2- query synatx
            // - we can not use [indexed where] in query syntax

            //--------------------------------------------------------

            #endregion


            #region ofType operator

            // [ofType]

            // EX01
            // 1 - fluent synatax
            // ArrayList arrayList = new ArrayList() {1 , "omar" , 500 , "mona" , 1.5 , 'o' , true };
            //var rs1 = arrayList.OfType<int>(); // will return sequence of the same type in <>
            // foreach (var item in rs1)
            // {
            //     Console.WriteLine(item);  // 1
            //                               // 500
            // }
            // Console.WriteLine("\n");



            // 2 - query synatx
            // 

            //---------------------------------------------------------

            #endregion




            #endregion

            #region (2) Transformation Operators: [select , selectMany]

            // transformation operators ---> [select , selectMany]

            #region select , SelectMany

            // [select]

            // Ex01

            // 1 - fluent syntax
            //var res  = ProductsList.Select((p) => { return p.ProductName;});
            //var res = ProductsList.Select((p) => { return new {  p.ProductID ,  p.ProductName }; });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);  // will return sequence of ProductName
            //}
            //Console.WriteLine("\n");


            // 2 - query synatx
            //var res = from p in ProductsList select new { p.ProductID , p.ProductName };
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //----------------------------------------------------------------

            // EX02

            // 1 - fluent syntax
            //var res = CustomersList.SelectMany((c) => { return c.Orders; });
            ////:: NOTE ::  if the property is a list or array you should use [SelectMany] operator
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");



            // 2 - query syntax
            //var res2 = from c in CustomersList from o in c.Orders select o;
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            //----------------------------------------------------------

            // EX03

            // 1 - fluent syntax
            //var result =  ProductsList.Where((p) => { return p.UnitsInStock > 0; })
            //      .Select((p) => { return new {p.ProductID , p.ProductName ,oldPrice = p.UnitPrice , newPrice = p.UnitPrice - p.UnitPrice * 0.1m  }; });

            //  foreach (var item in result)
            //  {
            //      Console.WriteLine(item);
            //  }
            //  Console.WriteLine("\n");


            // 2 - query syntax
            //-

            //--------------------------------------------------------------

            #endregion

            #region Indexed Select

            // [indexed select ]

            // EX01

            // 1 - fluent synatx
            //var res =  ProductsList.Select((p, index) => { return new { index , p.ProductName };  });
            // foreach (var item in res)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("\n");

            // 2 - query synatax
            // - we can not use query syntax with  indexed select

            //----------------------------------------------------------------

            #endregion



            #endregion

            #region (3) Ordering Operators: [OrderBy , OrderByDescending , ThenBy , Reverse]

            // ordering operators --> 

            // EX01

            // 1- fluent syntax
            //var res = ProductsList.OrderBy((p) => { return p.UnitPrice; }); // ascending is a default ordering
            //var res = ProductsList.Select((p) => { return new { p.ProductName, p.UnitPrice }; }).OrderBy(p => p.UnitPrice);
            ////var res = ProductsList.OrderByDescending((p) => { return p.UnitPrice; }); // Descending  ordering
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            // 2 - query syntax
            //var res = from p in ProductsList orderby p.UnitPrice select p.UnitPrice;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------


            // EX02

            // 1 - fluent syntax
            //var res = ProductsList
            //    .Select((p) => { return new { p.ProductName, p.UnitsInStock, p.UnitPrice }; })
            //    .OrderBy(p=> p.UnitsInStock)
            //    .ThenBy(p=> p.UnitPrice);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");



            // 2 - query syntax
            //var res2 = from p in ProductsList orderby p.UnitsInStock ascending, p.UnitPrice ascending select new { p.ProductName, p.UnitsInStock, p.UnitPrice };
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------

            // EX03

            // 1 - fluent syntax
            //var res =   ProductsList.Reverse<Product>();  // هيرجعلك الsequence متشقلب 
            //  foreach (var item in res)
            //  {
            //      Console.WriteLine(item);
            //  }
            //  Console.WriteLine("\n");


            //-------------------------------------------------------------------

            #endregion

            #region (4) Elements Operators: [First, Last, FirstOrDefault, LastOrDefault, ElementAt, ElementAtOrDefault, Single, SingleOrDefault, DefaultIfEmpty] , is an immediate execution

            //::NOTE:: --> most of elements operators return only ONE element.  
            //-----------------------------------------------------------------

            //EX01

            //var res = ProductsList.First(); // will return the first element in the sequence, may throw exception
            // Console.WriteLine(res);
            // Console.WriteLine("\n");

            //var res = ProductsList.Last(); // will return the last element in the sequence, may throw exception
            //Console.WriteLine(res);
            //Console.WriteLine("\n");

            //--------------------------------------------------------------

            //EX02

            //var res1 = ProductsList.FirstOrDefault(); // if sequence is empty , [FirstOrDefault] operator will return null

            //var res2 = ProductsList.LastOrDefault(); // if sequence is empty , [LastOrDefault] operator will return null

            //--------------------------------------------------------------

            // EX03

            //var res1 = ProductsList.First((p) => { return p.UnitsInStock == 0; }); // will return the first element that match the conditio
            //Console.WriteLine(res1);

            //var res2 = ProductsList.Last((p) => { return p.UnitsInStock == 0; }); // will return the last element that match the condition
            //Console.WriteLine(res2);


            //-------------------------------------------------------------

            // EX04

            //ProductsList = new List<Product>();
            //var res1 = ProductsList.FirstOrDefault(new Product() { ProductName = "default product"});
            //Console.WriteLine(res1);

            //var res2 = ProductsList.LastOrDefault(new Product() { ProductName = "default product" });
            //Console.WriteLine(res2);

            //------------------------------------------------------------

            // EX05

            //ProductsList = new List<Product>();

            //var res = ProductsList.FirstOrDefault((p) => { return p.UnitsInStock == 0; } , new Product() { ProductName = "default product"});
            //// will return the first element that match the condition 
            //// if there is no ele match the condition, will return the default object
            //Console.WriteLine(res);


            //var res2 = ProductsList.LastOrDefault((p) => { return p.UnitsInStock == 0; }, new Product() { ProductName = "default product" });
            //// will return the last element that match the condition 
            //// if there is no ele match the condition, will return the default object
            //Console.WriteLine(res2);

            //------------------------------------------------------------


            // EX06

            //var res = ProductsList.ElementAt(2); // will return element in specific index , may throw Exception
            //Console.WriteLine(res);


            //var res2 = ProductsList.ElementAtOrDefault(1); // will return null if element is not exist in specific index
            //Console.WriteLine(res2);

            //----------------------------------------------------------

            // EX07

            //var res = ProductsList.Single(); 
            //// return the element if your sequence have one item only
            ////::NOTE:: will throw exception if sequence have more than one element or  sequence have ZERO elements.

            //Console.WriteLine(res);


            //var res = ProductsList.SingleOrDefault();
            //// ::NOTE:: will throw exception only if sequence sequence have more than ONE elements.
            //// :: NOTE:: if sequence have ZERO elements will return default value "null". 

            //Console.WriteLine(res);

            //---------------------------------------------------------

            // EX08
            //var res = ProductsList.Single(p=> p.UnitsInStock == 0);
            // if i have only one element match condition , it will return it.

            // it will throw exception if :
            // 1 - there is more than ONE element match  condition 
            // 2 - there is no element match condition

            //Console.WriteLine(res);

            //---------------------------------------------------------

            // EX09
            //ProductsList = new List<Product>();
            //var res = ProductsList.SingleOrDefault(new Product { ProductName = "default"});

            //* if there is one element, it will return it

            // :: NOTE:: if sequence have ZERO elements will return default object that i am created

            // it will throw exception if :
            // 1 - there is more than ONE element 

            /*  Console.WriteLine(res);*/ // ProductID:0,ProductName:default,Category,UnitPrice:0,UnitsInStock:0

            //-------------------------------------------------------

            // EX10

            //var res = ProductsList.SingleOrDefault(p=>p.UnitsInStock == 1000);

            //* if there is one element match condition, it will return it

            // if there is no element match condition, it will return null

            // it will throw exception if :
            // 1 - there is more than ONE element match  condition 

            //Console.WriteLine(res);

            //-----------------------------------------------------

            // EX11

            //var res = ProductsList.SingleOrDefault(p => p.UnitsInStock == 1000 , new Product() { ProductName = "default"});

            //* if there is one element match condition, it will return it

            // if there is no element match condition, it will return default product object, that i am created

            //Console.WriteLine(res);

            //-----------------------------------------------------

            // EX12

            //ProductsList = new List<Product>(); // ProductsList is empty now

            //var res = ProductsList.DefaultIfEmpty(new Product() { ProductName = "Default Product"});
            //// will return sequence is there is elements in sequence that do operations on it 
            //// if sequence is empty it will return default value --> "null" or will return default object that i am created.

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);  // ProductID:0,ProductName:Default Product,Category,UnitPrice:0,UnitsInStock:0
            //}
            //Console.WriteLine("\n");

            //-----------------------------------------------------

            #endregion

            #region (5) Aggregate Operators: [count, sum, avg, min, max, maxby, minby, Aggregate ] , immediate execution

            // EX01

            //var res = ProductsList.Count();
            //var res = ProductsList.Count((p) => { return p.UnitsInStock == 0; });
            //var res = ProductsList.Count;

            //* will return the count of elements in sequence
            //* count operator can take condition and return the count of element that match condition 

            //Console.WriteLine(res);

            //------------------------------------------------------


            // EX02
            //var res = ProductsList.Sum(p => p.UnitPrice);
            //// * will return the sum of prices 
            //var res = ProductsList.Sum(p => p.UnitsInStock);
            //// * will return the sum of units in stock 

            //Console.WriteLine(res);


            //------------------------------------------------------

            // EX03

            //var res = ProductsList.Max(new CompareProductBasedOnUnitInStock());
            //var res = ProductsList.Max(p=> p.UnitPrice);  // will return the maximum price


            //var res = ProductsList.Max(); // will return the maximum peoduct based on price
            //* must implement IComparable to use it

            //Console.WriteLine(res);

            //------------------------------------------------------

            //EX04

            //var res = ProductsList.MaxBy(p => p.UnitPrice);
            // will return the (element) that have the maximum price in sequence 

            //Console.WriteLine(res);

            //------------------------------------------------------

            // EX05

            //  List<string> strings = new List<string>()
            // {
            //     "omar",
            //     "makram",
            //     "eldeeb"
            // };

            //var res =  strings.Aggregate((str1, str2) => { return $"{str1} {str2}";  });

            //  Console.WriteLine(res); //omar makram eldeeb


            //------------------------------------------------------

            #endregion

            #region (6) Casting Operators: [ToList, ToArray, ToDictionary, ToHashSet, ToLookup ] , Immediate Execution 

            // transform from datatype to another

            //EX01

            //List<Product> products = ProductsList.Where(p => p.UnitsInStock == 0).ToList();

            //Product[] products = ProductsList.Where(p => p.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> products = ProductsList
            //    .Where(p => p.UnitsInStock == 0)
            //    .ToDictionary(p=> p.ProductID);

            //HashSet<Product> products = ProductsList.Where(p => p.UnitsInStock == 0).ToHashSet();
            //--> is a container

            //ILookup< long, Product> products = ProductsList.Where(p => p.UnitsInStock == 0).ToLookup(p=> p.ProductID);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            //------------------------------------------------------

            #endregion

            #region (7) Generation Operators: [Reange, Repeat, Empty ]

            // the only way to call --> is as a class member method throught "Enumrable"

            //EX01

            //var res = Enumerable.Range(1, 100); // 1 --- 100
            // --> wil generate sequence in Ineger type

            //foreach (var item in res)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine("\n");

            //------------------------------------------------------

            //EX02

            //var res =  Enumerable.Repeat(new Product() { ProductName = "repeted prod" } , 100 );
            // //--> will generate swquence of same data
            // foreach (var item in res)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("\n");

            //------------------------------------------------------

            //var res = Enumerable.Empty<Product>();
            //// --> will generate empty sequence 
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //------------------------------------------------------

            #endregion

            #region (8) Set Operators: [union, concat, intersect, Except, Distinct  ] 

            // EX01
            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100);



            //var res = seq1.Union(seq2);
            //--> هيعمل اتحاد ويخطهم في sequence جديد  
            // without duplication

            //var res = seq1.Intersect(seq2);
            // --> التقاطع 

            //var res = seq1.Except(seq2);
            // --> الموجود في الاولاني ومش موجود في التاني 

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            //------------------------------------------------------------

            #endregion

            #region (9) Quantifier Operators: [Any, All, SequenceEqual, Contains ]  ,  -- > return True OR False

            // Any()  , return true or false
            // - return true if there is  at least one element in the sequence OR match condition
            // - ممكن تاخد شرط و ممكن متاخدش عادي

            //var res = ProductsList.Any();
            /*  Console.WriteLine(res);*/ // true or flase

            //------------------------------------------------------------

            // All(): , return true or false
            // - return true if all elements match condition
            // - return true if sequence is empty

            //bool res =  ProductsList.All(p => p.UnitPrice > 0);
            //Console.WriteLine(res);

            //------------------------------------------------------------

            // SequenceEqual(): 
            // - return true only if 2 sequances have same values and count

            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100);
            //bool res = seq1.SequenceEqual(seq2);
            //Console.WriteLine(res);

            //------------------------------------------------------------

            // Contains(): 
            // - return true or false 


            //var seq1 = Enumerable.Range(0, 100);
            //var seq2 = Enumerable.Range(50, 100);

            //bool res = seq1.Contains(1);
            //Console.WriteLine(res);

            //---------------------------------------------

            #endregion

            #region (10) Zipping Operators: [Zip,] 

            // بيعمل دمج ل اكتر من sequence 

            // EX01
            //List<int> numbers = new List<int>() { 1,2,3,4,5};
            //List<string> names = new List<string>() { "one" , "two" , "three" };

            //var res = names.Zip(numbers, (word, number) => { return $"{word}:{number}"; });
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);  // one:1
            //}                             // two:2
            //Console.WriteLine("\n");      // three:3

            //------------------------------------------------------------
            #endregion

            #region (11) Grouping Operators: [GroupBy] 

            // groups based on حاجه معينه

            // EX01

            // 1 - fluent syntax 
            //var res =  ProductsList.GroupBy(p=>p.Category);
            //// - 
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("---------------------------");

            //}
            //Console.WriteLine("\n");


            // 2 - query syntax
            //var res = from p in ProductsList group p by p.Category;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("----------------------------------------------------");

            //}
            //Console.WriteLine("\n");



            // -----------------------------------------------------------------------

            // EX02

            // 1 - query syntax
            //var res = from p in ProductsList
            //where p.UnitsInStock > 0
            //group p by p.Category;


            //// هيقسمهم بناء على الكاتيجوري وبشرط لازم يكونو موجودين في ال unitInStock > 0

            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key);
            //    foreach (var product in item)
            //    {
            //        Console.WriteLine(product);
            //    }
            //    Console.WriteLine("----------------------------------------------------");

            //}
            //Console.WriteLine("\n");

            // -----------------------------------------------------------------------

            // EX03

            // 1 - query syntax
            //var result = from p in ProductsList
            //          where p.UnitsInStock > 0
            //          group p by p.Category
            //          into Category
            //          where Category.Count() > 5
            //          select new { catName = Category.Key, catCount = Category.Count() };


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    // ---> output :
            //    //{ catName = Beverages, catCount = 12 }
            //    //{ catName = Condiments, catCount = 11 }
            //    //{ catName = Seafood, catCount = 12 }
            //    //{ catName = Dairy Products, catCount = 9 }
            //    //{ catName = Confections, catCount = 13 }
            //    //{ catName = Grains / Cereals, catCount = 7 }
            //}
            //Console.WriteLine("\n");



            // 2 - fluent syntax 

            //var result = ProductsList.Where(p => p.UnitsInStock > 0)
            //    .GroupBy(p => p.Category)
            //    .OrderByDescending(c=> c.Count()) 
            //    .Where(c => c.Count() > 5)
            //    .Select(c => new { catName = c.Key, catCount = c.Count() });


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //    // output: 
            //    // { catName = Beverages, catCount = 12 }
            //    // { catName = Condiments, catCount = 11 }
            //    // { catName = Seafood, catCount = 12 }
            //    // { catName = Dairy Products, catCount = 9 }
            //    // { catName = Confections, catCount = 13 }
            //    // { catName = Grains/Cereals, catCount = 7 }
            //}
            //Console.WriteLine("\n");


            // -----------------------------------------------------------------------

            #endregion

            #region (12) Partitioning Operators: [Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile]

            //  Partitioning Operators :
            // - used to make Pagination

            //EX01
            //var result =  ProductsList.Take(5);
            // // - هتجيب اول 5 من ال products 
            // result =  ProductsList.Where(p => p.UnitsInStock == 0).Take(3);
            // // - will return the first 3 products that there unitinstock == 0

            // result = ProductsList.TakeLast(5);
            // // - هيجبيب اخر 5 products بس من الاخر 

            // foreach (var item in result)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("\n");


            //--------------------------------------------------------------


            // EX02

            //var result = ProductsList.Skip(5);
            // - هيطنش اول 5 product موجودين في الsequence
            // - will skip the first 5 elements in the sequence , and return new sequence without this 5 elements

            //result = ProductsList.SkipLast(5);
            // - هطنش اخر 5 products موجودين في ال sequence
            // - will skip the las 5 elements in squence,  

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");

            //--------------------------------------------------------------------

            // EX03

            //[TakeWhile] : --> (take) elements from a sequence as long as a specific condition is true

            //int[] ints = {9, 6, 5, 3 };
            //var result =  ints.TakeWhile(i => i % 3 == 0);
            //// - هتفضل تاخد عناصر طول م الشرط ب true
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n");


            //-------------------------------------------------------------------------

            // EX04

            //[SkipWhile] : --> (skip) elements from a sequence as long as a specific condition is true

            //int[] ints = { 9, 6, 5, 3 };
            //var result  = ints.SkipWhile((i)=> { return i % 3 == 0; });
            ////- هيفصل يعم skip للعناصر طول م الشرط ب true
            //// - will (skip) elements as long as condition is true
            //// هيبداء ياخد من اول ال false ميحصل لحد الاخر
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item); 
            //}
            //Console.WriteLine("\n");

            //-------------------------------------------------------------------------



            #endregion

            #region  let / into
            // [ let, into] --> used only in query syntax


            // EX01

            // a e o i u  الحروف المتحركة 

            //List<string> names = new List<string>()
            //{
            //    "omar",
            //    "ali",
            //    "mona",
            //    "samy",
            //    "osama",
            //    "hassan"
            //};

            //var res = Regex.Replace("omar", "[aeoiuAEOIU]", string.Empty);
            //// - هيشيل اي حرف متحرك ويحط مكانه string فاضي 
            //Console.WriteLine(res);  // mr

            //-------------------------------------------------------------


            // EX02: [into, let]  --> نفس المثال السابق

            //List<string> names = new List<string>()
            //{
            //    "omar",
            //    "ali",
            //    "mona",
            //    "samy",
            //    "osama",
            //    "hassan"
            //};

            //var result = from name in names
            //             select Regex.Replace( name, "[aeoiuAEOIU]", string.Empty)
            //             into newName
            //             // [into] : it restart the query with introducing new Range variable (newName)
            //             where newName.Length >= 3
            //             select newName;


            //======================================================

            //var result = from name in names
            //             let newName =  Regex.Replace(name, "[aeoiuAEOIU]", string.Empty)
            //             // [let]: continue query with adding new range variable (newName)
            //             where newName.Length >= 3
            //             select newName;



            //foreach (var item in result)
            //{
            //    Console.WriteLine(item); // smy
            //                             // hssn
            //}
            //Console.WriteLine("\n");


            //--------------------------------------------------------------------------------

            #endregion
        }
    }
}
