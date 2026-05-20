public static class LogAnalysis
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type

    public static String SubstringAfter(this string str, string after) => str[(str.IndexOf(after) + after.Length)..];

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static String SubstringBetween(this string str, string before, string after) => str[(str.IndexOf(before) + before.Length)..(str.IndexOf(after))].Trim();

    // TODO: define the 'Message()' extension method on the `string` type
    public static String Message(this string str) => str[(str.IndexOf(":") + 1)..].Trim();

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static String LogLevel(this string str) => str[(str.IndexOf("[") + 1)..(str.IndexOf("]"))].Trim();
}