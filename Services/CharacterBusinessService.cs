namespace QuestTesterLibrary.Services;
public class CharacterBusinessService(ICivilizationContext civilization,
    ICharacterFileModifierService add
        ) : ICharacterBusinessService //this is still testing.  because otherwise, something else would show the civ info.
{
    async Task ICharacterBusinessService.CopyCharacterFilesAsync()
    {
        //this is where it has to generate the character file.
        //all the techs has to be where it needs to at this point.
        cc1.CleanCharacterFiles();
        if (civilization.CurrentCivilization is null)
        {
            throw new CustomBasicException("Did not choose a civ");
        }
        string abb = civilization.CivAbb;
        string newPath = dd1.NewCharacterLocation(abb); //i think this is fine now.
        string oldPath = abb.GetCharacterPath();
        await ff1.FileCopyAsync(oldPath, newPath);
        XElement source = XElement.Load(newPath);
        var techs = source.Descendants("activetechs").Single();
        add.Source = source;
        add.Tech = techs;
        add.CharacterPath = newPath;
        add.ModifyCharacterFile();
    }
}