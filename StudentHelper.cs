namespace Crud_Trys;

public static class StudentHelper
{
    public static void ListStudents(List<Students?> students)
    {
        Console.Clear();
        Console.WriteLine("TÜM ÖĞRENCİLER \n");
        int i = 1;
        foreach (var student in students)
        {
            Console.WriteLine($"{i} - {student.FirstName} {student.LastName} - TckNo: {student.TckNo} - {student.Gender} - {student.GetAge()}");
            i++;
        }
    }
}