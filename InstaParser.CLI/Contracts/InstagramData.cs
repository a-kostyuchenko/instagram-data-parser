using Newtonsoft.Json;

namespace InstaParser.CLI.Contracts;

public class InstagramData
{
    [JsonProperty("relationships_following")]
    public List<Relationship> Relationships { get; set; }
}