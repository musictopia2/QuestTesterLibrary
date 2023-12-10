namespace QuestTesterLibrary.Components;
public partial class PlaySeveralQuestsComponent
{
    [Parameter]
    [EditorRequired]
    public string QuestTitle { get; set; } = "";

    [Parameter]
    public EventCallback PlayQuestClicked { get; set; }
}