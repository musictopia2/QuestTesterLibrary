using QuestTesterLibrary.LocatorServices;

namespace QuestTesterLibrary.Extensions;
public static class MiscExtensions
{
    public static void CopyQuest(this IQuestLocatorService quest)
    {
        string oldPath = quest.OldQuestPath;
        string newPath = dd1.NewQuestPath;
        ff1.FileCopy(oldPath, newPath);
    }
    public static string Title(this IChooseCivViewModel viewModel, Func<string> extras)
    {
        if (viewModel.CivilizationChosen is null)
        {
            return "Choose Civilization";
        }
        return extras.Invoke();
    }
    public static bool CanGoBack(this IChooseCivViewModel viewModel) => viewModel.CivilizationChosen is not null;
    public static void ResetCiv(this IChooseCivViewModel viewModel)
    {
        viewModel.CivilizationChosen = null;
    }
}