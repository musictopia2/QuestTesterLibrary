namespace QuestTesterLibrary.TestServices;
public class CompleteTechsService : BaseAddTechsService
{
    public override void AddTechs()
    {
        this.AddSingleTech(tt1.MilestonesPath)
            .AddMultipleMiscTechs(tt1.WondersPath)
            .AddSingleTech(tt1.TraitsPath)
            .AddAdvisorTechs(tt1.AdvisorsPath);
    }
}