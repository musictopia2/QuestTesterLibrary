namespace QuestTesterLibrary.TestServices;
public class CharacterBusinessService : ICharacterBusinessService //this is still testing.  because otherwise, something else would show the civ info.
{
    private readonly IChooseCivViewModel _civChooser;
    private readonly IAddTechsToCharacterService _add;
    public CharacterBusinessService(IChooseCivViewModel civChooser,
        IAddTechsToCharacterService add
        )
    {
        _civChooser = civChooser;
        _add = add;
    }

    async Task ICharacterBusinessService.CopyCharacterFilesAsync()
    {
        //this is where it has to generate the character file.
        //all the techs has to be where it needs to at this point.
        cc1.CleanCharacterFiles();
        if (_civChooser.CivilizationChosen is null)
        {
            throw new CustomBasicException("Did not choose a civ");
        }
        string abb = _civChooser.CivilizationChosen.Abbreviation;
        string newPath = dd1.NewCharacterLocation(abb); //i think this is fine now.
        string oldPath = abb.GetCharacterPath();
        await ff1.FileCopyAsync(oldPath, newPath);
        XElement source = XElement.Load(newPath);
        var techs = source.Descendants("activetechs").Single();
        _add.Source = source;
        _add.Tech = techs;
        _add.CharacterPath = newPath;
        _add.AddTechs();
    }
}