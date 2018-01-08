using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpSimpleCRUD.Localization
{
    public static class AbpSimpleCRUDLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpSimpleCRUDConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpSimpleCRUDLocalizationConfigurer).GetAssembly(),
                        "AbpSimpleCRUD.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
