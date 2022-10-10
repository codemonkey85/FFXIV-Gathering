namespace Gathering.Pages;

public partial class Index
{
    private List<Node>? _nodes;
    private List<Item>? _items;

    protected override async Task OnInitializedAsync()
    {
        _nodes = await HttpClient.GetFromJsonAsync<List<Node>>("data/nodes.json");
        _items = await HttpClient.GetFromJsonAsync<List<Item>>("data/items.json");
    }
}
