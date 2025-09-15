using BlazorServerDemo1.Models;

namespace BlazorServerDemo1.Data
{
    public class ProcessDemo
    {
        //private readonly IServiceProvider _service;
        private readonly IDemo _demo;
        //private readonly ILogger<ProcessDemo> _logger;
        //private readonly IConfiguration<ProcessDemo> _config;

        //public ProcessDemo(IServiceProvider service) // constructor injection 

        public int AnotherNumber { get; set; } = 3;
        public ProcessDemo(IDemo demo, int anotherNumber = 5) // constructor injection 
        {
            _demo = demo;
            //_service = service;
            AnotherNumber = anotherNumber;

        }

        //public ProcessDemo(IDemo demo) // constructor injection 
        //{
        //    _demo = demo;
        //    //_service = service;

        //}

        public int GetDaysInMonth()
        {
            PersonModel p = new PersonModel();

            p.FirstName = "Tim";
            //IDemo _demo = _service.GetRequiredService<IDemo>();
            return _demo.StartUpTime.Month switch
            {
                1 => 31,
                2 => (_demo.StartUpTime.Year % 4 == 0) ? 29: 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}
