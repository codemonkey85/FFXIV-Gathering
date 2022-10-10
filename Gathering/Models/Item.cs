namespace Gathering.Models;

public class Item
{
    [JsonPropertyName("id")] public string? Id { get; set; }
    [JsonPropertyName("slot")] public int? Slot { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("nameFr")] public string? NameFr { get; set; }
    [JsonPropertyName("nameDe")] public string? NameDe { get; set; }
    [JsonPropertyName("level")] public string? Level { get; set; }
    [JsonPropertyName("gatheringSkill")] public string? GatheringSkill { get; set; }
    [JsonPropertyName("perception")] public string? Perception { get; set; }
    [JsonPropertyName("imageUrl")] public string? ImageUrl { get; set; }
    [JsonPropertyName("description")] public string? Description { get; set; }
    [JsonPropertyName("descriptionFr")] public string? DescriptionFr { get; set; }
    [JsonPropertyName("descriptionDe")] public string? DescriptionDe { get; set; }
}
