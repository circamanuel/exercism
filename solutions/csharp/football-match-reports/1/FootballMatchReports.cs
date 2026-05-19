public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum)
    {
        switch (shirtNum)
        {
            case 1:
                return "goalie";
            case 2:
                return "left back";
            case < 4:
                return "center back";
            case 5:
                return "right back";
            case < 9:
                return "midfielder";
            case 9:
                return "left wing";
            case 10:
                return "striker";
            case 11:
                return "right wing";
            default:
                return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int:
                return $"There are {report} supporters at the match.";
            case string:
                return report.ToString();
            case Foul d:
                return d.GetDescription();
            case Injury i:
                return $"Oh no! {i.GetDescription()} Medics are on the field.";
            case Incident i:
                return i.GetDescription();
            case Manager m:
                return m.Club == null ? m.Name.ToString() : $"{m.Name} ({m.Club})";
            default:
                return "";
        }
    }
}
