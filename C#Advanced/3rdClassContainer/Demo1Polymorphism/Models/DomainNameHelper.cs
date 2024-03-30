namespace Models;
public static class DomainNameHelper
{
    public static string GetUserName(string fullUserName)
    {
        return fullUserName.Replace("SEDC\\", "");
    }
    public static string GetFullName(string fullUserName)
    {
        return GetUserName(fullUserName).Replace(".", " ");
    }
}
