namespace Gathering.Models;

public class Node
{
    [JsonPropertyName("id")] public string? Id { get; set; }
    [JsonPropertyName("type")] public string? Type { get; set; }
    [JsonPropertyName("subType")] public string? SubType { get; set; }
    [JsonPropertyName("zone")] public string? Zone { get; set; }
    [JsonPropertyName("zoneFr")] public string? ZoneFr { get; set; }
    [JsonPropertyName("zoneDe")] public string? ZoneDe { get; set; }
    [JsonPropertyName("teleport")] public string? Teleport { get; set; }
    [JsonPropertyName("teleportFr")] public string? TeleportFr { get; set; }
    [JsonPropertyName("teleportDe")] public string? TeleportDe { get; set; }
    [JsonPropertyName("position")] public Position? Position { get; set; }
    [JsonPropertyName("startTime")] public string? StartTime { get; set; }
    [JsonPropertyName("endTime")] public string? EndTime { get; set; }
    [JsonPropertyName("itemIds")] public string[]? ItemIds { get; set; }
}

public class Position
{
    [JsonPropertyName("x")] public decimal? X { get; set; }
    [JsonPropertyName("y")] public decimal? Y { get; set; }
}
