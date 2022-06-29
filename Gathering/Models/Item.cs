namespace Gathering.Models;

public class ItemRootobject
{
    public Item[]? items { get; set; }
}

public class Item
{
    public string? id { get; set; }
    public int? slot { get; set; }
    public string? name { get; set; }
    public string? nameFr { get; set; }
    public string? nameDe { get; set; }
    public string? level { get; set; }
    public string? gatheringSkill { get; set; }
    public string? perception { get; set; }
    public string? imageUrl { get; set; }
    public string? description { get; set; }
    public string? descriptionFr { get; set; }
    public string? descriptionDe { get; set; }
}
