namespace QuestTesterLibrary.TestServices;
public class WonderTechService : BaseAddTechsService
{
    public override void AddTechs()
    {
        this.AddMultipleMiscTechs(tt1.WondersPath);
    }
}