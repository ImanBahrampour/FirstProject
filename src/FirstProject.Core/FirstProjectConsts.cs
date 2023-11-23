using FirstProject.Debugging;

namespace FirstProject
{
    public class FirstProjectConsts
    {
        public const string LocalizationSourceName = "FirstProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "fb22273ba1d048e5a5d6af2e1f78cfcb";
    }
}
