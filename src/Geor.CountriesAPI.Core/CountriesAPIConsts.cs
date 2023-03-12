using Geor.CountriesAPI.Debugging;

namespace Geor.CountriesAPI
{
    public class CountriesAPIConsts
    {
        public const string LocalizationSourceName = "CountriesAPI";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "20d4cfda35334ebc83f66d99b75909b7";
    }
}
