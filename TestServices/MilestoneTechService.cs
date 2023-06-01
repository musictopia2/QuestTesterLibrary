namespace QuestTesterLibrary.TestServices;
public class MilestoneTechService : BaseAddTechsService
{
    public override void AddTechs()
    {
        this.AddSingleTech(tt1.MilestonesPath);
    }
}