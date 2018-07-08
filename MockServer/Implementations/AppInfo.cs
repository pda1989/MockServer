using MockServer.Interfaces;

namespace MockServer.Implementations
{
    public class AppInfo : IAppInfo
    {
        public string GetAppVersion()
        {
            return "0.1";
        }
    }
}