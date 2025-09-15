namespace BlazorServerDemo1.Data
{
    public class Demo : IDemo, ILocalDemo, IDisposable
    {
        private readonly ILogger<Demo> _log;

        public DateTime StartUpTime { get; init; }

        public Demo(ILogger<Demo> log)
        {
            StartUpTime = DateTime.Now;
            _log = log;
        }

        public void Dispose()
        {
            _log.LogError($"Demo {StartUpTime.ToString("hh:mm:ss ffffff")}was disposed of");
        }
    }
}
