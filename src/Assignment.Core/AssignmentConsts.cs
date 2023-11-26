using Assignment.Debugging;

namespace Assignment
{
    public class AssignmentConsts
    {
        public const string LocalizationSourceName = "Assignment";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "be10dbc13c104aa5b240dc9a794ff019";
    }
}
