namespace QuestTesterLibrary.Components;
public partial class ChooseCivComponent
{
    [Inject]
    private IChooseCivViewModel? DataContext { get; set; }
    [Parameter]
    public EventCallback<CivilizationBasicModel> ChoseCiv { get; set; }
    private readonly AutoCompleteStyleModel _autos = new();
    protected override async Task OnInitializedAsync()
    {
        _combo = null;
        _autos.Width = "90vw"; //try this way (?)
        _autos.Height = "50vh";
        await DataContext!.InitAsync();
    }
    private ComboBoxGenericList<CivilizationBasicModel>? _combo;
    private bool _focused;
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (_focused == false && _combo is not null)
        {
            _focused = true;
            await _combo.TextReference!.Value.FocusAsync();
        }
    }
    private async Task OnComboEnterAsync()
    {
        CivilizationBasicModel? civ = DataContext!.CivilizationChosen ?? throw new CustomBasicException("Did not choose civ.  Rethink");
        DataContext.CivilizationChosen = null; //i think.
        if (civ == null)
        {
            throw new CustomBasicException("Cannot reset to null.  Rethink");
        }
        await ChoseCiv.InvokeAsync(civ);
    }
}