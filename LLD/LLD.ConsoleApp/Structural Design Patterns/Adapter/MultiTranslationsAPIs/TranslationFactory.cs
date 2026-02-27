using LLD.ConsoleApp.Adapter.Translation;
using LLD.ConsoleApp.Adapter.Translation.External;
using LLD.ConsoleApp.Structural_Design_Patterns.Adapter.MultiTranslationsAPIs;

public enum ProviderType { Google, Microsoft }

public class TranslationFactory
{
    private static readonly Dictionary<ProviderType, ITranslationProviderAdapter> _providers = new()
    {
        [ProviderType.Google] = new GoogleTranslateAdapter(),
        [ProviderType.Microsoft] = new MicrosoftTranslationAdapter()
    };

    public static ITranslationProviderAdapter GetTranslationProvider(string providerType) => 
        _providers[Enum.Parse<ProviderType>(providerType, true)];
}