namespace QuestTesterLibrary.TestServices;
public class TraitCharacterService : BaseTechsCharacterService
{
    public override void AddTechs()
    {
        this.AddTraitTechs()
            .SaveTechs();
    }
}