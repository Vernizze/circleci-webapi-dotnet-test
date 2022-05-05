using Vrnz2.BaseContracts.Settings.Base;

namespace circleci_webapi_dotnet_test.Settings
{
    public class AppSettings
        : BaseAppSettings
    {
        public string DatabasePath { get; set; }
    }
}
