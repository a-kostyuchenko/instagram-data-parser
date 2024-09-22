using InstaParser.CLI;
using InstaParser.CLI.Contracts;
using Newtonsoft.Json;

Console.Title = ApplicationDefaults.ApplicationName;

string followersJson = File.ReadAllText(
    Path.Combine(Directory.GetCurrentDirectory(),
        ApplicationDefaults.FollowersPath));

string followingJson = File.ReadAllText(
    Path.Combine(Directory.GetCurrentDirectory(), 
        ApplicationDefaults.FollowingPath));

List<Relationship> followersData = JsonConvert.DeserializeObject<List<Relationship>>(followersJson)!;

InstagramData followingData = JsonConvert.DeserializeObject<InstagramData>(followingJson)!;

List<string> followers = followersData
    .Select(follower => follower.Metadata[0].Value)
    .ToList();
    
List<string> following = followingData.Relationships
    .Select(following => following.Metadata[0].Value)
    .ToList();

List<string> unfollowed = following.Except(followers).ToList();

unfollowed.ForEach(Console.WriteLine);