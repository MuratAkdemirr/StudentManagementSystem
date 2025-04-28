namespace Crud_Trys;

public class Students
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public long TckNo { get; set; }
    public DateOnly BirthDate { get; set; }
    public string Gender { get; set; }
    
    public int GetAge()
    {
        return CalculateAge();
    }

    private int CalculateAge()
    {
        var today = DateOnly.FromDateTime(DateTime.Now);
        var age = today.Year - BirthDate.Year;
        if (today < BirthDate.AddYears(age))
        {
            age--;
        }

        return age;
    }
}
