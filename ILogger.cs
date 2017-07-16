using System.Diagnostics;

namespace Logging
{
    public abstract class ILogger
    {
        public Stopwatch stopwatch;
        private string loggerStatus = "1";

        public ILogger()
        {
            if (loggerStatus == "1")
            {
                if (stopwatch == null)
                {
                    stopwatch = new Stopwatch();
                    stopwatch.Start();
                }
            }
        }

        public abstract void SaveLog(long tckn, string requestDetails, string requestParameters, string response);

        public abstract string SerializeObjectForLog(object loggerObject);
    }
}
