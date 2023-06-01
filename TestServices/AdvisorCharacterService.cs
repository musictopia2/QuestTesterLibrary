namespace QuestTesterLibrary.TestServices;
public class AdvisorCharacterService : BaseTechsCharacterService
{
    public override void AddTechs()
    {
        this.AddAdvisorTechs()
            .SaveTechs();
    }
}