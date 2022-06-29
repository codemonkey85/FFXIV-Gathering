namespace Gathering.Models;

public class NodeRootobject
{
    public Node[]? nodes { get; set; }
}

public class Node
{
    public string? id { get; set; }
    public string? type { get; set; }
    public string? subType { get; set; }
    public string? zone { get; set; }
    public string? zoneFr { get; set; }
    public string? zoneDe { get; set; }
    public string? teleport { get; set; }
    public string? teleportFr { get; set; }
    public string? teleportDe { get; set; }
    public Position? position { get; set; }
    public string? startTime { get; set; }
    public string? endTime { get; set; }
    public string[]? itemIds { get; set; }
}

public class Position
{
    public decimal? x { get; set; }
    public decimal? y { get; set; }
}
