namespace Linq_Exc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2- Even
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.Where(n => n % 2 == 0);

            //foreach (var r in result)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion

            #region 3- Greater

            //List<int> prices = new() { 15, 90, 120, 45, 200 };

            //var price = prices.Where(x=>x>100);

            //foreach (int p in price)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region 4-select

            //List<string> names = new() { "Ali", "Mona", "Sara" };

            //var name = names.Select(n => n.ToUpper());

            //foreach (string n in name)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion

            #region 5- count

            //List<int> Scores = new() { 50, 80, 90, 40, 70 };

            //var Score = Scores.Count(s => s >= 60);

            //Console.WriteLine(Score);
            #endregion

            #region 6-FirstOrDefault

            //  List<Employees> employees = new List<Employees>();

            //  Employees emp1 = new Employees();

            //  emp1.Id = 1;
            //  emp1.Name = "Ali";

            //  employees.Add(emp1);

            //Employees emp2 = new Employees();
            //  emp2.Id = 2;
            //  emp2.Name= "Mona";

            //  employees.Add(emp2);

            //  Employees emp3 = new Employees();
            //  emp3.Id = 3;
            //  emp3.Name = "Sara";
            //  employees.Add(emp3);


            //  var emp = employees.FirstOrDefault(e => e.Id == 3);

            //  Console.WriteLine(emp.Name);
            //  Console.WriteLine(emp.Id);
            #endregion

            #region 7- OrderBy

            //List<Student> students = new List<Student>();

            //Student student1 = new Student();
            //student1.Name = "Mourad";
            //student1.Age = 30;

            //Student student2 = new Student();

            //student2.Name = "Mona";
            //student2.Age = 25;

            //Student student3 = new Student();
            //student3.Name = "Mai";
            //student3.Age = 20;

            //students.Add(student1);
            //students.Add(student2);
            //students.Add(student3);

            //var res = students.OrderBy(r => r.Age);

            //foreach (Student s in res)
            //{
            //    Console.WriteLine(s.Name);
            //    Console.WriteLine(s.Age);
            //}



            #endregion

            #region 8- OrderByDescending

            //List<Products> products = new List<Products>();

            //Products product1 = new();
            //product1.Name = "Hand Cream";
            //product1.Price = 90;

            //Products product2 = new();
            //product2.Name = "Lip balm";
            //product2.Price = 50;

            //Products product3 = new();
            //product3.Name = "Face Serum";
            //product3.Price = 230;


            //products.Add(product1);
            //products.Add (product2);
            //products.Add(product3);


            //var res = products.OrderByDescending(r => r.Price);

            //foreach (Products p in res)
            //{
            //    Console.WriteLine(p.Name);
            //    Console.WriteLine(p.Price);
            //}


            #endregion

            #region 9- Any

            //List<Orders> orders = new List<Orders>();

            //Orders order1 = new();
            //order1.Id = 1;
            //order1.Total = 1200;

            //Orders order2 = new();
            //order2.Id = 2;
            //order2.Total = 1800;

            //orders.Add(order1);
            //orders.Add(order2);

            //var res = orders.Any(o => o.Total > 1000);

            //Console.WriteLine(res);
            #endregion

            #region 10- All

            //List<int> Ages = new() { 13, 20, 23, 34, 43, 55 };

            //var res = Ages.All(a => a >= 18);

            //Console.WriteLine(res);
            #endregion

            #region 11- Contains

            //List<string> PL = new()
            //{
            //    "csharp", "linq", "sql"
            //};

            //var res = PL.Contains("linq");
            //Console.WriteLine(res);
            #endregion

            #region 12- Skip

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.Skip(3);

            //foreach (var r in result)
            //{
            //    Console.WriteLine(r);
            //}
            #endregion

            #region 13- Take
            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var res = numbers.Take(5);

            //foreach (var r in res)
            //{
            //   Console.WriteLine($"{r}");
            //}
            #endregion

            #region 14- Distinct

            //List<string> cities = new() {"Cairo",  "Alexandria",  "Giza", "Dubai" };

            //var res = cities.Distinct();

            //foreach (var c in cities)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion


            #region 15- Sum

            //List<int> numbers = new List<int>()
            //    {
            //        10,
            //        20,
            //        30
            //    };

            //var total = numbers.Sum();

            //Console.WriteLine(total);

            #endregion

            #region 16- Average

            //List<int> grades = new List<int>()
            //    {
            //        80,
            //        90,
            //        70
            //    };

            //double average = grades.Average();

            //Console.WriteLine(average);

            #endregion

            #region 17- Max

            //List<int> prices = new List<int>()
            //    {
            //        100,
            //        250,
            //        80,
            //        500
            //    };

            //int maxPrice = prices.Max();

            //Console.WriteLine(maxPrice);

            #endregion

            #region 18- Min

            List<int> prices = new List<int>()
                {
                    100,
                    250,
                    80,
                    500
                };

            int minPrice = prices.Min();

            Console.WriteLine(minPrice);

            #endregion
        }
    }
}
