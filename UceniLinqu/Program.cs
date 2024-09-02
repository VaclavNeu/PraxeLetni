using System.Security.Cryptography;

namespace Linq
{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1,2,1,3,1,2,4,2,3,1,2,1,2,5,9,7,1,3,4,6};  // datasource

            var jeTamNeco = list.Any();

            var jadaa = list.Contains(5);


            var numbers = list.Distinct().OrderBy(x => x).ToList();

            // var QuerySyntax = from obj in list              // from OBJECT in DATASOURCE 
            //                   where obj > 2                 // where CONDITION
            //                   select obj;                   // select OBJECT
            // foreach (var item in QuerySyntax) 
            // { 
            // Console.WriteLine(item);
            // }
            //
            // Console.WriteLine("--------------------------------------");
            //
            // var methodSyntax = list.Where(x => x > 2);
            // foreach (var item in methodSyntax)
            // {
            //     Console.WriteLine(item);
            // }
            //
            // Console.WriteLine("--------------------------------------");
            //
            // //query + method syntax
            //
            // var mixedSyntax = (from obj in list
            //                    select obj).Max();
            //
            // Console.WriteLine(mixedSyntax);




            //
            //  IEnumerable<Employee> query = from e in employees
            //                                where e.Id <= 2
            //                                select e;
            //
            //  IQueryable<Employee> query2 = employees.AsQueryable().Where(x => x.Id <= 2);
            //
            //  foreach (var item in query2)
            //  {
            //      Console.WriteLine("Id: " + item.Id + "  Name: " + item.Name);
            //  }


            //   List<Employee> employees = new List<Employee>()
            //  {
            //      new Employee(){Id=1, Name = "Vasek", Email = "Vasicek@domena.cz", programming = new List<string>{"C#", "Python" } },
            //      new Employee(){Id=2, Name = "Daemon", Email = "Daemon@domena.cz", programming = new List<string>{"Java", "Ruby"} }
            //  };

            // var selectQuery = (from emp in employees
            //                    select new               // Student() lze i takto pak jsou potreba stejna jmena
            //                    {
            //                        CustomId = emp.Id,
            //                        StudentEmail = emp.Email,
            //                        FullName = emp.Name
            //                    }).ToList();
            // 
            // var selectMethod = employees.Select(emp => new Student()   // zde vynechat studenta a bude to custom
            // {
            //     StudentId = emp.Id,
            //     StudentEmail = emp.Email,
            //     FullName = emp.Name
            // }).ToList();
            //
            // foreach (var item in selectQuery)
            // {
            //     Console.WriteLine($"Id = {item.CustomId}, Name = {item.FullName}, Email = {item.StudentEmail} ");
            // }
            //
            // var basicQuery = (from emp in employees
            //                   select emp).ToList();
            //
            // var basicMethod = employees.ToList(); // funguje stejne jako query
            //
            // var basicPropQuery = (from emp in employees
            //                       select emp.Id + 1).ToList();   // chci brat pouze ID a o jedno cislo vyssi // lze prevest i na string
            //
            // var basicPropMethod = employees.Select(emp => emp.Id).ToList();

            // var query = employees.Select((emp, index) => new { Index = index, FullName = emp.Name }).ToList();

            // foreach(var item in basicQuery)
            // {
            //     Console.WriteLine($"Id = {item.Id}, Name = {item.Name} ");
            // }


            //  List<string> strList = new List<string>() { "Vasikos", "Ahmed"};



            //  var methodResult = strList.SelectMany(x => x).ToList();       // vyber co ti vyhovuje
            //
            //  var queryResult = (from x in strList 
            //                    from y in x
            //                    select y).ToList();




            List<Employee> employees = new List<Employee>()
           {
               new Employee(){Id=1, Name = "Vasek", Email = "Vasicek@domena.cz", programming = new List<string>{"C#", "Python" },
                   technika = new List<Techs>{
                      new Techs() { Technology = "Malovani"},
                      new Techs() { Technology = "Crafteni"},
                      new Techs() {Technology = "Boooooomby"}
                   }},
               new Employee(){Id=2, Name = "Daemon", Email = "Daemon@domena.cz", programming = new List<string>{"Java", "Ruby"}, 
               technika = new List<Techs>{ 
                      new Techs() {Technology = "Skrabani"},
                      new Techs() {Technology = "Myti"}
               } },
               new Employee(){Id=3, Name = "Vasil", Email = "Vasil@seznam.cz", technika=new List<Techs>()}
           };

            //   List<Employee> employees1 = new List<Employee>()
            //  {
            //      new Employee(){Id=1, Name = "Vasek", Email = "Vasicek@domena.cz", programming = new List<string>{"C#", "Python" },
            //          technika = new List<Techs>{
            //             new Techs() { Technology = "Malovani"},
            //             new Techs() { Technology = "Crafteni"},
            //             new Techs() {Technology = "Boooooomby"}
            //          }},
            //      new Employee(){Id=2, Name = "Daemonik", Email = "Daemon12@domena.cz", programming = new List<string>{"Java", "Ruby"},
            //      technika = new List<Techs>{
            //             new Techs() {Technology = "Skrabani"},
            //             new Techs() {Technology = "Myti"}
            //      } },
            //      new Employee(){Id=3, Name = "Vasil", Email = "Vasil@seznam.cz", technika=new List<Techs>()}
            //  };
            //
            //   //  var methodQuery = employees.SelectMany(emp => emp.technika).ToList();
            //
            //   var ms = employees.Select(x => new { x.Name, x.Email }).Except(employees1.Select(x => new { x.Name, x.Email })).ToList();
            //
            //   var methodSyntax = employees.OrderByDescending(x => x.Id).ToList();



            // var querySyntax = (from str in employees
            //                    where str.technika.Count() == 0
            //                    select str).ToList();
            //
            // var methodSyntax = employees.Where(emp => emp.technika.Count() == 0).ToList();


            //  var methodSyntax = employees.SelectMany(emp => emp.programming).ToList(); 
            //
            //  var querySyntax = (from emp in employees
            //                     from lang in emp.programming
            //                     select lang).ToList();


            // foreach (var item in methodQuery)
            // {
            //     Console.WriteLine(item);
            // }


            //  var datasource = new List<string> { "Abdul", "Mohamad", "Nigger"};

            // var querySyntax = (from qn in datasource              //cisla
            //                    where qn > 4
            //                    select qn).ToList();
            //
            // var methodsyntax = datasource.Where(qn => qn > 4).ToList();

            //  var querySyntax = (from str in datasource 
            //                     where str.Length == 5
            //                     select str).ToList();
            //      
            //  var methodSyntax = datasource.Where(str => str.Length != 5).ToList();




            //   Student[] students = { new Student {StudentId = 1, FullName = "Pepina" , Marks = 90 },
            //   new Student {StudentId = 2, FullName = "Vaclav", Marks = 80 },
            //   new Student {StudentId = 3, FullName = "Abraham", Marks = 30 } };
            //
            //
            //   var checkZnamek = students.Any(x => x.Marks < 50);
            //
            //   var ms = students.Distinct().ToList();



            //  List<string> datasource1 = new List<string>() { "A", "B", "C", "D"};
            //  List<string> datasource2 = new List<string>() { "C", "D", "E", "F" };
            //
            //
            //
            //
            //
            //  var ms1 = datasource1.Except(datasource2).ToList();   // list pomoci get =>  var ms = student.Select(x=> x.Name).Except(student1.Select(x=>x.Name)).ToList()

            // => .Intersect vypise stejny veci narozdil od except

            // .Union vypise vse uniqatni




            int[] numbers1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 4, 1, 2 ,3};


            var ms = numbers1.Where(x => x > 4).Take(5).ToList();   // .Take je mozne prohodit s .Where


            var skipak = numbers1.Where(x => x > 5).Skip(2).ToList();

            var SkipakosWhilos = numbers1.SkipWhile(x => x < 3).ToList();


            int totalPagePerView = 5;

            Console.WriteLine("Napis cislo stranky");

           if (int.TryParse(Console.ReadLine(), out int pageNumber))
            {
                var ms5 = GetEmployees().Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView);

                foreach( var item in ms5)
                {
                    Console.WriteLine($"Id = {item.Id} and Name = {item.Name}");
                }
            }
            else
            {
                Console.WriteLine("Vloz spravne cislo");
            }



            Console.WriteLine("Stiskni ENTER ");
            Console.ReadLine();







        }

        public static List<Employee> GetEmployees() 
        {
            return new List<Employee>() {
            new Employee() { Id = 1, Name = "Mario" },
            new Employee() { Id = 2, Name = "Emilio scra"},
            new Employee() { Id = 3, Name = "Palo Lacina"},
            new Employee() { Id = 4, Name = "Erik Meldik"},
            new Employee() { Id = 5, Name = "Mario" },
            new Employee() { Id = 6, Name = "Emilio scra"},
            new Employee() { Id = 7, Name = "Palo Lacina"},
            new Employee() { Id = 8, Name = "Erik Meldik"},
            new Employee() { Id = 9, Name = "Mario" },
            new Employee() { Id = 10, Name = "Emilio scra"},
            new Employee() { Id = 11, Name = "Palo Lacina"},
            new Employee() { Id = 13, Name = "Erik Meldik"},
            new Employee() { Id = 14, Name = "Mario" },
            new Employee() { Id = 15, Name = "Emilio scra"},
            new Employee() { Id = 16, Name = "Palo Lacina"},
            new Employee() { Id = 17, Name = "Erik Meldik"},
            };
        }

     //  class StudentComparer  : IEqualityComparer<Student> 
     //  {
     //  public bool Equals(Student x, Student y)
     //      {
     //          return x.StudentId.Equals(y.StudentId) && y.FullName.Equals(y.FullName);
     //      }
     //
     //      public int GetHashCode(Student obj)
     //      {
     //          int idHashCode = obj.StudentId.GetHashCode();
     //          int NameHashCode = obj.FullName.GetHashCode();
     //
     //          return idHashCode ^ NameHashCode;
     //      }
     //  }

        
    }
}