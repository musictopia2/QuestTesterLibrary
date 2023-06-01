namespace QuestTesterLibrary.Components;
public partial class ShellComponent
{
    [Inject]
    [AllowNull]
    private IPlayQuestViewModel DataContext { get; set; }
    private string _civAbb = "";
    protected override void OnInitialized()
    {
        if (gg1.CurrentlyTestingSingle && gg1.CurrentCivAbb != "")
        {
            _civAbb = gg1.CurrentCivAbb;
        }
        base.OnInitialized();
    }

    //[Parameter]
    //public string CivAbbAlone { get; set; } = "";
    private void GoBack()
    {
        DataContext.ResetCiv();
    }
    private void Refresh()
    {
        StateHasChanged();
    }
}