using ADO.NET_Lab7_Linq;
using System.Linq;

internal class Program
{
    static List<Student> students = new List<Student>
        {
           new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
           new Student {First="Claire", Last="O’Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
           new Student {First="Vladislav", Last="Ivanov", ID=113, Scores= new List<int> {100, 100, 100, 100}},
           new Student {First="Petr", Last="Petrov", ID=114, Scores= new List<int> {90, 90, 90, 95}},
           new Student {First="Vladimir", Last="Sidorov", ID=115, Scores= new List<int> {63, 45, 32, 24}},
           new Student {First="Eldar", Last="Mokriy", ID=116, Scores= new List<int> {99, 99, 32, 20}},
           new Student {First="Denis", Last="Bistrenko", ID=116, Scores= new List<int> {91, 99, 32, 20}},
        };

    static void Main(string[] args)
    {
        IEnumerable<Student> studentQuery =
            from student in students
            where student.Scores[0] > 90 && student.Scores[3] < 80
            //orderby student.Last ascending
            orderby student.Scores[0] descending
            select student;
        foreach (Student student in studentQuery)
        {
            Console.WriteLine("{0}, {1} {2}", student.Last, student.First, student.Scores[0]);
        }
        Console.WriteLine("\n \n \n \n");
        var studentQuery2 =
        from student in students
        group student by student.Last[0];
        foreach (var studentGroup in studentQuery2)
        {
            Console.WriteLine(studentGroup.Key);
            foreach (Student student in studentGroup)
            {
                Console.WriteLine("   {0}, {1}",
                          student.Last, student.First);
            }
        }
        Console.WriteLine("\n \n \n \n");
        var studentQuery3 =
        from student in students
        group student by student.Last[0];

        foreach (var groupOfStudents in studentQuery3)
        {
            Console.WriteLine(groupOfStudents.Key);
            foreach (var student in groupOfStudents)
            {
                Console.WriteLine("   {0}, {1}",
                    student.Last, student.First);
            }
        }
        Console.WriteLine("\n \n \n \n");
        var studentQuery4 =
        from student in students
        group student by student.Last[0] into studentGroup
        orderby studentGroup.Key
        select studentGroup;

        foreach (var groupOfStudents in studentQuery4)
        {
            Console.WriteLine(groupOfStudents.Key);
            foreach (var student in groupOfStudents)
            {
                Console.WriteLine("   {0}, {1}",
                    student.Last, student.First);
            }
        }
        Console.WriteLine("\n \n \n \n");
        var studentQuery5 =
        from student in students
        let totalScore = student.Scores[0] + student.Scores[1] +
            student.Scores[2] + student.Scores[3]
        where totalScore / 4 < student.Scores[0]
        select student.Last + " " + student.First;

        foreach (string s in studentQuery5)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine("\n \n \n \n");
        var studentQuery6 =
        from student in students
        let totalScore = student.Scores[0] + student.Scores[1] +
            student.Scores[2] + student.Scores[3]
        select totalScore;

        double averageScore = studentQuery6.Average();
        Console.WriteLine("Class average score = {0}", averageScore);
        Console.WriteLine("\n \n \n \n");
        var studentQuery8 =
           from student in students
           let x = student.Scores[0] + student.Scores[1] +
               student.Scores[2] + student.Scores[3]
           where x > averageScore
           select new { id = student.ID, score = x };

        foreach (var item in studentQuery8)
        {
            Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
        }
    }
}
