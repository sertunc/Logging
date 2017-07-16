namespace Logging
{
    public class Logger
    {
        ILogger _loger = null;

        public Logger(ILogger logger)
        {
            _loger = logger;
        }

        public void SaveLog(long tckn, string requestDetails, string requestParameters, string response)
        {
            _loger.SaveLog(tckn, requestDetails, requestParameters, response);
        }

        public string SerializeObjectForLog(object loggerObject)
        {
            return _loger.SerializeObjectForLog(loggerObject);
        }
    }
}
