namespace QuestTesterLibrary.LocatorServices;
public class AccumulateNoStoneOptionalLocatorService : IQuestLocatorService
{
    string IQuestLocatorService.OldQuestPath => Path.Combine(dd1.NewQuestFileDirectory, "Argos_S43_Laconia_Bandits_Legendary.quest");
    string IQuestLocatorService.OldQuestTitle => "Sample Breaking Bandits";
}