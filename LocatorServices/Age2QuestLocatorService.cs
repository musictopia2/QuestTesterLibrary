namespace QuestTesterLibrary.LocatorServices;
public class Age2QuestLocatorService : IQuestLocatorService
{
    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Archives_Halloween2020_M024_BigQuest5.quest");
    string IQuestLocatorService.OldQuestTitle => "Sample Only The Gourd Die Young";
}