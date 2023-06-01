namespace QuestTesterLibrary.TestServices;
public class WonderCharacterService : BaseTechsCharacterService
{
    public override void AddTechs()
    {
        this.AddWonderTechs()
            .SaveTechs();
    }
}