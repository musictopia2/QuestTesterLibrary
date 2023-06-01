namespace QuestTesterLibrary.Components;
public partial class PlayQuestComponent
{
    [Inject]
    [AllowNull]
    private IQuestLocatorService QuestLocator { get; set; }
    [Inject]
    [AllowNull]
    private IPlayQuestViewModel DataContext { get; set; }
}