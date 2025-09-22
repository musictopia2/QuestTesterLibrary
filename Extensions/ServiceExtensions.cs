using QuestTesterLibrary.Services;

namespace QuestTesterLibrary.Extensions;
public static class ServiceExtensions
{
    //this means if i choose not to use the default implementation, then can do something else (to accomodate testing single champion mode quests).  later can rethink.  if i improve, can do as well.
    public static IServiceCollection RegisterBasicsForTesting(this IServiceCollection services, Action<IServiceCollection> others)
    {
        services.AddSingleton<IChooseCivViewModel, ChooseCivViewModel>()
            .AddSingleton<ICivilizationDataService, InMemoryCivilizationDataService>()
            .AddSingleton<IPlayQuestService, PlayQuestService>()
            .AddSingleton<ICharacterBusinessService, CharacterBusinessService>()
            .AddSingleton<ICivilizationContext, CivilizationContext>()
            ;
        others.Invoke(services);
        return services;
    }
}