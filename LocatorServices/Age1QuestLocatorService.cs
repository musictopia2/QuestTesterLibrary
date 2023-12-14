namespace QuestTesterLibrary.LocatorServices;
public class Age1QuestLocatorService : IQuestLocatorService
{
    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Archives_Halloween2020_M024_BigQuest4.quest");
    string IQuestLocatorService.OldQuestTitle => "Sample Bring Out Your Dead";
}