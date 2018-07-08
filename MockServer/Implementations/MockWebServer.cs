using MockServer.Interfaces;
using Serilog;

namespace MockServer.Implementations
{
    public class MockWebServer : IServer
    {
        public void StartServer()
        {
            Log.Information("Started");
        }

        public void StopServer()
        {
            Log.Verbose("Stopped");
        }
    }
}