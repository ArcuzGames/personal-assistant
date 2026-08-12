namespace DBEngine
{
    internal class ResourceLogger : YooAsset.ILogger
    {
        public void Log(string message)
        {
            DBEngine.Log.Info(message);
        }

        public void Warning(string message)
        {
            DBEngine.Log.Warning(message);
        }

        public void Error(string message)
        {
            DBEngine.Log.Error(message);
        }

        public void Exception(System.Exception exception)
        {
            DBEngine.Log.Fatal(exception.Message);
        }
    }
}