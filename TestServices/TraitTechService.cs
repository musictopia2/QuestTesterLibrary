namespace QuestTesterLibrary.TestServices;
public class TraitTechService : BaseAddTechsService
{
    public override void AddTechs()
    {
        this.AddSingleTech(tt1.TraitsPath);
    }
}