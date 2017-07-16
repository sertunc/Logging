using System;
using System.Diagnostics;

namespace Logging
{
    public class DatabaseLogger : ILogger
    {
        public override void SaveLog(long tckn, string requestDetails, string requestParameters, string response)
        {
            Debug.WriteLine("Taplam Saniye " + stopwatch.Elapsed.ToString());
        }

        public override string SerializeObjectForLog(object loggerObject)
        {
            throw new NotImplementedException();
        }
    }
}
