namespace QuestTesterLibrary.TestServices;
public class MilestoneCharacterService : BaseTechsCharacterService
{
    public override void AddTechs()
    {
        this.AddMilestoneTechs()
            .SaveTechs();
    }
}