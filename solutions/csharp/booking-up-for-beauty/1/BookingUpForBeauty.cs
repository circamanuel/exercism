static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime parseDate;
        DateTime.TryParse(appointmentDateDescription, out parseDate);
        return parseDate;

    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        int result = DateTime.Compare(appointmentDate, DateTime.Now);

        return  (result < 0);
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int hour = appointmentDate.Hour;
        return (hour >= 12 && hour < 18);
    }

    public static string Description(DateTime appointmentDate)
    {
        return ($"You have an appointment on {appointmentDate}.");
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
