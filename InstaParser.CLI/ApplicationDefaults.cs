namespace InstaParser.CLI;

public static class ApplicationDefaults
{
    public const string ApplicationName = "InstaParser";
    public static readonly string FollowersPath = Path.Combine("Data", "followers.json");
    public static readonly string FollowingPath = Path.Combine("Data", "following.json");
}