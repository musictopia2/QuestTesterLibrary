using QuestTesterLibrary.LocatorServices;

namespace QuestTesterLibrary.ViewModels;
public class TestPlayQuestViewModel(IChooseCivViewModel civVM,
    IQuestLocatorService questService,
    IPlayQuestService playService,
    ICharacterBusinessService characterService,
    ITechBusinessService businessService
        ) : IPlayQuestViewModel
{
    public static string TestingProcess { get; set; } = "Testing Quest";
    private string SpecialTitle() => $"{TestingProcess} For Civilization {civVM.CivilizationChosen!.FullName}";
    string IPlayQuestViewModel.Title => civVM.Title(SpecialTitle);
    bool IPlayQuestViewModel.CanGoBack => civVM.CanGoBack();
    async Task IPlayQuestViewModel.PlayCivAsync()
    {
        //this means you chose to play the quest.  everything that is needed so it can open to play is needed.
        if (ll1.MainLocation == "")
        {
            throw new CustomBasicException("Must set up ahead of time now.  Since locations can change");
        }
        if (dd1.NewGamePath == "")
        {
            throw new CustomBasicException("Must set the new game path ahead of time now");
        }
        await businessService.DoAllTechsAsync();
        await characterService.CopyCharacterFilesAsync();
        questService.CopyQuest();
        playService.OpenOfflineGame(dd1.SpartanDirectoryPath);
    }
    void IPlayQuestViewModel.ResetCiv()
    {
        civVM.ResetCiv();
    }
}