namespace QuestTesterLibrary.TestServices;
public class AdvisorTechService : BaseAddTechsService
{
    public override void AddTechs()
    {
        this.AddAdvisorTechs(tt1.AdvisorsPath);
    }
}