namespace _01._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>(); // списък с обкети students

            for (int i = 1; i <= countStudents; i++) 
            {
                String data = Console.ReadLine(); // данни за студента
                string[] dataParts = data.Split(" "); // създава масив от стрингове, като разделя data
                // data = Desislava Topuzakova 4.50
                //data.Split(" ")
                //dataParts = ["Desislava", "Topuzakova", "4.50"]

                string firstName = dataParts[0]; // "Desislava"
                string lastName = dataParts[1]; // "Topuzakova"
                double grade = double.Parse(dataParts[2]); // стринга "4.50" се парсва към число от тип double "4.50"

                Student student = new Student(firstName, lastName, grade); // създава обект student от class Student
                students.Add(student); // добавя обекта student в списък с обекти students

            }

            // списък с обкети students от class Student
            // 1. сортирам по оценка в descending order (намаляващ ред)
            students = students.OrderByDescending(x => x.Grade).ToList();

            //2. принтирам елементите в списъка
            
            foreach (Student student in students) 
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }

        }
    }
}