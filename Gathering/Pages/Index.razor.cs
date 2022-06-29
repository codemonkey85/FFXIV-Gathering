namespace Gathering.Pages;

public partial class Index
{
    private Models.NodeRootobject? nodes;
    private Models.ItemRootobject? items;

    protected override async Task OnInitializedAsync()
    {
        nodes = await HttpClient.GetFromJsonAsync<Models.NodeRootobject>("data/nodes.json");
        items = await HttpClient.GetFromJsonAsync<Models.ItemRootobject>("data/items.json");
    }
}
