using Serilog;
using Serilog.Events;

namespace MockServer.Implementations
{
    public static class LoggerFactory
    {
        private const string LogFileName = "log.txt";

        public static void CreateLogger()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File(LogFileName)
                .WriteTo.Debug(restrictedToMinimumLevel: LogEventLevel.Debug)
                .WriteTo.Console(restrictedToMinimumLevel: LogEventLevel.Error)
                .CreateLogger();
        }
    }
}