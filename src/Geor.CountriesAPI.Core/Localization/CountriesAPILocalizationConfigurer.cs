using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Geor.CountriesAPI.Localization
{
    public static class CountriesAPILocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(CountriesAPIConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CountriesAPILocalizationConfigurer).GetAssembly(),
                        "Geor.CountriesAPI.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
