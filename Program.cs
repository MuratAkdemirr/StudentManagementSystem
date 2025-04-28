using System.Net.Sockets;
using System.Threading.Channels;
using Crud_Trys;

var studentList = new List<Students>();

var murat = new Students()
{
    FirstName = "Murat",
    LastName = "Akdemir",
    TckNo = 48945658721,
    BirthDate = new DateOnly(1997, 07, 21),
    Gender = "Erkek"
};
var berke = new Students()
{
    FirstName = "Berke",
    LastName = "Uzuner",
    TckNo = 38945652614,
    BirthDate = new DateOnly(1998, 8, 17),
    Gender = "Erkek"
};
var ortunc = new Students()
{
    FirstName = "Ortunc",
    LastName = "Tunc",
    TckNo = 48756487123,
    BirthDate = new DateOnly(2000, 01, 12),
    Gender = "Erkek"
};
studentList.Add(murat);
studentList.Add(berke);
studentList.Add(ortunc);
while (true)
{
    Console.Clear();
    var inputSelection =
        MenuHelper.AskOption("Yapmak istediğin işlemi seç", ["Listele", "Ekle", "Sil", "Güncelle", "Çıkış"]);
    if (inputSelection == 1)
    {
        StudentHelper.ListStudents(studentList);
    }
    else if (inputSelection == 2)
    {
        Console.WriteLine("Öğrenci girişi".ToUpper());
        Console.Write("Öğrenci Adı: ");
        var inputName = Console.ReadLine();
        Console.Write("Öğrenci Soyadı: ");
        var inputlastName = Console.ReadLine();
        Console.Write("Öğrenci TCKNO: ");
        long inputTckNo = long.Parse(Console.ReadLine());
        Console.Write("Öğrenci Doğum Tarihi(YYYY.AA.GG): ");
        var inputBirthDate = DateOnly.Parse(Console.ReadLine());
        Console.Write("Öğrenci Cinsiyeti: ");
        var inputGender = Console.ReadLine();
        studentList.Add(new Students
        {
            FirstName = inputName,
            LastName = inputlastName,
            TckNo = inputTckNo,
            BirthDate = inputBirthDate,
            Gender = inputGender
        });
    }
    else if (inputSelection == 3)
    {
        StudentHelper.ListStudents(studentList);
        Console.Write("Silmek istediğiniz öğrenciyi seçiniz: ");
        var inputStudentToDelete = int.Parse(Console.ReadLine());
        studentList.Remove(studentList[inputStudentToDelete - 1]);
    }
    else if (inputSelection == 4)
    {
        StudentHelper.ListStudents(studentList);
        var inputStudentSelection = MenuHelper.AskNumber("Güncellemek İstediğiniz Öğrenciyi Seçiniz.");
        int inputSecondSelection = MenuHelper.AskOption("Yapmak istediğin işlemi seç",
        [
            "İsim Güncelleme: ", "Soyisim Güncelleme: ", "TckNo Güncelleme: ", "Doğum Tarihi Güncelleme(YYYY.AA.GG): ",
            "Cinsiyet Güncelleme: ", "Çıkış"
        ]);
        switch (inputSecondSelection)
        {
            case 1:
                Console.Write("Öğrenci Adı Güncelleme: ");
                var inputName = Console.ReadLine();
                studentList[inputStudentSelection - 1].FirstName = inputName;
                break;
            case 2:
                Console.Write("Öğrenci Soyadı Güncelleme: ");
                var inputLastName = Console.ReadLine();
                studentList[inputStudentSelection - 1].LastName = inputLastName;
                break;
            case 3:
                Console.Write("Öğrenci TCKNO Güncelleme: ");
                long inputTckNo = long.Parse(Console.ReadLine());
                studentList[inputStudentSelection - 1].TckNo = inputTckNo;
                break;
            case 4:
                Console.Write("Öğrenci Doğum Tarihi(YYYY.AA.GG) Güncelleme: ");
                var inputBirthDate = DateOnly.Parse(Console.ReadLine());
                studentList[inputStudentSelection - 1].BirthDate = inputBirthDate;
                break;
            case 5:
                Console.Write("Öğrenci Cinsiyeti Güncelleme: ");
                var inputGender = Console.ReadLine();
                studentList[inputStudentSelection - 1].Gender = inputGender;
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Hoşçakalın..");
        Thread.Sleep(750);
        break;
    }

    Console.WriteLine("\nMenüye dönmek için bir tuşa basınız.");
    Console.ReadKey(true);
}