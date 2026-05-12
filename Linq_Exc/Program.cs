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

            List<Student> students = new List<Student>();

            Student student1 = new Student();
            student1.Name = "Mourad";
            student1.Age = 30;

            Student student2 = new Student();

            student2.Name = "Mona";
            student2.Age = 25;

            Student student3 = new Student();
            student3.Name = "Mai";
            student3.Age = 20;

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            var res = students.OrderBy(r => r.Age);

            foreach (Student s in res)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Age);
            }
          


            #endregion
        }
    }
}
