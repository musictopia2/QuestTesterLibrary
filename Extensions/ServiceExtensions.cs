namespace QuestTesterLibrary.Extensions;
public static class ServiceExtensions
{
    private static void CheckUp()
    {
        if (tt1.MilestonesPath == "")
        {
            throw new CustomBasicException("No milestones path");
        }
        if (tt1.AdvisorsPath == "")
        {
            throw new CustomBasicException("No advisors path");
        }
        if (tt1.TraitsPath == "")
        {
            throw new CustomBasicException("No traits path");
        }
        if (tt1.WondersPath == "")
        {
            throw new CustomBasicException("No wonders path");
        }
    }
    public static IServiceCollection RegisterBasicsForTesting(this IServiceCollection services)
    {
        services.RegisterBasicsForTesting(services =>
        {
            services.AddSingleton<IPlayQuestViewModel, TestPlayQuestViewModel>()
            .AddSingleton<ITechBusinessService, TechBusinessService>();
        });
        return services;
    }
    //this means if i choose not to use the default implementation, then can do something else (to accomodate testing single champion mode quests).  later can rethink.  if i improve, can do as well.
    public static IServiceCollection RegisterBasicsForTesting(this IServiceCollection services, Action<IServiceCollection> others)
    {
        CheckUp();
        services.AddSingleton<IChooseCivViewModel, ChooseCivViewModel>()
            .AddSingleton<ICivilizationDataService, InMemoryCivilizationDataService>()
            .AddSingleton<IPlayQuestService, PlayQuestService>()
            .AddSingleton<ICharacterBusinessService, CharacterBusinessService>();
        others.Invoke(services);
        return services;
    }
    //if i want other services, just add a new IQuestLocatorService.
    public static IServiceCollection RegisterTestQuestFinestHorrorServices(this IServiceCollection services)
    {
        services.RegisterBasicsForTesting()
            .AddSingleton<IQuestLocatorService, Age3QuestLocatorService>();
        return services;
    }
    public static IServiceCollection RegisterTestQuestAge1Services(this IServiceCollection services)
    {
        services.RegisterBasicsForTesting()
            .AddSingleton<IQuestLocatorService, Age1QuestLocatorService>();
        return services;
    }
    public static IServiceCollection RegisterTestQuestAge2Services(this IServiceCollection services)
    {
        services.RegisterBasicsForTesting()
            .AddSingleton<IQuestLocatorService, Age2QuestLocatorService>();
        return services;
    }
    public static IServiceCollection TestAllTechs(this IServiceCollection services)
    {
        CheckUp();
        services.AddSingleton<IAddTechsToCharacterService, CompleteTechsCharacterService>()
            .AddSingleton<IAddTechsToTechTreeService, CompleteTechsService>();
        return services;
    }
    public static IServiceCollection TestMilestonesAlone(this IServiceCollection services)
    {
        CheckUp();
        services.AddSingleton<IAddTechsToCharacterService, MilestoneCharacterService>()
            .AddSingleton<IAddTechsToTechTreeService, MilestoneTechService>();
        return services;
    }
    public static IServiceCollection TestTraitsAlone(this IServiceCollection services)
    {
        CheckUp();
        services.AddSingleton<IAddTechsToCharacterService, TraitCharacterService>()
            .AddSingleton<IAddTechsToTechTreeService, TraitTechService>();
        return services;
    }
    public static IServiceCollection TestWondersAlone(this IServiceCollection services)
    {
        CheckUp();
        services.AddSingleton<IAddTechsToCharacterService, WonderCharacterService>()
            .AddSingleton<IAddTechsToTechTreeService, WonderTechService>();
        return services;
    }
    public static IServiceCollection TestAdvisorsAlone(this IServiceCollection services)
    {
        CheckUp();
        services.AddSingleton<IAddTechsToCharacterService, AdvisorCharacterService>()
            .AddSingleton<IAddTechsToTechTreeService, AdvisorTechService>();
        return services;
    }
    public static IServiceCollection TestNoTechs(this IServiceCollection services)
    {
        CheckUp();
        services.AddSingleton<IAddTechsToCharacterService, NoTechsCharacterService>()
            .AddSingleton<IAddTechsToTechTreeService, NoTechsTreeService>();
        return services;
    }
}