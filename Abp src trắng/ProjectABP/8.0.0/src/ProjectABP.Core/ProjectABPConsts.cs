using ProjectABP.Debugging;

namespace ProjectABP
{
    public class ProjectABPConsts
    {
        public const string LocalizationSourceName = "ProjectABP";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fc712080d2d340f1a2b7d38a487e3f64";
    }
}
