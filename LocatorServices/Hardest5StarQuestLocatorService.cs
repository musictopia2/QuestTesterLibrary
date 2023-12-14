namespace QuestTesterLibrary.LocatorServices;
public class Hardest5StarQuestLocatorService : IQuestLocatorService
{
    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Rhakotis_M0109_Quest_8_Legendary.quest");
    string IQuestLocatorService.OldQuestTitle => "Sample Valley Of The Kings";
}