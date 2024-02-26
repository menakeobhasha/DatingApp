namespace API;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateOnly dbo)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);

        var age = today.Year - dbo.Year;

        if (dbo > today.AddYears(-age)) age--;

        return age;
    }
}
