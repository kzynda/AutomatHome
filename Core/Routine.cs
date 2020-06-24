using System.Threading;
using Core.Common;
using Core.Events;

namespace Core
{
    public class Routine: IRoutine
    {
        private ILogger _logger;

        public int Delay { get; set; } = 1000;
        public string Name { get; set; } = "Default name";

        public Routine(ILogger logger)
        {
            _logger = logger;
        }

        public void Execute()
        {
            while (true)
            {
                _logger.LogDebug($"Routine.Execute: {Name}");

                Thread.Sleep(Delay);

                var args = new SomeEventHandlerArgs()
                {
                    EventType = $"EventType {Name}"
                };
                
                SomeEvent?.Invoke(args);
            }
        }

        public event SomeEventHandler SomeEvent;
    }
}