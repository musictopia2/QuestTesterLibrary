namespace QuestTesterLibrary.Components;
public partial class TestComponent
{
    [Inject]
    [AllowNull]
    private IChooseCivViewModel DataContext { get; set; }
    [Parameter]
    [AllowNull]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public string Title { get; set; } = "";
    [Parameter]
    public bool HasBack { get; set; } = true;//on main page, will not have backs.  but single pages would have back.
    [Parameter]
    public EventCallback BackClicked { get; set; }
    [Parameter]
    public string CivAbbAlone { get; set; } = "";
    protected override async Task OnInitializedAsync()
    {
        if (CivAbbAlone != "")
        {
            await DataContext.InitAsync();
            DataContext.CivilizationChosen = DataContext.Civilizations.Single(x => x.Abbreviation == CivAbbAlone);
            await ChoseCiv.InvokeAsync();
        }
    }
    private void ChoseCivAsync(CivilizationBasicModel civ)
    {
        DataContext.CivilizationChosen = civ; //hopefully this simple this time.
        ChoseCiv.InvokeAsync();
    }
    [Parameter]
    public EventCallback ChoseCiv { get; set; }
}