using Newtonsoft.Json;

namespace InstaParser.CLI.Contracts;

public class Relationship
{
    [JsonProperty("string_list_data")]
    public List<Metadata> Metadata { get; set; }
}