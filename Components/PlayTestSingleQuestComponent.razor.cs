
using QuestTesterLibrary.LocatorServices;

namespace QuestTesterLibrary.Components;
public partial class PlayTestSingleQuestComponent
{
    [Inject]
    [AllowNull]
    private IQuestLocatorService QuestLocator { get; set; }
    [Inject]
    [AllowNull]
    private IPlayQuestViewModel DataContext { get; set; }
}