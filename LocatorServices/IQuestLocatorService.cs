namespace QuestTesterLibrary.LocatorServices;
public interface IQuestLocatorService
{
    string OldQuestPath { get; } //this is where we decide what old quest to play.
    string OldQuestTitle { get; } //also needs the old quest title as well.  i could decide to hard code.
}