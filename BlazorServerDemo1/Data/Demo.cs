namespace BlazorServerDemo1.Data
{
    public class Demo
    {
        public DateTime StartUpTime { get; init; }
    
        public Demo()
        {
            StartUpTime = DateTime.Now;
        }
    }
}
