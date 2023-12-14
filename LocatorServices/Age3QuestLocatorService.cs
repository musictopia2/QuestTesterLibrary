namespace QuestTesterLibrary.LocatorServices;
public class Age3QuestLocatorService : IQuestLocatorService
{
    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Archives_Halloween2019_M023_BigQuest3.quest");
    string IQuestLocatorService.OldQuestTitle => "Sample Finest Horror";
}