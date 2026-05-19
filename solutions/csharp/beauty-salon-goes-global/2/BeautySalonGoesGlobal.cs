using System.Globalization;
using System.Runtime.InteropServices;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        string? zoneId = "";
        TimeZoneInfo? timeZone;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            zoneId = location switch
            {
                Location.Paris => "Europe/Paris",
                Location.London => "Europe/London",
                Location.NewYork => "America/New_York",
                _ => throw new ArgumentOutOfRangeException(nameof(location), location, "Unknown location")
            };
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            zoneId = location switch
            {
                Location.Paris => "W. Europe Standard Time",
                Location.London => "GMT Standard Time",
                Location.NewYork => "Eastern Standard Time",
                _ => throw new ArgumentOutOfRangeException(nameof(location), location, "Unknown location")
            };
        }

        timeZone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);
        return TimeZoneInfo.ConvertTimeToUtc(DateTime.Parse(appointmentDateDescription), timeZone);

    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Late => appointment.AddMinutes(-30),
            _ => appointment.AddMinutes(-105)
        };
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        string? zoneId = "";
        TimeZoneInfo? timeZone;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            zoneId = location switch
            {
                Location.Paris => "Europe/Paris",
                Location.London => "Europe/London",
                Location.NewYork => "America/New_York",
                _ => throw new ArgumentOutOfRangeException(nameof(location), location, "Unknown location")
            };
        }
        else
        {
            zoneId = location switch
            {
                Location.Paris => "W. Europe Standard Time",
                Location.London => "GMT Standard Time",
                Location.NewYork => "Eastern Standard Time",
                _ => throw new ArgumentOutOfRangeException(nameof(location), location, "Unknown location")
            };
        }

        timeZone = TimeZoneInfo.FindSystemTimeZoneById(zoneId);

        bool IsNowDaylightSavint = timeZone.IsDaylightSavingTime(dt);
        bool IsLastWeekDaylightSavint = timeZone.IsDaylightSavingTime(dt.AddDays(-7));

        return IsLastWeekDaylightSavint != IsNowDaylightSavint;
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
            CultureInfo culture = location switch
            {
                Location.Paris => new CultureInfo("fr-FR"),
                Location.London => new CultureInfo("en-GB"),
                Location.NewYork => new CultureInfo("en-US"),
                _ => throw new ArgumentOutOfRangeException(nameof(location), location, "Unknown location")
            };
        DateTime.TryParse(dtStr, culture, out DateTime result);
        return result;
    }
}
