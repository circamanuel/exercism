static class Badge
{

    public static string Print(int? id, string name, string? department = "owner")
    {
        department = (department ?? "owner").ToUpper();

        if (id != null)
        {
            return $"[{id}] - {name} - {department}";
        }
        
        return $"{name} - {department}";
    }
   
}
