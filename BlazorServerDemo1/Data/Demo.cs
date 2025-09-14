namespace BlazorServerDemo1.Data
{
    public class Demo : IDemo
    {
        public DateTime StartUpTime { get; init; }

        public Demo()
        {
            StartUpTime = DateTime.Now;
        }
    }
}
