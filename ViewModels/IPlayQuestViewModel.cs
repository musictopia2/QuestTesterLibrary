namespace QuestTesterLibrary.ViewModels;
public interface IPlayQuestViewModel
{
    //decided to have the main here now.
    Task PlayCivAsync();
    string Title { get; }
    bool CanGoBack { get; }
    void ResetCiv();
}